using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    internal class CustomerRepository
    {
        private readonly string connectionString =
             "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";

        public bool RegisterCustomer(string name, string username, string email, string password)
        {
            string sql = "INSERT INTO customers (name, username, email, password) VALUES (@n, @u, @e, @p)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                return false;
            }
        }

        public DataTable GetAllCustomers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM customers";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Login(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM customers WHERE username=@u AND password=@p";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // NEW METHOD - Get customer ID by username
        public int GetCustomerId(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT id FROM customers WHERE username = @u";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);

                object result = cmd.ExecuteScalar();
                if (result != null)
                    return Convert.ToInt32(result);
                return -1;
            }
        }

        internal void AddCustomer(FormCustomerHotel customer)
        {
            throw new NotImplementedException();
        }

        public DataTable GetCustomerBookings(string username)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT
                                    b.booking_code AS 'Booking Code',
                                    h.name AS 'Hotel Name',
                                    CONCAT('Floor ', f.id, ' - Room ', r.id) AS 'Room',
                                    b.start_time AS 'Check-In',
                                    b.end_time AS 'Check-Out',
                                    b.food_option AS 'Food Option'
                                FROM bookings b
                                INNER JOIN rooms r ON b.room_id = r.id
                                INNER JOIN floors f ON r.floor_id = f.id
                                INNER JOIN hotels h ON f.hotel_id = h.id
                                INNER JOIN customers c ON b.customer_id = c.id
                                WHERE c.username = @username
                                ORDER BY b.start_time DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@username", username);
                    da.Fill(dt);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1146 || ex.Number == 1054)
                {
                    return dt;
                }
                throw;
            }

            return dt;
        }
    }
}