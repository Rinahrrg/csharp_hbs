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
            EnsureAssetTypesExist();
            EnsureAssetsExist();
            LoadRoomTypes();
            LoadHotels();

            // Conectar eventos correctamente
            comboBoxHotel.SelectedIndexChanged += ComboBoxHotel_SelectedIndexChanged_Event;
            comboBoxFloor.SelectedIndexChanged += ComboBoxFloor_SelectedIndexChanged_Event;
        }

        private void LoadHotels()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, name FROM hotels ORDER BY name", c);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        comboBoxHotel.DataSource = dt;
                        comboBoxHotel.DisplayMember = "name";
                        comboBoxHotel.ValueMember = "id";

                        // Cargar pisos del primer hotel
                        LoadFloors();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading hotels: " + ex.Message);
            }
        }

        private void ComboBoxHotel_SelectedIndexChanged_Event(object sender, EventArgs e)
        {
            LoadFloors();
        }

        private void LoadFloors()
        {
            try
            {
                if (comboBoxHotel.SelectedValue == null) return;

                int hotelId;
                if (!int.TryParse(comboBoxHotel.SelectedValue.ToString(), out hotelId)) return;

                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();

                    // Primero obtener los IDs de los pisos
                    string sql = "SELECT id FROM floors WHERE hotel_id = @hid ORDER BY id";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                    da.SelectCommand.Parameters.AddWithValue("@hid", hotelId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Crear una tabla con número de piso legible
                    DataTable displayTable = new DataTable();
                    displayTable.Columns.Add("id", typeof(int));
                    displayTable.Columns.Add("floor_name", typeof(string));

                    int floorNum = 1;
                    foreach (DataRow row in dt.Rows)
                    {
                        displayTable.Rows.Add(row["id"], "Floor " + floorNum);
                        floorNum++;
                    }

                    if (displayTable.Rows.Count > 0)
                    {
                        comboBoxFloor.DataSource = displayTable;
                        comboBoxFloor.DisplayMember = "floor_name";
                        comboBoxFloor.ValueMember = "id";

                        // Cargar habitaciones del primer piso
                        LoadRooms();
                    }
                    else
                    {
                        comboBoxFloor.DataSource = null;
                        dataGridViewRooms.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading floors: " + ex.Message);
            }
        }

        private void ComboBoxFloor_SelectedIndexChanged_Event(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void LoadRooms()
        {
            try
            {
                if (comboBoxFloor.SelectedValue == null) return;

                int floorId;
                if (!int.TryParse(comboBoxFloor.SelectedValue.ToString(), out floorId)) return;

                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();

                    // Query simplificado
                    string sql = @"
                        SELECT 
                            r.id AS 'ID',
                            h.name AS 'Hotel',
                            r.floor_id AS 'Floor ID',
                            r.max_beds AS 'Beds',
                            IFNULL(rt.name, 'Standard') AS 'Type',
                            IFNULL(GROUP_CONCAT(a.name SEPARATOR ', '), 'No assets') AS 'Assets'
                        FROM rooms r
                        JOIN floors f ON r.floor_id = f.id
                        JOIN hotels h ON f.hotel_id = h.id
                        LEFT JOIN room_types rt ON rt.bed_count = r.max_beds
                        LEFT JOIN room_type_assets rta ON r.id = rta.room_id
                        LEFT JOIN assets a ON rta.asset_id = a.id
                        WHERE r.floor_id = @fid
                        GROUP BY r.id, h.name, r.floor_id, r.max_beds, rt.name
                        ORDER BY r.id";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                    da.SelectCommand.Parameters.AddWithValue("@fid", floorId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewRooms.DataSource = dt;
                    dataGridViewRooms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }
        }

        private void EnsureAssetTypesExist()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    object count = new MySqlCommand("SELECT COUNT(*) FROM asset_types", c).ExecuteScalar();
                    if (Convert.ToInt32(count) == 0)
                    {
                        string sql = @"INSERT INTO asset_types (type, description, status) VALUES 
                            ('Electronic', 'Electronic devices', 'working'),
                            ('Appliance', 'Room appliances', 'working'),
                            ('Bathroom', 'Bathroom items', 'working')";
                        new MySqlCommand(sql, c).ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }

        private void EnsureAssetsExist()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    object count = new MySqlCommand("SELECT COUNT(*) FROM assets", c).ExecuteScalar();
                    if (Convert.ToInt32(count) == 0)
                    {
                        object electronicId = new MySqlCommand("SELECT id FROM asset_types WHERE type = 'Electronic'", c).ExecuteScalar();
                        object applianceId = new MySqlCommand("SELECT id FROM asset_types WHERE type = 'Appliance'", c).ExecuteScalar();
                        object bathroomId = new MySqlCommand("SELECT id FROM asset_types WHERE type = 'Bathroom'", c).ExecuteScalar();

                        if (electronicId != null && applianceId != null && bathroomId != null)
                        {
                            string sql = $@"INSERT INTO assets (name, description, brand, asset_type) VALUES 
                                ('TV', 'Television', 'Generic', {electronicId}),
                                ('AC', 'Air Conditioning', 'Generic', {electronicId}),
                                ('Telephone', 'Room telephone', 'Generic', {electronicId}),
                                ('Minibar', 'Mini refrigerator', 'Generic', {applianceId}),
                                ('Safe', 'Security safe', 'Generic', {applianceId}),
                                ('CoffeeMachine', 'Coffee maker', 'Generic', {applianceId}),
                                ('HairDryer', 'Hair dryer', 'Generic', {applianceId}),
                                ('Shower', 'Bathroom shower', 'Generic', {bathroomId}),
                                ('Jacuzzi', 'Jacuzzi tub', 'Generic', {bathroomId})";
                            new MySqlCommand(sql, c).ExecuteNonQuery();
                        }
                    }
                }
            }
            catch { }
        }

        private void LoadRoomTypes()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, name, bed_count FROM room_types ORDER BY bed_count", c);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MySqlCommand cmd = new MySqlCommand(
                            "INSERT INTO room_types (name, description, bed_count) VALUES " +
                            "('Single', 'Single room', 1)," +
                            "('Double', 'Double room', 2)," +
                            "('Suite', 'Luxury suite', 3)", c);
                        cmd.ExecuteNonQuery();

                        da = new MySqlDataAdapter("SELECT id, name, bed_count FROM room_types ORDER BY bed_count", c);
                        dt = new DataTable();
                        da.Fill(dt);
                    }

                    comboBoxCategory.DataSource = dt;
                    comboBoxCategory.DisplayMember = "name";
                    comboBoxCategory.ValueMember = "bed_count";
                }
            }
            catch { }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (comboBoxFloor.SelectedValue == null)
            {
                MessageBox.Show("Please select a hotel and floor first.");
                return;
            }

            int floorId;
            if (!int.TryParse(comboBoxFloor.SelectedValue.ToString(), out floorId))
            {
                MessageBox.Show("Invalid floor selected.");
                return;
            }

            int maxBeds = (int)numericUpDownBeds.Value;

            if (comboBoxCategory.SelectedValue != null)
            {
                int.TryParse(comboBoxCategory.SelectedValue.ToString(), out maxBeds);
            }

            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();

                    MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO rooms (floor_id, max_beds) VALUES (@fid, @beds)", c);
                    cmd.Parameters.AddWithValue("@fid", floorId);
                    cmd.Parameters.AddWithValue("@beds", maxBeds);
                    cmd.ExecuteNonQuery();

                    int newRoomId = (int)cmd.LastInsertedId;

                    if (checkBoxTV.Checked) LinkAssetToRoom(c, newRoomId, "TV");
                    if (checkBoxAC.Checked) LinkAssetToRoom(c, newRoomId, "AC");
                    if (checkBoxShower.Checked) LinkAssetToRoom(c, newRoomId, "Shower");
                    if (checkBoxMinibar.Checked) LinkAssetToRoom(c, newRoomId, "Minibar");
                    if (checkBoxJacuzzi.Checked) LinkAssetToRoom(c, newRoomId, "Jacuzzi");
                    if (checkBoxSafe.Checked) LinkAssetToRoom(c, newRoomId, "Safe");
                    if (checkBoxTelephone.Checked) LinkAssetToRoom(c, newRoomId, "Telephone");
                    if (checkBoxCoffeeMachine.Checked) LinkAssetToRoom(c, newRoomId, "CoffeeMachine");
                    if (checkBoxHairDryer.Checked) LinkAssetToRoom(c, newRoomId, "HairDryer");
                }

                MessageBox.Show("Room added successfully!");
                LoadRooms();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding room: " + ex.Message);
            }
        }

        private void LinkAssetToRoom(MySqlConnection c, int roomId, string assetName)
        {
            MySqlCommand find = new MySqlCommand("SELECT id FROM assets WHERE name = @name", c);
            find.Parameters.AddWithValue("@name", assetName);
            object result = find.ExecuteScalar();

            if (result != null)
            {
                int assetId = Convert.ToInt32(result);
                MySqlCommand link = new MySqlCommand(
                    "INSERT IGNORE INTO room_type_assets (room_id, asset_id) VALUES (@rid, @aid)", c);
                link.Parameters.AddWithValue("@rid", roomId);
                link.Parameters.AddWithValue("@aid", assetId);
                link.ExecuteNonQuery();
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
            editingRoomId = Convert.ToInt32(row.Cells["ID"].Value);
            int beds = Convert.ToInt32(row.Cells["Beds"].Value);
            numericUpDownBeds.Value = beds;

            // Seleccionar room type
            foreach (DataRowView item in comboBoxCategory.Items)
            {
                if (Convert.ToInt32(item["bed_count"]) == beds)
                {
                    comboBoxCategory.SelectedItem = item;
                    break;
                }
            }

            LoadRoomAssets(editingRoomId);
            MessageBox.Show("Room loaded. Make changes and click Update.");
        }

        private void LoadRoomAssets(int roomId)
        {
            checkBoxTV.Checked = false;
            checkBoxAC.Checked = false;
            checkBoxShower.Checked = false;
            checkBoxMinibar.Checked = false;
            checkBoxJacuzzi.Checked = false;
            checkBoxSafe.Checked = false;
            checkBoxTelephone.Checked = false;
            checkBoxCoffeeMachine.Checked = false;
            checkBoxHairDryer.Checked = false;

            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    string sql = @"SELECT a.name FROM room_type_assets rta 
                                   JOIN assets a ON rta.asset_id = a.id 
                                   WHERE rta.room_id = @rid";
                    MySqlCommand cmd = new MySqlCommand(sql, c);
                    cmd.Parameters.AddWithValue("@rid", roomId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string assetName = reader.GetString(0);
                            switch (assetName)
                            {
                                case "TV": checkBoxTV.Checked = true; break;
                                case "AC": checkBoxAC.Checked = true; break;
                                case "Shower": checkBoxShower.Checked = true; break;
                                case "Minibar": checkBoxMinibar.Checked = true; break;
                                case "Jacuzzi": checkBoxJacuzzi.Checked = true; break;
                                case "Safe": checkBoxSafe.Checked = true; break;
                                case "Telephone": checkBoxTelephone.Checked = true; break;
                                case "CoffeeMachine": checkBoxCoffeeMachine.Checked = true; break;
                                case "HairDryer": checkBoxHairDryer.Checked = true; break;
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (editingRoomId == -1)
            {
                MessageBox.Show("Please select a room to edit first.");
                return;
            }

            int maxBeds = (int)numericUpDownBeds.Value;

            if (comboBoxCategory.SelectedValue != null)
            {
                int.TryParse(comboBoxCategory.SelectedValue.ToString(), out maxBeds);
            }

            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();

                    MySqlCommand cmd = new MySqlCommand(
                        "UPDATE rooms SET max_beds = @beds WHERE id = @id", c);
                    cmd.Parameters.AddWithValue("@beds", maxBeds);
                    cmd.Parameters.AddWithValue("@id", editingRoomId);
                    cmd.ExecuteNonQuery();

                    MySqlCommand deleteCmd = new MySqlCommand("DELETE FROM room_type_assets WHERE room_id = @rid", c);
                    deleteCmd.Parameters.AddWithValue("@rid", editingRoomId);
                    deleteCmd.ExecuteNonQuery();

                    if (checkBoxTV.Checked) LinkAssetToRoom(c, editingRoomId, "TV");
                    if (checkBoxAC.Checked) LinkAssetToRoom(c, editingRoomId, "AC");
                    if (checkBoxShower.Checked) LinkAssetToRoom(c, editingRoomId, "Shower");
                    if (checkBoxMinibar.Checked) LinkAssetToRoom(c, editingRoomId, "Minibar");
                    if (checkBoxJacuzzi.Checked) LinkAssetToRoom(c, editingRoomId, "Jacuzzi");
                    if (checkBoxSafe.Checked) LinkAssetToRoom(c, editingRoomId, "Safe");
                    if (checkBoxTelephone.Checked) LinkAssetToRoom(c, editingRoomId, "Telephone");
                    if (checkBoxCoffeeMachine.Checked) LinkAssetToRoom(c, editingRoomId, "CoffeeMachine");
                    if (checkBoxHairDryer.Checked) LinkAssetToRoom(c, editingRoomId, "HairDryer");
                }

                MessageBox.Show("Room updated!");
                LoadRooms();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message);
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            if (MessageBox.Show("Delete this room?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int roomId = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["ID"].Value);

                try
                {
                    using (MySqlConnection c = new MySqlConnection(conn))
                    {
                        c.Open();

                        MySqlCommand deleteAssets = new MySqlCommand("DELETE FROM room_type_assets WHERE room_id = @rid", c);
                        deleteAssets.Parameters.AddWithValue("@rid", roomId);
                        deleteAssets.ExecuteNonQuery();

                        MySqlCommand deleteRoom = new MySqlCommand("DELETE FROM rooms WHERE id = @rid", c);
                        deleteRoom.Parameters.AddWithValue("@rid", roomId);
                        deleteRoom.ExecuteNonQuery();
                    }

                    MessageBox.Show("Room deleted!");
                    LoadRooms();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting room: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            editingRoomId = -1;
            numericUpDownBeds.Value = 1;

            checkBoxTV.Checked = false;
            checkBoxAC.Checked = false;
            checkBoxShower.Checked = false;
            checkBoxMinibar.Checked = false;
            checkBoxJacuzzi.Checked = false;
            checkBoxSafe.Checked = false;
            checkBoxTelephone.Checked = false;
            checkBoxCoffeeMachine.Checked = false;
            checkBoxHairDryer.Checked = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRooms();
        }

        // Eventos vacíos del Designer (no borrar)
        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxFloor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
    }
}