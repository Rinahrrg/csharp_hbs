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
    public partial class RoomsControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int editingRoomId = -1;

        public RoomsControl()
        {
            InitializeComponent();
            LoadHotels();
            LoadRoomTypes();
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

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFloors();
        }

        private void LoadFloors()
        {
            if (comboBoxHotel.SelectedValue == null) return;
            int hotelId = Convert.ToInt32(comboBoxHotel.SelectedValue);

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = "SELECT id FROM floors WHERE hotel_id = @hid ORDER BY id";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                da.SelectCommand.Parameters.AddWithValue("@hid", hotelId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxFloor.DisplayMember = "id";
                comboBoxFloor.ValueMember = "id";
                comboBoxFloor.DataSource = dt;
            }
            LoadRooms();
        }

        private void comboBoxFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void LoadRooms()
        {
            if (comboBoxFloor.SelectedValue == null) return;
            int floorId = Convert.ToInt32(comboBoxFloor.SelectedValue);

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
        SELECT 
            r.id,
            r.max_beds AS 'Max Beds',
            rt.name AS 'room_type'
        FROM rooms r
        JOIN room_types rt ON r.room_type_id = rt.id
        WHERE r.floor_id = @fid
        ORDER BY r.id";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                da.SelectCommand.Parameters.AddWithValue("@fid", floorId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewRooms.DataSource = dt;
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (comboBoxFloor.SelectedValue == null)
            {
                MessageBox.Show("Please select a floor.");
                return;
            }

            int floorId = Convert.ToInt32(comboBoxFloor.SelectedValue);
            int maxBeds = (int)numericUpDownBeds.Value;

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();

                // 1. Insertar habitación
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO rooms (floor_id, max_beds) VALUES (@fid, @beds)", c);
                cmd.Parameters.AddWithValue("@fid", floorId);
                cmd.Parameters.AddWithValue("@beds", maxBeds);
                cmd.ExecuteNonQuery();

                int newRoomId = (int)cmd.LastInsertedId;

                // 2. Asignar assets según checkboxes (ejemplo manual)
                // AC
                if (checkBoxAC.Checked)
                {
                    InsertAssetIfExists(c, newRoomId, "AC");
                }
                // TV
                if (checkBoxTV.Checked)
                {
                    InsertAssetIfExists(c, newRoomId, "TV");
                }
                // Shower
                if (checkBoxShower.Checked)
                {
                    InsertAssetIfExists(c, newRoomId, "Shower");
                }
                if (checkBoxMinibar.Checked)
                {
                    InsertAssetIfExists(c, newRoomId, "Fan");
                }
                if (checkBoxMinibar.Checked)
                {
                    InsertAssetIfExists(c, newRoomId, "Minibar");
                }
                if (checkBoxJacuzzi.Checked)
                {
                    InsertAssetIfExists(c, newRoomId, "Jacuzzi");
                }
                if (checkBoxTelephone.Checked)
                {
                    InsertAssetIfExists(c, newRoomId, "Telephone");
                }
                if (checkBoxCoffeeMachine.Checked)
                {
                    InsertAssetIfExists(c, newRoomId, "CoffeeMachine");
                }
                if (checkBoxHairDryer.Checked)
                {
                    InsertAssetIfExists(c, newRoomId, "HairDryer");
                }
            }

            MessageBox.Show("Room added with assets!");
            LoadRooms();
        }

        private void InsertAssetIfExists(MySqlConnection c, int roomId, string assetName)
        {
            // Search if the asset exists
            MySqlCommand find = new MySqlCommand("SELECT id FROM assets WHERE name = @name", c);
            find.Parameters.AddWithValue("@name", assetName);
            object result = find.ExecuteScalar();

            int assetId;
            if (result != null)
            {
                assetId = Convert.ToInt32(result);
            }
            else
            {
                // If not, create it
                MySqlCommand create = new MySqlCommand(
                    "INSERT INTO assets (name, asset_type) VALUES (@name, (SELECT id FROM asset_types WHERE type = @name))", c);
                create.Parameters.AddWithValue("@name", assetName);
                create.ExecuteNonQuery();
                assetId = (int)create.LastInsertedId;
            }

            // Link asset to the room
            MySqlCommand link = new MySqlCommand(
                "INSERT IGNORE INTO room_type_assets (room_id, asset_id) VALUES (@rid, @aid)", c);
            link.Parameters.AddWithValue("@rid", roomId);
            link.Parameters.AddWithValue("@aid", assetId);
            link.ExecuteNonQuery();
        }


        private void LoadRoomTypes()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, name FROM room_types ORDER BY name", c);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxCategory.DisplayMember = "name";
                comboBoxCategory.ValueMember = "id";
                comboBoxCategory.DataSource = dt;

                // If the table is empty, insert basic types
                if (dt.Rows.Count == 0)
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO room_types (name, description, bed_count) VALUES " +
                        "('Standard', 'Habitación estándar', 2)," +
                        "('Single', 'Habitación individual', 1)," +
                        "('Double', 'Habitación doble', 2)," +
                        "('Suite', 'Habitación suite de lujo', 3)", c);

                    cmd.ExecuteNonQuery();
                    LoadRoomTypes(); // reload after insertion
                }
            }
        }


        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to edit.");
                return;
            }

            var row = dataGridViewRooms.SelectedRows[0];

            editingRoomId = Convert.ToInt32(row.Cells["id"].Value);

            // Set Max Beds value
            numericUpDownBeds.Value = Convert.ToInt32(row.Cells["Max Beds"].Value);

            // Set Room Type value (make sure the column name matches your DataGridView column)
            comboBoxCategory.Text = row.Cells["room_type"].Value.ToString();
        }


        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (editingRoomId == -1) return;

            int maxBeds = (int)numericUpDownBeds.Value;
            int roomTypeId = Convert.ToInt32(comboBoxCategory.SelectedValue);

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE rooms SET max_beds = @beds, room_type_id = @rtid WHERE id = @id", c);
                cmd.Parameters.AddWithValue("@beds", maxBeds);
                cmd.Parameters.AddWithValue("@rtid", roomTypeId);
                cmd.Parameters.AddWithValue("@id", editingRoomId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Room updated!");
            LoadRooms();
            editingRoomId = -1;
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Delete this room?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int roomId = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["id"].Value);
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    new MySqlCommand($"DELETE FROM rooms WHERE id = {roomId}", c).ExecuteNonQuery();
                }
                LoadRooms();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadRooms();

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
