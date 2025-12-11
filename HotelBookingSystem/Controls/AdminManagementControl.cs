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
            LoadAdmins();
        }

        private void LoadAdmins()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, name AS 'Name', username AS 'Username' FROM admin", c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAdmins.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    // Check if username already exists
                    MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM admin WHERE username = @u", c);
                    checkCmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO admin (name, username, password) VALUES (@n, @u, @p)", c);
                    cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
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
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtUsername.Text = row.Cells["Username"].Value.ToString();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            MessageBox.Show("Admin loaded. Make changes and click Update.\nLeave password fields empty to keep current password.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (editingAdminId == -1)
            {
                MessageBox.Show("Please select an admin to edit first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Name and Username are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If password is provided, validate it
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
                        sql = "UPDATE admin SET name=@n, username=@u, password=@p WHERE id=@id";
                        cmd = new MySqlCommand(sql, c);
                        cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                    }
                    else
                    {
                        sql = "UPDATE admin SET name=@n, username=@u WHERE id=@id";
                        cmd = new MySqlCommand(sql, c);
                    }

                    cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
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

            // Check if there's more than one admin
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
            string adminName = dataGridViewAdmins.SelectedRows[0].Cells["Name"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete admin '{adminName}'?", "Confirm Delete",
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
