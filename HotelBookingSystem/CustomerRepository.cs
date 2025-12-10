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
                return false; // usuario o email duplicado
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

                    // Query to get bookings for a specific customer
                    // Note: This assumes a bookings table exists with customer_id foreign key
                    // If the bookings table doesn't exist yet, this will return an empty DataTable
                    string sql = @"SELECT
                                    b.id AS 'Booking ID',
                                    h.name AS 'Hotel Name',
                                    h.address AS 'Address',
                                    b.check_in AS 'Check-In Date',
                                    b.check_out AS 'Check-Out Date',
                                    b.status AS 'Status'
                                FROM bookings b
                                INNER JOIN hotels h ON b.hotel_id = h.id
                                INNER JOIN customers c ON b.customer_id = c.id
                                WHERE c.username = @username
                                ORDER BY b.check_in DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@username", username);
                    da.Fill(dt);
                }
            }
            catch (MySqlException ex)
            {
                // If the bookings table doesn't exist or has different schema, return empty DataTable
                // This allows the application to work even without the proper bookings table structure
                if (ex.Number == 1146 || // Table doesn't exist
                    ex.Number == 1054)   // Unknown column
                {
                    return dt; // Return empty DataTable
                }
                throw; // Re-throw other exceptions
            }

            return dt;
        }
    }
}