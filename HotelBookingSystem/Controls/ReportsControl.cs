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
    public partial class ReportsControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";

        public ReportsControl()
        {
            InitializeComponent();
        }

        private void btnMostBookedRoom_Click(object sender, EventArgs e)
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT TOP 1
                        CONCAT(h.name, ' - Room ', r.id) AS 'Most Booked Room',
                        COUNT(*) AS 'Total Bookings',
                        COUNT(*) * h.default_booking_time * 10 AS 'Revenue ($)'
                    FROM bookings b
                    JOIN rooms r ON b.room_id = r.id
                    JOIN floors f ON r.floor_id = f.id
                    JOIN hotels h ON f.hotel_id = h.id
                    GROUP BY r.id, h.name, h.default_booking_time
                    ORDER BY COUNT(*) DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewReports.DataSource = dt;
            }
        }

        private void btnHotelRevenue_Click(object sender, EventArgs e)
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT 
                        h.name AS 'Hotel',
                        COUNT(b.id) AS 'Total Bookings',
                        SUM(h.default_booking_time * 10) AS 'Total Revenue ($)'
                    FROM bookings b
                    JOIN rooms r ON b.room_id = r.id
                    JOIN floors f ON r.floor_id = f.id
                    JOIN hotels h ON f.hotel_id = h.id
                    GROUP BY h.name
                    ORDER BY SUM(h.default_booking_time * 10) DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewReports.DataSource = dt;
            }
        }

        private void btnAssetsStatus_Click(object sender, EventArgs e)
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT 
                        at.type AS 'Asset Type',
                        at.status AS 'Status',
                        COUNT(a.id) AS 'Quantity'
                    FROM assets a
                    JOIN asset_types at ON a.asset_type = at.id
                    GROUP BY at.type, at.status
                    ORDER BY at.type";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewReports.DataSource = dt;
            }
        }

        private void btnRoomsStatus_Click(object sender, EventArgs e)
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT 'Working' AS 'Status', COUNT(*) AS 'Count' FROM rooms WHERE status = 'working'
                    UNION ALL
                    SELECT 'Under Maintenance', COUNT(*) FROM rooms WHERE status = 'under_maintenance'
                    UNION ALL
                    SELECT 'Damaged', COUNT(*) FROM rooms WHERE status = 'damaged'";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewReports.DataSource = dt;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewReports.DataSource = null;
        }
    }
}
