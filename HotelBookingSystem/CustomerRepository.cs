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
    }
}
