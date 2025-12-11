using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class AddHotelControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int editingId = -1;
        private byte[] currentImageBytes = null;

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
            ofd.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                currentImageBytes = File.ReadAllBytes(ofd.FileName);
            }
        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            currentImageBytes = null;
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
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO hotels (name, address, default_booking_time, image) VALUES (@n, @a, @t, @img)", c);
                cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@t", numericUpDownFloors.Value);

                if (currentImageBytes != null)
                    cmd.Parameters.AddWithValue("@img", currentImageBytes);
                else
                    cmd.Parameters.AddWithValue("@img", DBNull.Value);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Hotel added successfully!");
            LoadHotels();
            ClearForm();
        }

        private void btnEditHotel_Click(object sender, EventArgs e)
        {
            if (dataGridViewHotels.SelectedRows.Count == 0) return;

            var row = dataGridViewHotels.SelectedRows[0];
            editingId = Convert.ToInt32(row.Cells["id"].Value);
            txtName.Text = row.Cells["Hotel Name"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            numericUpDownFloors.Value = Convert.ToInt32(row.Cells["Default Booking Time (hrs)"].Value);

            // Load image
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT image FROM hotels WHERE id = @id", c);
                cmd.Parameters.AddWithValue("@id", editingId);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    currentImageBytes = (byte[])result;
                    using (MemoryStream ms = new MemoryStream(currentImageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    currentImageBytes = null;
                }
            }

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
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE hotels SET name=@n, address=@a, default_booking_time=@t, image=@img WHERE id=@id", c);
                cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@t", numericUpDownFloors.Value);
                cmd.Parameters.AddWithValue("@id", editingId);

                if (currentImageBytes != null)
                    cmd.Parameters.AddWithValue("@img", currentImageBytes);
                else
                    cmd.Parameters.AddWithValue("@img", DBNull.Value);

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

            if (MessageBox.Show($"Are you sure you want to delete hotel \"{hotelName}\"?\n\nALL floors, rooms, and bookings will be deleted.",
                "CONFIRM DELETION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection c = new MySqlConnection(conn))
                    {
                        c.Open();
                        new MySqlCommand($"DELETE FROM floors WHERE hotel_id = {hotelId}", c).ExecuteNonQuery();
                        new MySqlCommand($"DELETE FROM hotels WHERE id = {hotelId}", c).ExecuteNonQuery();
                    }

                    MessageBox.Show("Hotel deleted successfully!", "BOOKIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHotels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadHotels();

        private void ClearForm()
        {
            editingId = -1;
            txtName.Clear();
            txtAddress.Clear();
            numericUpDownFloors.Value = 24;
            pictureBox1.Image = null;
            currentImageBytes = null;
        }

        // Empty event handlers
        private void label2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_2(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void numericUpDownFloors_ValueChanged(object sender, EventArgs e) { }
        private void dataGridViewHotels_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}