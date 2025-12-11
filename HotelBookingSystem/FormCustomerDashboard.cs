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

namespace HotelBookingSystem
{
    public partial class FormCustomerDashboard : Form
    {
        private HotelRepository hotelRepository;
        private CustomerRepository customerRepository;
        private DataTable allHotels;
        private string currentUsername;
        private int currentCustomerId;

        // Default placeholder image (simple gray box)
        private Image defaultHotelImage;

        public FormCustomerDashboard(string username = "Guest")
        {
            InitializeComponent();
            hotelRepository = new HotelRepository();
            customerRepository = new CustomerRepository();
            currentUsername = username;
            currentCustomerId = customerRepository.GetCustomerId(username);

            // Create a default placeholder image
            defaultHotelImage = CreatePlaceholderImage();
        }

        private Image CreatePlaceholderImage()
        {
            // Create a simple placeholder image with hotel icon
            Bitmap bmp = new Bitmap(280, 120);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(230, 230, 230));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Draw hotel icon (simple building)
                using (Brush brush = new SolidBrush(Color.FromArgb(180, 180, 180)))
                {
                    // Building
                    g.FillRectangle(brush, 115, 30, 50, 60);
                    // Windows
                    using (Brush windowBrush = new SolidBrush(Color.FromArgb(200, 200, 200)))
                    {
                        g.FillRectangle(windowBrush, 122, 38, 12, 10);
                        g.FillRectangle(windowBrush, 146, 38, 12, 10);
                        g.FillRectangle(windowBrush, 122, 55, 12, 10);
                        g.FillRectangle(windowBrush, 146, 55, 12, 10);
                    }
                    // Door
                    g.FillRectangle(Brushes.Gray, 132, 72, 16, 18);
                }

                // Draw text
                using (Font font = new Font("Segoe UI", 9F, FontStyle.Italic))
                {
                    string text = "No Image Available";
                    SizeF textSize = g.MeasureString(text, font);
                    g.DrawString(text, font, Brushes.Gray,
                        (bmp.Width - textSize.Width) / 2, 95);
                }
            }
            return bmp;
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
                allHotels = hotelRepository.GetHotels();
                flowLayoutPanelHotels.Controls.Clear();

                DataRow[] filteredHotels;
                if (string.IsNullOrWhiteSpace(destination))
                {
                    filteredHotels = allHotels.Select();
                    lblHotelsTitle.Text = "Recommended Hotels";
                }
                else
                {
                    filteredHotels = allHotels.Select(
                        $"address LIKE '%{destination.Replace("'", "''")}%'"
                    );
                    lblHotelsTitle.Text = $"Hotels in '{destination}'";
                }

                if (filteredHotels.Length == 0)
                {
                    Label noResultsLabel = new Label();
                    noResultsLabel.Text = "No hotels found in this destination. Try searching for another location!";
                    noResultsLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
                    noResultsLabel.ForeColor = Color.Gray;
                    noResultsLabel.AutoSize = true;
                    noResultsLabel.Padding = new Padding(20);
                    flowLayoutPanelHotels.Controls.Add(noResultsLabel);
                    return;
                }

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
            Panel card = new Panel();
            card.Width = 300;
            card.Height = 320; // Increased height for image
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Padding = new Padding(10);

            // Hotel Image PictureBox
            PictureBox picHotel = new PictureBox();
            picHotel.Size = new Size(280, 140);
            picHotel.Location = new Point(10, 10);
            picHotel.SizeMode = PictureBoxSizeMode.Zoom;
            picHotel.BackColor = Color.FromArgb(240, 240, 240);

