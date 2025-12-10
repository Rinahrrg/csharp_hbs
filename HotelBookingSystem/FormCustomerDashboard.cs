using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Repository;

namespace HotelBookingSystem
{
    public partial class FormCustomerDashboard : Form
    {
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
                // Get all hotels from database
                allHotels = hotelRepository.GetHotels();

                // Clear existing cards
                flowLayoutPanelHotels.Controls.Clear();

                // Filter hotels if destination is provided
                DataRow[] filteredHotels;
                if (string.IsNullOrWhiteSpace(destination))
                {
                    // Show all hotels as "Recommended"
                    filteredHotels = allHotels.Select();
                    lblHotelsTitle.Text = "Recommended Hotels";
                }
                else
                {
                    // Filter by destination/location
                    filteredHotels = allHotels.Select(
                        $"address LIKE '%{destination}%'"
                    );
                    lblHotelsTitle.Text = $"Hotels in '{destination}'";
                }

                // Display message if no hotels found
                if (filteredHotels.Length == 0)
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

                // Create a card for each hotel
                foreach (DataRow row in filteredHotels)
                {
                    Panel card = CreateHotelCard(row);
                    flowLayoutPanelHotels.Controls.Add(card);
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
            // Create card panel
            Panel card = new Panel();
            card.Width = 300;
            card.Height = 170;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Padding = new Padding(15);

            // Hotel name label
            Label lblName = new Label();
            lblName.Text = hotelData["name"].ToString();
            lblName.Font = new Font("AerArial Rounded MT", 13F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.MaximumSize = new Size(270, 0);
            lblName.Location = new Point(10, 10);
            card.Controls.Add(lblName);

            // Location label
            Label lblLocationIcon = new Label();
            lblLocationIcon.Text = "📍";
            lblLocationIcon.Font = new Font("AerArial Rounded MT", 10F);
            lblLocationIcon.AutoSize = true;
            lblLocationIcon.Location = new Point(10, 50);
            card.Controls.Add(lblLocationIcon);

            Label lblLocation = new Label();
            lblLocation.Text = hotelData["address"].ToString();
            lblLocation.Font = new Font("AerArial Rounded MT", 9F);
            lblLocation.AutoSize = true;
            lblLocation.MaximumSize = new Size(240, 0);
            lblLocation.Location = new Point(30, 52);
            card.Controls.Add(lblLocation);

            // Divider line
            Panel divider = new Panel();
            divider.Height = 1;
            divider.Width = 270;
            divider.BackColor = Color.LightGray;
            divider.Location = new Point(10, 90);
            card.Controls.Add(divider);

            // Hotel ID (hidden, for future booking functionality)
            Label lblId = new Label();
            lblId.Text = hotelData["id"].ToString();
            lblId.Visible = false;
            lblId.Name = "hotelId";
            card.Controls.Add(lblId);

            // Book button
            Button btnBook = new Button();
            btnBook.Text = "Book Now";
            btnBook.Font = new Font("AerArial Rounded MT", 10F, FontStyle.Bold);
            btnBook.Size = new Size(270, 38);
            btnBook.Location = new Point(10, 110);
            btnBook.BackColor = Color.FromArgb(0, 122, 204);
            btnBook.ForeColor = Color.White;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Cursor = Cursors.Hand;
            btnBook.Click += (sender, e) => {
                BookHotel(hotelData);
            };
            card.Controls.Add(btnBook);

            // Add hover effect
            card.MouseEnter += (sender, e) => {
                card.BackColor = Color.FromArgb(240, 248, 255);
            };
            card.MouseLeave += (sender, e) => {
                card.BackColor = Color.White;
            };

            return card;
        }

        private void BookHotel(DataRow hotelData)
        {
            string hotelName = hotelData["name"].ToString();
            string checkIn = dateCheckIn.Value.ToString("yyyy-MM-dd");
            string checkOut = dateCheckOut.Value.ToString("yyyy-MM-dd");

            // Validate dates
            if (dateCheckOut.Value <= dateCheckIn.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate number of nights
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
                    // Show a message in the grid
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

            // Validate dates
            if (dateCheckOut.Value <= dateCheckIn.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update minimum date for check-out based on check-in
            dateCheckOut.MinDate = dateCheckIn.Value.AddDays(1);

            LoadHotels(destination);
        }
    }
}