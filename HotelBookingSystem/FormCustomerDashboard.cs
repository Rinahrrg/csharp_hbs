using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Repository;
using MySql.Data.MySqlClient;

namespace HotelBookingSystem
{
    public partial class FormCustomerDashboard : Form
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private HotelRepository hotelRepository;
        private CustomerRepository customerRepository;
        private DataTable allHotels;
        private string currentUsername;

        public FormCustomerDashboard(string username = "Guest")
        {
            InitializeComponent();
            hotelRepository = new HotelRepository();
            customerRepository = new CustomerRepository();
            currentUsername = username;
        }

        private void FormCustomerDashboard_Load(object sender, EventArgs e)
        {
            dateCheckIn.MinDate = DateTime.Today;
            dateCheckOut.MinDate = DateTime.Today.AddDays(1);
            dateCheckIn.Value = DateTime.Today;
            dateCheckOut.Value = DateTime.Today.AddDays(1);

            LoadHotels();
            LoadMyBookings();
        }

        private void LoadHotels(string destination = "")
        {
            try
            {
                flowLayoutPanelHotels.Controls.Clear();

                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    string sql = "SELECT id, name, address, default_booking_time, image FROM hotels";

                    if (!string.IsNullOrWhiteSpace(destination))
                    {
                        sql += " WHERE address LIKE @dest";
                        lblHotelsTitle.Text = $"Hotels in '{destination}'";
                    }
                    else
                    {
                        lblHotelsTitle.Text = "Recommended Hotels";
                    }

                    sql += " ORDER BY name";

                    MySqlCommand cmd = new MySqlCommand(sql, c);
                    if (!string.IsNullOrWhiteSpace(destination))
                    {
                        cmd.Parameters.AddWithValue("@dest", "%" + destination + "%");
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    allHotels = new DataTable();
                    da.Fill(allHotels);

                    if (allHotels.Rows.Count == 0)
                    {
                        Label noResultsLabel = new Label();
                        noResultsLabel.Text = "No hotels found in this destination. Try searching for another location!";
                        noResultsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic);
                        noResultsLabel.ForeColor = Color.Gray;
                        noResultsLabel.AutoSize = true;
                        noResultsLabel.Padding = new Padding(20);
                        flowLayoutPanelHotels.Controls.Add(noResultsLabel);
                        return;
                    }

                    foreach (DataRow row in allHotels.Rows)
                    {
                        Panel card = CreateHotelCard(row);
                        flowLayoutPanelHotels.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading hotels: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateHotelCard(DataRow hotelData)
        {
            Panel card = new Panel();
            card.Width = 300;
            card.Height = 280;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Padding = new Padding(10);

            // Hotel Image
            PictureBox picHotel = new PictureBox();
            picHotel.Size = new Size(280, 120);
            picHotel.Location = new Point(10, 10);
            picHotel.SizeMode = PictureBoxSizeMode.StretchImage;
            picHotel.BackColor = Color.LightGray;

            if (hotelData["image"] != DBNull.Value)
            {
                try
                {
                    byte[] imgBytes = (byte[])hotelData["image"];
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        picHotel.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    picHotel.BackColor = Color.LightGray;
                }
            }
            card.Controls.Add(picHotel);

            // Hotel name label
            Label lblName = new Label();
            lblName.Text = hotelData["name"].ToString();
            lblName.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.MaximumSize = new Size(280, 0);
            lblName.Location = new Point(10, 135);
            card.Controls.Add(lblName);

            // Location label
            Label lblLocation = new Label();
            lblLocation.Text = "📍 " + hotelData["address"].ToString();
            lblLocation.Font = new Font("Arial", 9F);
            lblLocation.AutoSize = true;
            lblLocation.MaximumSize = new Size(280, 0);
            lblLocation.Location = new Point(10, 160);
            card.Controls.Add(lblLocation);

            // Divider line
            Panel divider = new Panel();
            divider.Height = 1;
            divider.Width = 280;
            divider.BackColor = Color.LightGray;
            divider.Location = new Point(10, 190);
            card.Controls.Add(divider);

            // Hotel ID (hidden)
            Label lblId = new Label();
            lblId.Text = hotelData["id"].ToString();
            lblId.Visible = false;
            lblId.Name = "hotelId";
            card.Controls.Add(lblId);

            // Default booking time info
            Label lblTime = new Label();
            lblTime.Text = $"Default booking: {hotelData["default_booking_time"]} hours";
            lblTime.Font = new Font("Arial", 8F, FontStyle.Italic);
            lblTime.ForeColor = Color.Gray;
            lblTime.AutoSize = true;
            lblTime.Location = new Point(10, 200);
            card.Controls.Add(lblTime);

            // Book button
            Button btnBook = new Button();
            btnBook.Text = "Book Now";
            btnBook.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Bold);
            btnBook.Size = new Size(280, 38);
            btnBook.Location = new Point(10, 225);
            btnBook.BackColor = Color.FromArgb(0, 122, 204);
            btnBook.ForeColor = Color.White;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Cursor = Cursors.Hand;
            btnBook.Click += (sender, e) =>
            {
                BookHotel(hotelData);
            };
            card.Controls.Add(btnBook);

            // Add hover effect
            card.MouseEnter += (sender, e) =>
            {
                card.BackColor = Color.FromArgb(240, 248, 255);
            };
            card.MouseLeave += (sender, e) =>
            {
                card.BackColor = Color.White;
            };

            return card;
        }

        private void BookHotel(DataRow hotelData)
        {
            string hotelName = hotelData["name"].ToString();
            string checkIn = dateCheckIn.Value.ToString("yyyy-MM-dd");
            string checkOut = dateCheckOut.Value.ToString("yyyy-MM-dd");

            if (dateCheckOut.Value <= dateCheckIn.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nights = (dateCheckOut.Value - dateCheckIn.Value).Days;

            string message = $"Hotel: {hotelName}\n" +
                           $"Check-in: {dateCheckIn.Value.ToShortDateString()}\n" +
                           $"Check-out: {dateCheckOut.Value.ToShortDateString()}\n" +
                           $"Number of nights: {nights}\n\n" +
                           $"Booking functionality will be fully implemented soon!\n" +
                           $"This will create a reservation in the database.";

            MessageBox.Show(message, "Booking Preview", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadMyBookings()
        {
            try
            {
                DataTable bookings = customerRepository.GetCustomerBookings(currentUsername);

                if (bookings.Rows.Count == 0)
                {
                    bookings.Columns.Add("Message");
                    bookings.Rows.Add("You don't have any bookings yet. Search for hotels above to make your first booking!");
                }

                dataGridViewBookings.DataSource = bookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string destination = txtDestination.Text.Trim();

            if (dateCheckOut.Value <= dateCheckIn.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dateCheckOut.MinDate = dateCheckIn.Value.AddDays(1);

            LoadHotels(destination);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}