            // Try to load hotel image from database
            try
            {
                if (hotelData.Table.Columns.Contains("image") &&
                    hotelData["image"] != null &&
                    hotelData["image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])hotelData["image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picHotel.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picHotel.Image = defaultHotelImage;
                }
            }
            catch
            {
                picHotel.Image = defaultHotelImage;
            }
            card.Controls.Add(picHotel);

            // Hotel name label
            Label lblName = new Label();
            lblName.Text = hotelData["name"].ToString();
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = false;
            lblName.Size = new Size(270, 28);
            lblName.Location = new Point(10, 158);
            lblName.AutoEllipsis = true;
            card.Controls.Add(lblName);

            // Location icon and label
            Label lblLocation = new Label();
            string address = hotelData["address"].ToString();
            if (address.Length > 45)
            {
                address = address.Substring(0, 42) + "...";
            }
            lblLocation.Text = "📍 " + address;
            lblLocation.Font = new Font("Segoe UI", 9F);
            lblLocation.ForeColor = Color.Gray;
            lblLocation.AutoSize = false;
            lblLocation.Size = new Size(270, 40);
            lblLocation.Location = new Point(10, 188);
            lblLocation.AutoEllipsis = true;
            card.Controls.Add(lblLocation);

            // Divider line
            Panel divider = new Panel();
            divider.Height = 1;
            divider.Width = 280;
            divider.BackColor = Color.LightGray;
            divider.Location = new Point(10, 235);
            card.Controls.Add(divider);

            // Hotel ID (hidden)
            Label lblId = new Label();
            lblId.Text = hotelData["id"].ToString();
            lblId.Visible = false;
            lblId.Name = "hotelId";
            card.Controls.Add(lblId);

            // Book button
            Button btnBook = new Button();
            btnBook.Text = "🏨 Book Now";
            btnBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBook.Size = new Size(280, 45);
            btnBook.Location = new Point(10, 250);
            btnBook.BackColor = Color.FromArgb(0, 122, 204);
            btnBook.ForeColor = Color.White;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.Cursor = Cursors.Hand;
            btnBook.Tag = hotelData;
            btnBook.Click += BtnBook_Click;

            // Button hover effects
            btnBook.MouseEnter += (s, e) => { btnBook.BackColor = Color.FromArgb(0, 100, 180); };
            btnBook.MouseLeave += (s, e) => { btnBook.BackColor = Color.FromArgb(0, 122, 204); };

            card.Controls.Add(btnBook);

            // Card hover effect
            card.MouseEnter += (sender, e) => {
                card.BackColor = Color.FromArgb(248, 250, 252);
                card.BorderStyle = BorderStyle.Fixed3D;
            };
            card.MouseLeave += (sender, e) => {
                card.BackColor = Color.White;
                card.BorderStyle = BorderStyle.FixedSingle;
            };

            return card;
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataRow hotelData = (DataRow)btn.Tag;

            // Validate dates
            if (dateCheckOut.Value <= dateCheckIn.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentCustomerId == -1)
            {
                MessageBox.Show("Error: Could not identify customer. Please log in again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int hotelId = Convert.ToInt32(hotelData["id"]);
            string hotelName = hotelData["name"].ToString();

            // Open the room selection form
            FormRoomSelection roomForm = new FormRoomSelection(
                hotelId,
                currentCustomerId,
                hotelName,
                dateCheckIn.Value,
                dateCheckOut.Value
            );
            roomForm.FormClosed += (s, args) => LoadMyBookings();
            roomForm.ShowDialog();
        }

        private void BookHotel(DataRow hotelData)
        {
            // Not used anymore
        }

        private void LoadMyBookings()
        {
            try
            {
                DataTable bookings = customerRepository.GetCustomerBookings(currentUsername);

                if (bookings.Rows.Count == 0)
                {
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("Message");
                    emptyTable.Rows.Add("You don't have any bookings yet. Search for hotels above to make your first booking!");
                    dataGridViewBookings.DataSource = emptyTable;
                }
                else
                {
                    dataGridViewBookings.DataSource = bookings;
                }
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

        // Logout button handler
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FormChooseRole roleForm = new FormChooseRole();
                roleForm.Show();
            }
        }
    }
}