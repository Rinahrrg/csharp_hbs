using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelBookingSystem
{
    public partial class FormRoomSelection : Form
    {
        private readonly string connectionString = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int hotelId;
        private string hotelName;
        private string customerUsername;
        private DateTime checkInDate;
        private DateTime checkOutDate;

        public FormRoomSelection(int hotelId, string hotelName, string customerUsername, DateTime checkIn, DateTime checkOut)
        {
            InitializeComponent();
            this.hotelId = hotelId;
            this.hotelName = hotelName;
            this.customerUsername = customerUsername;
            this.checkInDate = checkIn;
            this.checkOutDate = checkOut;
        }

        private void FormRoomSelection_Load(object sender, EventArgs e)
        {
            lblHotelName.Text = hotelName;
            lblDates.Text = $"📅 {checkInDate.ToShortDateString()} - {checkOutDate.ToShortDateString()}";
            int nights = (checkOutDate - checkInDate).Days;
            lblNights.Text = $"🌙 {nights} night{(nights > 1 ? "s" : "")}";

            LoadAvailableRooms();
        }

        private void dataGridViewRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                ShowRoomDetails();
            }
        }

        private void ShowRoomDetails()
        {
            if (dataGridViewRooms.SelectedRows.Count == 0) return;

            DataGridViewRow selectedRow = dataGridViewRooms.SelectedRows[0];

            string roomNumber = selectedRow.Cells["Room Number"].Value.ToString();
            string beds = selectedRow.Cells["Beds"].Value.ToString();
            string roomType = selectedRow.Cells["Room Type"].Value.ToString();
            string amenities = selectedRow.Cells["Amenities"].Value.ToString();

            // Format the details nicely
            string details = $"📌 {roomNumber}\n\n";
            details += $"🛏️ Beds: {beds}\n\n";
            details += $"🏷️ Type: {roomType}\n\n";
            details += $"✨ Amenities:\n";

            // Split amenities and format as a list
            if (amenities != "No assets" && !string.IsNullOrEmpty(amenities))
            {
                string[] amenityList = amenities.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string amenity in amenityList)
                {
                    details += $"  • {amenity}\n";
                }
            }
            else
            {
                details += "  • Basic room amenities\n";
            }

            details += $"\n📅 Stay Duration:\n";
            details += $"  {checkInDate.ToShortDateString()}\n";
            details += $"  to {checkOutDate.ToShortDateString()}\n";
            int nights = (checkOutDate - checkInDate).Days;
            details += $"  ({nights} night{(nights > 1 ? "s" : "")})";

            lblRoomDetailsContent.Text = details;
        }

        private void LoadAvailableRooms()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Get all rooms for this hotel
                    string sql = @"
                        SELECT
                            r.id AS 'Room ID',
                            CONCAT('Floor ', f.id, ' - Room ', r.id) AS 'Room Number',
                            r.max_beds AS 'Beds',
                            IFNULL(rt.name, 'Standard') AS 'Room Type',
                            IFNULL(GROUP_CONCAT(DISTINCT a.name SEPARATOR ', '), 'No assets') AS 'Amenities'
                        FROM rooms r
                        JOIN floors f ON r.floor_id = f.id
                        JOIN hotels h ON f.hotel_id = h.id
                        LEFT JOIN room_types rt ON rt.bed_count = r.max_beds
                        LEFT JOIN room_type_assets rta ON r.id = rta.room_id
                        LEFT JOIN assets a ON rta.asset_id = a.id
                        WHERE h.id = @hotelId
                        GROUP BY r.id, f.id, r.max_beds, rt.name
                        ORDER BY f.id, r.id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@hotelId", hotelId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No rooms available for this hotel. Please contact the administrator.",
                            "No Rooms Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }

                    dataGridViewRooms.DataSource = dt;
                    dataGridViewRooms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

                    // Hide the Room ID column
                    if (dataGridViewRooms.Columns["Room ID"] != null)
                    {
                        dataGridViewRooms.Columns["Room ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to book.", "No Room Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomId = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["Room ID"].Value);
            string roomNumber = dataGridViewRooms.SelectedRows[0].Cells["Room Number"].Value.ToString();
            string roomType = dataGridViewRooms.SelectedRows[0].Cells["Room Type"].Value.ToString();
            string amenities = dataGridViewRooms.SelectedRows[0].Cells["Amenities"].Value.ToString();

            // Get selected food plan
            string foodPlan = GetSelectedFoodPlan();

            // Create the booking
            bool success = CreateBooking(roomId, foodPlan);

            if (success)
            {
                int nights = (checkOutDate - checkInDate).Days;

                MessageBox.Show($"🎉 Booking Confirmed!\n\n" +
                              $"Hotel: {hotelName}\n" +
                              $"Room: {roomNumber}\n" +
                              $"Type: {roomType}\n" +
                              $"Amenities: {amenities}\n\n" +
                              $"Check-in: {checkInDate.ToShortDateString()}\n" +
                              $"Check-out: {checkOutDate.ToShortDateString()}\n" +
                              $"Duration: {nights} night{(nights > 1 ? "s" : "")}\n\n" +
                              $"Food Plan: {foodPlan}\n\n" +
                              $"Your booking has been saved!\n" +
                              $"We look forward to welcoming you!",
                              "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private string GetSelectedFoodPlan()
        {
            if (radioBreakfast.Checked) return "Bed and Breakfast (BB)";
            if (radioHalfBoard.Checked) return "Half Board (Breakfast + Dinner)";
            if (radioFullBoard.Checked) return "Full Board (All Meals)";
            return "Room Only (No Meals)";
        }

        private bool CreateBooking(int roomId, string foodPlan)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // First get the customer ID from username
                    string getCustomerIdSql = "SELECT id FROM customers WHERE username = @username";
                    MySqlCommand getCustomerIdCmd = new MySqlCommand(getCustomerIdSql, conn);
                    getCustomerIdCmd.Parameters.AddWithValue("@username", customerUsername);
                    object customerIdObj = getCustomerIdCmd.ExecuteScalar();

                    if (customerIdObj == null)
                    {
                        MessageBox.Show("Customer account not found. Please log in again.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    int customerId = Convert.ToInt32(customerIdObj);

                    // Generate a unique booking code
                    string bookingCode = "BK" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    // Convert food plan to food option (abbreviate)
                    string foodOption = "None";
                    if (foodPlan.Contains("Breakfast")) foodOption = "BB";
                    else if (foodPlan.Contains("Half Board")) foodOption = "HB";
                    else if (foodPlan.Contains("Full Board")) foodOption = "FB";

                    // Insert booking using your exact table structure
                    string insertSql = @"INSERT INTO bookings
                        (booking_code, room_id, customer_id, hotel_id, start_time, end_time, food_option)
                        VALUES (@bookingCode, @roomId, @customerId, @hotelId, @startTime, @endTime, @foodOption)";

                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@bookingCode", bookingCode);
                    insertCmd.Parameters.AddWithValue("@roomId", roomId);
                    insertCmd.Parameters.AddWithValue("@customerId", customerId);
                    insertCmd.Parameters.AddWithValue("@hotelId", hotelId);
                    insertCmd.Parameters.AddWithValue("@startTime", checkInDate);
                    insertCmd.Parameters.AddWithValue("@endTime", checkOutDate);
                    insertCmd.Parameters.AddWithValue("@foodOption", foodOption);

                    insertCmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating booking: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
