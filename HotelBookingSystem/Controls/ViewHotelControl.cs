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
        private HotelRepository _repo;
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";

        public ViewHotelControl()
        {
            InitializeComponent();
            _repo = new HotelRepository();
            LoadHotels();
        }

        private void LoadHotels()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                DataTable dt = _repo.GetHotels();

                if (dt.Rows.Count == 0)
                {
                    Label noHotels = new Label();
                    noHotels.Text = "No hotels available.";
                    noHotels.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
                    noHotels.ForeColor = Color.Gray;
                    noHotels.AutoSize = true;
                    noHotels.Padding = new Padding(20);
                    flowLayoutPanel1.Controls.Add(noHotels);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    Panel card = CreateHotelCard(row);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading hotels: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateHotelCard(DataRow hotelData)
        {
            Panel card = new Panel();
            card.Width = 350;
            card.Height = 120;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Padding = new Padding(10);

            // Hotel name
            Label lblName = new Label();
            lblName.Text = hotelData["name"].ToString();
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = false;
            lblName.Size = new Size(320, 25);
            lblName.Location = new Point(10, 10);
            lblName.AutoEllipsis = true;
            card.Controls.Add(lblName);

            // Address - FIXED: Use AutoEllipsis and fixed size to handle long addresses
            Label lblAddress = new Label();
            string address = hotelData["address"].ToString();
            lblAddress.Text = "📍 " + address;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.ForeColor = Color.DimGray;
            lblAddress.AutoSize = false;
            lblAddress.Size = new Size(320, 40);
            lblAddress.Location = new Point(10, 40);
            lblAddress.AutoEllipsis = true;
            card.Controls.Add(lblAddress);

            // Get additional info
            int floorCount = 0;
            int roomCount = 0;

            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    int hotelId = Convert.ToInt32(hotelData["id"]);

                    // Count floors
                    MySqlCommand cmdFloors = new MySqlCommand("SELECT COUNT(*) FROM floors WHERE hotel_id = @hid", c);
                    cmdFloors.Parameters.AddWithValue("@hid", hotelId);
                    floorCount = Convert.ToInt32(cmdFloors.ExecuteScalar());

                    // Count rooms
                    MySqlCommand cmdRooms = new MySqlCommand(
                        "SELECT COUNT(*) FROM rooms r JOIN floors f ON r.floor_id = f.id WHERE f.hotel_id = @hid", c);
                    cmdRooms.Parameters.AddWithValue("@hid", hotelId);
                    roomCount = Convert.ToInt32(cmdRooms.ExecuteScalar());
                }
            }
            catch { }

            // Stats label
            Label lblStats = new Label();
            lblStats.Text = $"🏢 {floorCount} Floors  |  🚪 {roomCount} Rooms";
            lblStats.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStats.ForeColor = Color.FromArgb(0, 122, 204);
            lblStats.AutoSize = true;
            lblStats.Location = new Point(10, 85);
            card.Controls.Add(lblStats);

            // Hover effect
            card.MouseEnter += (sender, e) => { card.BackColor = Color.FromArgb(245, 245, 245); };
            card.MouseLeave += (sender, e) => { card.BackColor = Color.White; };

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

        // ADD THESE TWO MISSING EVENT HANDLERS
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Empty - required by designer
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Empty - required by designer
        }
    }
}