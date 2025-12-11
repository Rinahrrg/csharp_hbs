using HotelBookingSystem.Repository;
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
    public partial class ViewHotelControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";

        public ViewHotelControl()
        {
            InitializeComponent();
            LoadHotels();
        }

        private void LoadHotels()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    string sql = @"SELECT h.id, h.name, h.address, h.default_booking_time, h.image,
                                   (SELECT COUNT(*) FROM floors f WHERE f.hotel_id = h.id) AS floors,
                                   (SELECT COUNT(*) FROM rooms r JOIN floors f ON r.floor_id = f.id WHERE f.hotel_id = h.id) AS rooms
                                   FROM hotels h ORDER BY h.name";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        Panel card = CreateHotelCard(row);
                        flowLayoutPanel1.Controls.Add(card);
                    }

                    if (dt.Rows.Count == 0)
                    {
                        Label noHotels = new Label();
                        noHotels.Text = "No hotels found. Add hotels from the 'Add Hotel' section.";
                        noHotels.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
                        noHotels.ForeColor = Color.Gray;
                        noHotels.AutoSize = true;
                        noHotels.Padding = new Padding(20);
                        flowLayoutPanel1.Controls.Add(noHotels);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading hotels: " + ex.Message);
            }
        }

        private Panel CreateHotelCard(DataRow hotelData)
        {
            Panel card = new Panel();
            card.Width = 350;
            card.Height = 280;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);

            // Hotel Image
            PictureBox picHotel = new PictureBox();
            picHotel.Size = new Size(330, 140);
            picHotel.Location = new Point(10, 10);
            picHotel.SizeMode = PictureBoxSizeMode.StretchImage;
            picHotel.BackColor = Color.LightGray;

            if (hotelData["image"] != DBNull.Value)
            {
                byte[] imgBytes = (byte[])hotelData["image"];
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    picHotel.Image = Image.FromStream(ms);
                }
            }
            card.Controls.Add(picHotel);

            // Hotel Name
            Label lblName = new Label();
            lblName.Text = hotelData["name"].ToString();
            lblName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Bold);
            lblName.AutoSize = true;
            lblName.MaximumSize = new Size(330, 0);
            lblName.Location = new Point(10, 155);
            card.Controls.Add(lblName);

            // Address
            Label lblAddress = new Label();
            lblAddress.Text = "📍 " + hotelData["address"].ToString();
            lblAddress.Font = new Font("Arial", 9F);
            lblAddress.AutoSize = true;
            lblAddress.MaximumSize = new Size(330, 0);
            lblAddress.Location = new Point(10, 180);
            card.Controls.Add(lblAddress);

            // Stats
            Label lblStats = new Label();
            lblStats.Text = $"Floors: {hotelData["floors"]} | Rooms: {hotelData["rooms"]} | Default Time: {hotelData["default_booking_time"]}hrs";
            lblStats.Font = new Font("Arial", 9F);
            lblStats.AutoSize = true;
            lblStats.Location = new Point(10, 205);
            card.Controls.Add(lblStats);

            // Divider
            Panel divider = new Panel();
            divider.Height = 1;
            divider.Width = 330;
            divider.BackColor = Color.LightGray;
            divider.Location = new Point(10, 230);
            card.Controls.Add(divider);

            // Hotel ID Label (hidden)
            Label lblId = new Label();
            lblId.Text = hotelData["id"].ToString();
            lblId.Visible = false;
            lblId.Name = "hotelId";
            card.Controls.Add(lblId);

            // View Details Button
            Button btnDetails = new Button();
            btnDetails.Text = "View Details";
            btnDetails.Font = new Font("Arial Rounded MT Bold", 9F);
            btnDetails.Size = new Size(330, 35);
            btnDetails.Location = new Point(10, 238);
            btnDetails.BackColor = Color.Black;
            btnDetails.ForeColor = Color.White;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Cursor = Cursors.Hand;
            btnDetails.Click += (sender, e) =>
            {
                MessageBox.Show($"Hotel: {hotelData["name"]}\n" +
                               $"Address: {hotelData["address"]}\n" +
                               $"Floors: {hotelData["floors"]}\n" +
                               $"Rooms: {hotelData["rooms"]}\n" +
                               $"Default Booking Time: {hotelData["default_booking_time"]} hours",
                               "Hotel Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            card.Controls.Add(btnDetails);

            return card;
        }

        private void dataGridViewHotels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewFoodOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHotels();
        }
    }
}