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
    public partial class FormCustomerDashboard : Form
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int customerId = 1; // Cambiar por el cliente logueado

        public FormCustomerDashboard()
        {
            InitializeComponent();
            LoadHotels();
            LoadMyBookings();
        }

        private void LoadHotels()
        {
            flowLayoutPanelHotels.Controls.Clear();

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = "SELECT id, name, address, photo, default_booking_time FROM hotels ORDER BY name";
                MySqlCommand cmd = new MySqlCommand(sql, c);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    CreateHotelCard(
                        r.GetInt32("id"),
                        r.GetString("name"),
                        r.GetString("address"),
                        r["photo"] as byte[],
                        r.GetInt32("default_booking_time")
                    );
                }
            }
        }

        private void CreateHotelCard(int hotelId, string name, string address, byte[] photo, int bookingTime)
        {
            Panel card = new Panel { Width = 320, Height = 400, Margin = new Padding(20) };

            PictureBox pic = new PictureBox
            {
                Width = 300,
                Height = 180,
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            if (photo != null)
            {
                using (MemoryStream ms = new MemoryStream(photo))
                    pic.Image = Image.FromStream(ms);
            }

            Label lblName = new Label
            {
                Text = name,
                Location = new Point(10, 200),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = true
            };

            Label lblAddress = new Label
            {
                Text = address,
                Location = new Point(10, 230),
                AutoSize = true
            };

            Label lblPrice = new Label
            {
                Text = $"Desde ${(bookingTime * 10)}/noche",
                Location = new Point(10, 260),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.Green,
                AutoSize = true
            };

            Button btnBook = new Button
            {
                Text = "Ver Habitaciones",
                Location = new Point(10, 310),
                Size = new Size(300, 50),
                BackColor = Color.FromArgb(0, 123, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnBook.Tag = hotelId;
            btnBook.Click += (s, e) =>
            {
                FormRoomSelection frm = new FormRoomSelection(hotelId, customerId);
                frm.ShowDialog();
                LoadMyBookings();
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblName);
            card.Controls.Add(lblAddress);
            card.Controls.Add(lblPrice);
            card.Controls.Add(btnBook);

            flowLayoutPanelHotels.Controls.Add(card);
        }

        private void LoadMyBookings()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT b.booking_code, h.name AS hotel, r.id AS room, b.start_time, b.end_time, b.food_option
                    FROM bookings b
                    JOIN rooms r ON b.room_id = r.id
                    JOIN floors f ON r.floor_id = f.id
                    JOIN hotels h ON f.hotel_id = h.id
                    WHERE b.customer_id = @cid";

                MySqlCommand cmd = new MySqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@cid", customerId);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMyBookings.DataSource = dt;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblHotelName_Click(object sender, EventArgs e)
        {

        }
    }
}
