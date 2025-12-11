using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class AdminManagementControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int editingAdminId = -1;

        public AdminManagementControl()
        {
            InitializeComponent();

            // ESTAS 4 LÍNEAS HACEN QUE SE VEAN LAS LÍNEAS PERFECTO
            dataGridViewAdmins.GridColor = Color.Gray;
            dataGridViewAdmins.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewAdmins.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewAdmins.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Opcional: fondo blanco para mejor contraste
            dataGridViewAdmins.BackgroundColor = Color.White;
            dataGridViewAdmins.DefaultCellStyle.BackColor = Color.White;
            dataGridViewAdmins.DefaultCellStyle.ForeColor = Color.Black;

            LoadAdmins(); // o LoadAssets(), LoadBookings(), etc.
        }

        private void LoadAdmins()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                // SOLO username (tu tabla NO tiene 'name')
                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT id, username AS 'Username' FROM admin ORDER BY id", c);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAdmins.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and Password are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();

                    // Verificar si el username ya existe
                    MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM admin WHERE username = @u", c);
                    checkCmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

            // INSERTAR SIN COLUMNA 'name' (porque NO existe en tu tabla)
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO admin (username, password) VALUES (@u, @p)", c);
            cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@p", txtPassword.Text);
            cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Admin added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAdmins();
            ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmins.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dataGridViewAdmins.SelectedRows[0];
            editingAdminId = Convert.ToInt32(row.Cells["id"].Value);

            // SOLO CARGAR USERNAME (NO HAY 'Name')
            txtUsername.Text = row.Cells["Username"].Value.ToString();

            txtPassword.Clear();
            txtConfirmPassword.Clear();

            MessageBox.Show("Admin loaded. Change username and/or password, then click Update.\nLeave password blank to keep current one.",
                "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (editingAdminId == -1)
            {
                MessageBox.Show("Please select an admin to edit first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SOLO VALIDAR USERNAME (tu tabla NO tiene 'name')
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar contraseña solo si se ingresó
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                if (txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();

                    string sql;
                    MySqlCommand cmd;

                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        // Actualizar username + password
                        sql = "UPDATE admin SET username = @u, password = @p WHERE id = @id";
                        cmd = new MySqlCommand(sql, c);
                        cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                    }
                    else
                    {
                        // Solo actualizar username
                        sql = "UPDATE admin SET username = @u WHERE id = @id";
                        cmd = new MySqlCommand(sql, c);
                    }

                    cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", editingAdminId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Admin updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdmins();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmins.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlCommand countCmd = new MySqlCommand("SELECT COUNT(*) FROM admin", c);
                int adminCount = Convert.ToInt32(countCmd.ExecuteScalar());

                if (adminCount <= 1)
                {
                    MessageBox.Show("Cannot delete the last admin. At least one admin must exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int adminId = Convert.ToInt32(dataGridViewAdmins.SelectedRows[0].Cells["id"].Value);
            string adminUsername = dataGridViewAdmins.SelectedRows[0].Cells["Username"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete admin '{adminUsername}'?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection c = new MySqlConnection(conn))
                    {
                        c.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM admin WHERE id = @id", c);
                        cmd.Parameters.AddWithValue("@id", adminId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Admin deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdmins();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAdmins();
            ClearForm();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
            txtConfirmPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }

        private void ClearForm()
        {
            editingAdminId = -1;
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }
    }
}
