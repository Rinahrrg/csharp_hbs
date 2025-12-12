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
    public partial class FormRoomSelection : Form
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int hotelId;
        private int customerId;
        private string hotelName;
        private int? selectedRoomId = null;

        public FormRoomSelection(int hotelId, int customerId, string hotelName, DateTime checkIn, DateTime checkOut)
        {
            InitializeComponent();
            this.hotelId = hotelId;
            this.customerId = customerId;
            this.hotelName = hotelName;

            lblHotelnName.Text = hotelName;

            dtpCheckin.Value = checkIn;
            dtpCheckout.Value = checkOut;
            dtpCheckin.MinDate = DateTime.Today;
            dtpCheckout.MinDate = DateTime.Today.AddDays(1);

            // Connect events
            comboBoxFloor.SelectedIndexChanged += ComboBoxFloor_SelectedIndexChanged;
            dtpCheckin.ValueChanged += DatePicker_ValueChanged;
            dtpCheckout.ValueChanged += DatePicker_ValueChanged;

            // Set default food option
            chkNone.Checked = true;

            // Connect food checkbox events for mutual exclusion
            chkBreakfast.CheckedChanged += FoodOption_CheckedChanged;
            chkLunch.CheckedChanged += FoodOption_CheckedChanged;
            chkDinner.CheckedChanged += FoodOption_CheckedChanged;
            chkFullBoard.CheckedChanged += FoodOption_CheckedChanged;
            chkNone.CheckedChanged += FoodOption_CheckedChanged;

            LoadFloors();
        }

        // Keep original constructor for backward compatibility
        public FormRoomSelection(int hotelId, int customerId) : this(hotelId, customerId, "", DateTime.Today, DateTime.Today.AddDays(1))
        {
        }

        private void FoodOption_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                if (chk == chkFullBoard)
                {
                    chkBreakfast.Checked = false;
                    chkLunch.Checked = false;
                    chkDinner.Checked = false;
                    chkNone.Checked = false;
                }
                else if (chk == chkNone)
                {
                    chkBreakfast.Checked = false;
                    chkLunch.Checked = false;
                    chkDinner.Checked = false;
                    chkFullBoard.Checked = false;
                }
                else
                {
                    chkFullBoard.Checked = false;
                    chkNone.Checked = false;
                }
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckout.Value <= dtpCheckin.Value)
            {
                dtpCheckout.Value = dtpCheckin.Value.AddDays(1);
            }
            LoadAvailableRooms();
        }

        private void LoadFloors()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    string sql = "SELECT id FROM floors WHERE hotel_id = @hid ORDER BY id";
                    MySqlCommand cmd = new MySqlCommand(sql, c);
                    cmd.Parameters.AddWithValue("@hid", hotelId);

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    // Create display table with floor numbers
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
                    }
                    else
                    {
                        MessageBox.Show("No floors available for this hotel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading floors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableRooms();
        }

        private void LoadAvailableRooms()
        {
            flowLayoutPanelRooms.Controls.Clear();
            selectedRoomId = null;
            UpdateSummary();

            if (comboBoxFloor.SelectedValue == null) return;

            int floorId;
            if (!int.TryParse(comboBoxFloor.SelectedValue.ToString(), out floorId)) return;

            DateTime checkIn = dtpCheckin.Value.Date;
            DateTime checkOut = dtpCheckout.Value.Date;

            // Update the label
            label6.Text = $"Available Rooms for {comboBoxFloor.Text}:";

            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    string sql = @"
                        SELECT 
                            r.id,
                            r.max_beds,
                            IFNULL(rt.name, 'Standard') AS room_type,
                            (SELECT GROUP_CONCAT(a.name SEPARATOR ', ') 
                             FROM room_type_assets rta
                             JOIN assets a ON rta.asset_id = a.id
                             WHERE rta.room_id = r.id) AS assets
                        FROM rooms r
                        LEFT JOIN room_types rt ON rt.bed_count = r.max_beds
                        WHERE r.floor_id = @fid
                        AND r.id NOT IN (
                            SELECT room_id FROM bookings 
                            WHERE (start_time < @out AND end_time > @in)
                        )
                        ORDER BY r.id";

                    MySqlCommand cmd = new MySqlCommand(sql, c);
                    cmd.Parameters.AddWithValue("@fid", floorId);
                    cmd.Parameters.AddWithValue("@in", checkIn);
                    cmd.Parameters.AddWithValue("@out", checkOut);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int roomCount = 0;
                    while (reader.Read())
                    {
                        roomCount++;
                        Panel roomCard = CreateRoomCard(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToInt32(reader["max_beds"]),
                            reader["room_type"].ToString(),
                            reader["assets"] == DBNull.Value ? "None" : reader["assets"].ToString()
                        );
                        flowLayoutPanelRooms.Controls.Add(roomCard);
                    }

                    if (roomCount == 0)
                    {
                        Label noRooms = new Label();
                        noRooms.Text = "No available rooms for the selected dates.";
                        noRooms.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
                        noRooms.ForeColor = Color.Gray;
                        noRooms.AutoSize = true;
                        noRooms.Padding = new Padding(10);
                        flowLayoutPanelRooms.Controls.Add(noRooms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateRoomCard(int roomId, int beds, string roomType, string assets)
        {
            Panel roomCard = new Panel();
            roomCard.Width = 380;
            roomCard.Height = 140;
            roomCard.BorderStyle = BorderStyle.FixedSingle;
            roomCard.BackColor = Color.White;
            roomCard.Margin = new Padding(5);
            roomCard.Padding = new Padding(10);

            Label lblRoom = new Label();
            lblRoom.Text = $"Room {roomId} - {roomType}";
            lblRoom.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRoom.Location = new Point(10, 10);
            lblRoom.AutoSize = true;
            roomCard.Controls.Add(lblRoom);

            Label lblBeds = new Label();
            lblBeds.Text = $"🛏️ Beds: {beds}";
            lblBeds.Font = new Font("Segoe UI", 9F);
            lblBeds.Location = new Point(10, 40);
            lblBeds.AutoSize = true;
            roomCard.Controls.Add(lblBeds);

            Label lblAssets = new Label();
            string displayAssets = assets.Length > 35 ? assets.Substring(0, 32) + "..." : assets;
            lblAssets.Text = $"✨ Amenities: {displayAssets}";
            lblAssets.Font = new Font("Segoe UI", 9F);
            lblAssets.Location = new Point(10, 65);
            lblAssets.Size = new Size(250, 20);
            roomCard.Controls.Add(lblAssets);

            // Calculate price (example: $50 per bed per night)
            int nights = (dtpCheckout.Value.Date - dtpCheckin.Value.Date).Days;
            decimal price = beds * 50 * nights;

            Label lblPrice = new Label();
            lblPrice.Text = $"💰 ${price} ({nights} nights)";
            lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Green;
            lblPrice.Location = new Point(10, 90);
            lblPrice.AutoSize = true;
            roomCard.Controls.Add(lblPrice);

            Button btnSelect = new Button();
            btnSelect.Text = "Select";
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSelect.Size = new Size(80, 35);
            btnSelect.Location = new Point(285, 85);
            btnSelect.BackColor = Color.Black;
            btnSelect.ForeColor = Color.White;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Tag = new { RoomId = roomId, Beds = beds, RoomType = roomType, Assets = assets, Price = price };
            btnSelect.Click += BtnSelectRoom_Click;
            roomCard.Controls.Add(btnSelect);

            return roomCard;
        }

        private void BtnSelectRoom_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            dynamic roomData = btn.Tag;

            selectedRoomId = roomData.RoomId;
            UpdateSummary(roomData.RoomId, roomData.Beds, roomData.RoomType, roomData.Assets, roomData.Price);

            // Highlight selected card
            foreach (Control ctrl in flowLayoutPanelRooms.Controls)
            {
                if (ctrl is Panel panel)
                {
                    panel.BackColor = Color.White;
                }
            }
            ((Panel)btn.Parent).BackColor = Color.LightBlue;
        }

        private void UpdateSummary(int roomId = 0, int beds = 0, string roomType = "", string assets = "", decimal price = 0)
        {
            if (roomId == 0)
            {
                lblBookingCode.Text = "Select a room to continue...";
                btnConfirm.Enabled = false;
                return;
            }

            string foodOption = GetFoodOption();
            int nights = (dtpCheckout.Value.Date - dtpCheckin.Value.Date).Days;

            lblBookingCode.Text = $"📋 BOOKING SUMMARY\n\n" +
                                  $"🏨 Hotel: {hotelName}\n" +
                                  $"🚪 Room: {roomId} ({roomType})\n" +
                                  $"🛏️ Beds: {beds}\n" +
                                  $"📅 Check-in: {dtpCheckin.Value:MMM dd, yyyy}\n" +
                                  $"📅 Check-out: {dtpCheckout.Value:MMM dd, yyyy}\n" +
                                  $"🌙 Nights: {nights}\n" +
                                  $"🍽️ Food: {foodOption}\n" +
                                  $"💰 Total: ${price}";

            btnConfirm.Enabled = true;
        }

        private string GetFoodOption()
        {
            List<string> options = new List<string>();
            if (chkBreakfast.Checked) options.Add("Breakfast");
            if (chkLunch.Checked) options.Add("Lunch");
            if (chkDinner.Checked) options.Add("Dinner");
            if (chkFullBoard.Checked) return "Full Board";
            if (chkNone.Checked || options.Count == 0) return "None";
            return string.Join(", ", options);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == null)
            {
                MessageBox.Show("Please select a room first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime checkIn = dtpCheckin.Value;
            DateTime checkOut = dtpCheckout.Value;

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out must be after check-in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string foodOption = GetFoodOption();

            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();

                    // Generate unique booking code
                    Random rnd = new Random();
                    string code = "BK-" + DateTime.Now.ToString("yyyyMMdd") + "-" + rnd.Next(0, 9999).ToString("D4");

                    // Verify uniqueness
                    while (true)
                    {
                        MySqlCommand check = new MySqlCommand("SELECT COUNT(*) FROM bookings WHERE booking_code = @code", c);
                        check.Parameters.AddWithValue("@code", code);
                        if (Convert.ToInt32(check.ExecuteScalar()) == 0) break;
                        code = "BK-" + DateTime.Now.ToString("yyyyMMdd") + "-" + rnd.Next(0, 9999).ToString("D4");
                    }

                    // FIXED: Added hotel_id to the INSERT statement
                    MySqlCommand cmd = new MySqlCommand(@"
                INSERT INTO bookings 
                (booking_code, hotel_id, room_id, customer_id, start_time, end_time, food_option)
                VALUES (@code, @hid, @rid, @cid, @in, @out, @food)", c);

                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@hid", hotelId);  // Added hotel_id parameter
                    cmd.Parameters.AddWithValue("@rid", selectedRoomId.Value);
                    cmd.Parameters.AddWithValue("@cid", customerId);
                    cmd.Parameters.AddWithValue("@in", checkIn);
                    cmd.Parameters.AddWithValue("@out", checkOut);
                    cmd.Parameters.AddWithValue("@food", foodOption);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"✅ Booking Confirmed!\n\nYour booking code is:\n{code}\n\nPlease save this code for your records.",
                        "BOOKIFY - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            // This is handled by BtnSelectRoom_Click now
        }

        private void chkLunch_CheckedChanged(object sender, EventArgs e)
        {
            // Handled by FoodOption_CheckedChanged
        }

        private void chkDinner_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFloor_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
