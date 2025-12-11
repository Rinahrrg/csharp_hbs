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
    public partial class FoodOrdersControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";

        public FoodOrdersControl()
        {
            InitializeComponent();
            LoadFoodOrders();
            dataGridViewFoodOrders.GridColor = Color.Gray;
            dataGridViewFoodOrders.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }

        private void LoadFoodOrders()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
            SELECT 
                b.booking_code AS 'Booking Code',
                c.name AS 'Customer',
                h.name AS 'Hotel',
                CONCAT('Room ', r.id) AS 'Room',
                COALESCE(b.food_option, 'None') AS 'Food Plan',
                CASE 
                    WHEN b.food_option LIKE '%Full Board%' THEN 120
                    WHEN b.food_option LIKE '%Half Board%' THEN 80
                    WHEN b.food_option LIKE '%Breakfast%' AND b.food_option LIKE '%Lunch%' AND b.food_option LIKE '%Dinner%' THEN 120
                    WHEN b.food_option LIKE '%Breakfast%' AND b.food_option LIKE '%Dinner%' THEN 80
                    WHEN b.food_option LIKE '%Breakfast%' AND b.food_option LIKE '%Lunch%' THEN 70
                    WHEN b.food_option LIKE '%Breakfast%' THEN 40
                    WHEN b.food_option LIKE '%Lunch%' THEN 40
                    WHEN b.food_option LIKE '%Dinner%' THEN 50
                    ELSE 0
                END AS 'Food Price ($)'
            FROM bookings b
            JOIN customers c ON b.customer_id = c.id
            JOIN rooms r ON b.room_id = r.id
            JOIN floors f ON r.floor_id = f.id
            JOIN hotels h ON f.hotel_id = h.id
            ORDER BY b.start_time DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewFoodOrders.DataSource = dt;
            }
        }

        // EL ÚNICO BOTÓN SEARCH QUE DEBE EXISTIR
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtSearchCode.Text.Trim();

            if (string.IsNullOrEmpty(code))
            {
                LoadFoodOrders();
                return;
            }

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT 
                        b.booking_code AS 'Booking Code',
                        c.name AS 'Customer',
                        h.name AS 'Hotel',
                        CONCAT('Room ', r.id) AS 'Room',
                        COALESCE(b.food_option, 'None') AS 'Food Plan',
                        CASE 
                            WHEN b.food_option LIKE '%Full Board%' THEN '$120'
                            WHEN b.food_option LIKE '%Half Board%' OR (b.food_option LIKE '%Breakfast%' AND b.food_option LIKE '%Dinner%') THEN '$80'
                            WHEN b.food_option LIKE '%Breakfast%' THEN '$40'
                            ELSE '$0'
                        END AS 'Food Price ($)'
                    FROM bookings b
                    JOIN customers c ON b.customer_id = c.id
                    JOIN rooms r ON b.room_id = r.id
                    JOIN floors f ON r.floor_id = f.id
                    JOIN hotels h ON f.hotel_id = h.id
                    WHERE b.booking_code = @code";

                MySqlCommand cmd = new MySqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@code", code);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No booking found with this code.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFoodOrders();
                }
                else
                {
                    dataGridViewFoodOrders.DataSource = dt;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchCode.Clear();
            LoadFoodOrders();
        }
        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
