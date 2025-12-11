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
            LoadAllFoodOrders();

            dataGridViewFoodOrders.GridColor = Color.Gray;
            dataGridViewFoodOrders.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }

        private void LoadAllFoodOrders()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
            SELECT 
                b.booking_code AS 'Booking Code',
                c.name AS 'Customer',
                CONCAT(h.name, ' - Room ', r.id) AS 'Room',
                GROUP_CONCAT(CONCAT(fo.food_item, ' x', fo.quantity) SEPARATOR ', ') AS 'Items',
                (SELECT COUNT(*) * 15 FROM food_orders fo2 WHERE fo2.booking_id = b.id) AS 'Total ($)',
                b.start_time AS 'Order Date'
            FROM bookings b
            JOIN customers c ON b.customer_id = c.id
            JOIN rooms r ON b.room_id = r.id
            JOIN floors f ON r.floor_id = f.id
            JOIN hotels h ON f.hotel_id = h.id
            LEFT JOIN food_orders fo ON fo.booking_id = b.id
            GROUP BY b.id
            ORDER BY b.start_time DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Si no tiene food orders, mostrar "No food ordered"
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Items"] == DBNull.Value || string.IsNullOrEmpty(row["Items"].ToString()))
                    {
                        row["Items"] = "No food ordered";
                        row["Total ($)"] = 0;
                    }
                }

                dataGridViewFoodOrders.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtSearchCode.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                LoadAllFoodOrders();
                return;
            }

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT 
                        b.booking_code,
                        c.name AS customer,
                        CONCAT(h.name, ' - Room ', r.id) AS room,
                        fo.food_item,
                        fo.quantity,
                        (fo.quantity * 10) AS price
                    FROM food_orders fo
                    JOIN bookings b ON fo.booking_id = b.id
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
                    MessageBox.Show("No food orders found for this booking code.");
                    LoadAllFoodOrders();
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
            LoadAllFoodOrders();
        }

        private void dataGridViewFoodOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string code = dataGridViewFoodOrders.Rows[e.RowIndex].Cells["Booking Code"].Value.ToString();
            MessageBox.Show($"Food Order Details for {code}\n\n" +
                           $"Customer: {dataGridViewFoodOrders.Rows[e.RowIndex].Cells["Customer"].Value}\n" +
                           $"Room: {dataGridViewFoodOrders.Rows[e.RowIndex].Cells["Room"].Value}\n" +
                           $"Items: {dataGridViewFoodOrders.Rows[e.RowIndex].Cells["Items"].Value}\n" +
                           $"Total: {dataGridViewFoodOrders.Rows[e.RowIndex].Cells["Total"].Value}\n" +
                           $"Date: {dataGridViewFoodOrders.Rows[e.RowIndex].Cells["Date"].Value}",
                           "FOOD ORDER - " + code, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}
