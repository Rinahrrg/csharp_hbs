using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Configuration;

namespace HotelBookingSystem.Repository
{
    public class HotelRepository
    {
        private readonly string connectionString =
            "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";


        private string _connectionString;

        public HotelRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["HotelDb"].ConnectionString;
        }

        // Validar login
        public bool AdminLogin(string username, string password)
        {
            bool success = false;

            try
            {
                using (MySqlConnection con = new MySqlConnection(_connectionString))
                {
                    string query = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    success = count > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en la conexión: " + ex.Message);
            }

            return success;
        }

        // Obtener todos los hoteles
        public DataTable GetHotels()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection con = new MySqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM hotels";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al cargar hoteles: " + ex.Message);
            }

            return dt;
        }

        // Añadir hotel
        public void AddHotel(string name, string location, int rooms)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(_connectionString))
                {
                    string query = "INSERT INTO hotels (name, location, rooms) VALUES (@name, @location, @rooms)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@rooms", rooms);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al añadir hotel: " + ex.Message);
            }
        }

        // Editar hotel
        public void UpdateHotel(int id, string name, string location, int rooms)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(_connectionString))
                {
                    string query = "UPDATE hotels SET name=@name, location=@location, rooms=@rooms WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@rooms", rooms);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar hotel: " + ex.Message);
            }
        }

        // Eliminar hotel
        public void DeleteHotel(int id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(_connectionString))
                {
                    string query = "DELETE FROM hotels WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar hotel: " + ex.Message);
            }
        }
    }
}

