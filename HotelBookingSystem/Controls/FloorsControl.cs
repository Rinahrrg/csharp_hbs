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
    public partial class FloorsControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int editingFloorId = -1;

        public FloorsControl()
        {
            InitializeComponent();
            LoadHotels();
        }

        private void LoadHotels()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, name FROM hotels ORDER BY name", c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxHotel.DisplayMember = "name";
                comboBoxHotel.ValueMember = "id";
                comboBoxHotel.DataSource = dt;
            }
        }

        private void LoadFloors()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT 
                        f.id,
                        h.name AS 'Hotel',
                        ROW_NUMBER() OVER (PARTITION BY f.hotel_id ORDER BY f.id) AS 'Floor #',
                        f.max_rooms AS 'Max Rooms',
                        (SELECT COUNT(*) FROM rooms r WHERE r.floor_id = f.id) AS 'Rooms Created'
                    FROM floors f
                    JOIN hotels h ON f.hotel_id = h.id
                    ORDER BY h.name, 'Floor #'";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewFloors.DataSource = dt;
            }
        }


        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFloors();
        }

        private void btnAddFloor_Click(object sender, EventArgs e)
        {
            if (comboBoxHotel.SelectedValue == null)
            {
                MessageBox.Show("Please select a hotel first.");
                return;
            }

            int hotelId = Convert.ToInt32(comboBoxHotel.SelectedValue);
            int maxRooms = (int)numericUpDownMaxRooms.Value;

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO floors (hotel_id, max_rooms) VALUES (@hid, @max)", c);
                cmd.Parameters.AddWithValue("@hid", hotelId);
                cmd.Parameters.AddWithValue("@max", maxRooms);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Floor added successfully!");
            LoadFloors();
        }

        private void btnEditFloor_Click(object sender, EventArgs e)
        {
            if (dataGridViewFloors.SelectedRows.Count == 0) return;

            var row = dataGridViewFloors.SelectedRows[0];
            editingFloorId = Convert.ToInt32(row.Cells["id"].Value);
            numericUpDownMaxRooms.Value = Convert.ToInt32(row.Cells["Max Rooms"].Value);
        }

        private void btnUpdateFloor_Click(object sender, EventArgs e)
        {
            if (editingFloorId == -1) return;

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE floors SET max_rooms = @max WHERE id = @id", c);
                cmd.Parameters.AddWithValue("@max", (int)numericUpDownMaxRooms.Value);
                cmd.Parameters.AddWithValue("@id", editingFloorId);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Floor updated!");
            LoadFloors();
            editingFloorId = -1;
        }

        private void btnDeleteFloor_Click(object sender, EventArgs e)
        {
            if (dataGridViewFloors.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Delete this floor and ALL its rooms?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int floorId = Convert.ToInt32(dataGridViewFloors.SelectedRows[0].Cells["id"].Value);
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    new MySqlCommand($"DELETE FROM rooms WHERE floor_id = {floorId}", c).ExecuteNonQuery();
                    new MySqlCommand($"DELETE FROM floors WHERE id = {floorId}", c).ExecuteNonQuery();
                }
                LoadFloors();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadFloors();
        private void FloorsControl_Load(object sender, EventArgs e)
        {

        }
        private void dataGridViewFloors_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFloors.SelectedRows.Count > 0)
            {
                var row = dataGridViewFloors.SelectedRows[0];
                editingFloorId = Convert.ToInt32(row.Cells["id"].Value);
                numericUpDownMaxRooms.Value = Convert.ToInt32(row.Cells["Max Rooms"].Value);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewFloors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
