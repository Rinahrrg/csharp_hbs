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
    public partial class BookingsControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";

        public BookingsControl()
        {
            InitializeComponent();
            LoadAllBookings();
        }

        private void LoadAllBookings()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT 
                        b.booking_code AS 'Booking Code',
                        h.name AS 'Hotel',
                        CONCAT('Floor ', f.id, ' - Room ', r.id) AS 'Room',
                        c.name AS 'Customer',
                        b.start_time AS 'Check In',
                        b.end_time AS 'Check Out',
                        COALESCE(b.food_option, 'None') AS 'Food Option',
                        CASE 
                            WHEN NOW() BETWEEN b.start_time AND b.end_time THEN 'Active'
                            WHEN NOW() > b.end_time THEN 'Completed'
                            ELSE 'Upcoming'
                        END AS 'Status'
                    FROM bookings b
                    JOIN rooms r ON b.room_id = r.id
                    JOIN floors f ON r.floor_id = f.id
                    JOIN hotels h ON f.hotel_id = h.id
                    JOIN customers c ON b.customer_id = c.id
                    ORDER BY b.start_time DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookings.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtBookingCode.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                LoadAllBookings();
                return;
            }

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = "SELECT * FROM bookings WHERE booking_code = @code";
                MySqlCommand cmd = new MySqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@code", code);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                    MessageBox.Show("Booking code not found!");
                else
                    dataGridViewBookings.DataSource = dt;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookingCode.Clear();
            LoadAllBookings();
        }

        // Doble clic en fila → muestra detalles
        private void dataGridViewBookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string code = dataGridViewBookings.Rows[e.RowIndex].Cells["Booking Code"].Value.ToString();
            MessageBox.Show($"Booking Details:\nCode: {code}\nHotel: {dataGridViewBookings.Rows[e.RowIndex].Cells["Hotel"].Value}\nRoom: {dataGridViewBookings.Rows[e.RowIndex].Cells["Room"].Value}\nCustomer: {dataGridViewBookings.Rows[e.RowIndex].Cells["Customer"].Value}\nCheck In: {dataGridViewBookings.Rows[e.RowIndex].Cells["Check In"].Value}\nCheck Out: {dataGridViewBookings.Rows[e.RowIndex].Cells["Check Out"].Value}\nFood: {dataGridViewBookings.Rows[e.RowIndex].Cells["Food Option"].Value}\nStatus: {dataGridViewBookings.Rows[e.RowIndex].Cells["Status"].Value}",
                "BOOKING DETAILS - " + code, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
