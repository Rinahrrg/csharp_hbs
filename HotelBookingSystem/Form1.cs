using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace HotelBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["HotelDb"].ConnectionString;

                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "SELECT * FROM admin";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
            }
        }

    }
}
