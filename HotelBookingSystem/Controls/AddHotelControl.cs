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
    public partial class AddHotelControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int editingId = -1;

        public AddHotelControl()
        {
            InitializeComponent();
            LoadHotels();
        }

        private void LoadHotels()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, name AS 'Hotel Name', address AS 'Address', default_booking_time AS 'Default Booking Time (hrs)' FROM hotels", c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewHotels.DataSource = dt;
            }
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Name and Address are required!");
                return;
            }

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO hotels (name, address, default_booking_time) VALUES (@n, @a, @t)", c);
                cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@t", numericUpDownFloors.Value);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Hotel added successfully!");
            LoadHotels();
            ClearForm();

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                var count = new MySqlCommand("SELECT COUNT(*) FROM hotels", c).ExecuteScalar();
                if (Convert.ToInt32(count) == 0)
                    new MySqlCommand("ALTER TABLE hotels AUTO_INCREMENT = 1", c).ExecuteNonQuery();
            }
        }

        private void btnEditHotel_Click(object sender, EventArgs e)
        {
            if (dataGridViewHotels.SelectedRows.Count == 0) return;

            var row = dataGridViewHotels.SelectedRows[0];
            editingId = Convert.ToInt32(row.Cells["id"].Value);
            txtName.Text = row.Cells["Hotel Name"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            numericUpDownFloors.Value = Convert.ToInt32(row.Cells["Default Booking Time (hrs)"].Value);
            MessageBox.Show("Hotel loaded. Modify and click Save.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editingId == -1)
            {
                MessageBox.Show("No hotel selected to save.");
                return;
            }

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE hotels SET name=@n, address=@a, default_booking_time=@t WHERE id=@id", c);
                cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@t", numericUpDownFloors.Value);
                cmd.Parameters.AddWithValue("@id", editingId);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Hotel updated!");
            LoadHotels();
            ClearForm();
        }

        private void btnDeleteHotel_Click(object sender, EventArgs e)
        {
            if (dataGridViewHotels.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a hotel to delete.", "BOOKIFY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int hotelId = Convert.ToInt32(dataGridViewHotels.SelectedRows[0].Cells["id"].Value);
            string hotelName = dataGridViewHotels.SelectedRows[0].Cells["Hotel Name"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete hotel \"{hotelName}\"?\n\n" +
                "ALL floors, rooms, and bookings of this hotel will be deleted permanently.",
                "CONFIRM DELETION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection("server=localhost;database=hotel_system;user=root;password=Hrrg2906_;"))
                    {
                        conn.Open();

                        // Borra en orden correcto (primero hijos, luego padre)
                        new MySqlCommand($"DELETE FROM floors WHERE hotel_id = {hotelId}", conn).ExecuteNonQuery();
                        new MySqlCommand($"DELETE FROM hotels WHERE id = {hotelId}", conn).ExecuteNonQuery();
                    }

                    MessageBox.Show("Hotel deleted successfully!", "BOOKIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHotels(); // recarga la lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnViewHotels_Click(object sender, EventArgs e) => LoadHotels();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadHotels();

        private void ClearForm()
        {
            editingId = -1;
            txtName.Clear();
            txtAddress.Clear();
            numericUpDownFloors.Value = 24;
            pictureBox1.Image = null;
        }

        private void dataGridViewHotels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewHotels.Rows[e.RowIndex];
                editingId = Convert.ToInt32(row.Cells["id"].Value);
                txtName.Text = row.Cells["Hotel Name"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                numericUpDownFloors.Value = Convert.ToInt32(row.Cells["Default Booking Time (hrs)"].Value);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewHotels_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void numericUpDownFloors_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewHotels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
