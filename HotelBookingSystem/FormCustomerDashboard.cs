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
            // Set minimum dates for date pickers
            dateCheckIn.MinDate = DateTime.Today;
            dateCheckOut.MinDate = DateTime.Today.AddDays(1);
            dateCheckIn.Value = DateTime.Today;
            dateCheckOut.Value = DateTime.Today.AddDays(1);

            // Load recommended hotels on startup
            LoadHotels();

            // Load customer bookings
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
            card.Width = 320;
            card.Height = 280;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Padding = new Padding(0);

            // Hotel image
            PictureBox picHotel = new PictureBox();
            picHotel.Width = 318;
            picHotel.Height = 140;
            picHotel.Location = new Point(1, 1);
            picHotel.SizeMode = PictureBoxSizeMode.StretchImage;
            picHotel.BackColor = Color.FromArgb(200, 220, 240);

            // Create a default hotel image (gradient background with hotel icon)
            Bitmap defaultImage = new Bitmap(318, 140);
            using (Graphics g = Graphics.FromImage(defaultImage))
            {
                // Gradient background
                using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                    new System.Drawing.Drawing2D.LinearGradientBrush(
                        new Rectangle(0, 0, 318, 140),
                        Color.FromArgb(70, 130, 180),
                        Color.FromArgb(135, 206, 250),
                        45f))
                {
                    g.FillRectangle(brush, 0, 0, 318, 140);
                }

                // Draw hotel icon text
                using (Font font = new Font("Segoe UI", 48, FontStyle.Bold))
                {
                    string hotelIcon = "🏨";
                    SizeF textSize = g.MeasureString(hotelIcon, font);
                    g.DrawString(hotelIcon, font, Brushes.White,
                        (318 - textSize.Width) / 2, (140 - textSize.Height) / 2);
                }
            }
            picHotel.Image = defaultImage;
            card.Controls.Add(picHotel);

            // Hotel name label
            Label lblName = new Label();
            lblName.Text = hotelData["name"].ToString();
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.DarkBlue;
            lblName.AutoSize = true;
            lblName.MaximumSize = new Size(300, 0);
            lblName.Location = new Point(10, 150);
            card.Controls.Add(lblName);

            // Location label
            Label lblLocationIcon = new Label();
            lblLocationIcon.Text = "📍";
            lblLocationIcon.Font = new Font("Microsoft Sans Serif", 9F);
            lblLocationIcon.AutoSize = true;
            lblLocationIcon.Location = new Point(10, 180);
            card.Controls.Add(lblLocationIcon);

            Label lblLocation = new Label();
            lblLocation.Text = hotelData["address"].ToString();
            lblLocation.Font = new Font("Microsoft Sans Serif", 8.5F);
            lblLocation.AutoSize = true;
            lblLocation.MaximumSize = new Size(280, 40);
            lblLocation.Location = new Point(28, 182);
            card.Controls.Add(lblLocation);

            // Hotel ID (hidden, for booking functionality)
            Label lblId = new Label();
            lblId.Text = hotelData["id"].ToString();
            lblId.Visible = false;
            lblId.Name = "hotelId";
            card.Controls.Add(lblId);

            // Book button
            Button btnBook = new Button();
            btnBook.Text = "Book Now";
            btnBook.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnBook.Size = new Size(298, 40);
            btnBook.Location = new Point(10, 230);
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
            int hotelId = Convert.ToInt32(hotelData["id"]);
            string hotelName = hotelData["name"].ToString();

            // Validate dates
            if (dateCheckOut.Value <= dateCheckIn.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open room selection form
            FormRoomSelection roomSelectionForm = new FormRoomSelection(
                hotelId,
                hotelName,
                currentUsername,
                dateCheckIn.Value,
                dateCheckOut.Value
            );

            DialogResult result = roomSelectionForm.ShowDialog();

            // If booking was successful, refresh the bookings list
            if (result == DialogResult.OK)
            {
                LoadMyBookings();
            }
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