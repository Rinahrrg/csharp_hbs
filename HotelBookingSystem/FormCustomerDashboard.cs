using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelBookingSystem
{
    public partial class FormCustomerDashboard : Form
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private DataTable allHotels;
        private string currentUsername;
        private int currentCustomerId;

        public FormCustomerDashboard(string username = "Guest")
        {
            InitializeComponent();
            currentUsername = username;
            GetCustomerId();
        }

        private void GetCustomerId()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id FROM customers WHERE username = @u", c);
                    cmd.Parameters.AddWithValue("@u", currentUsername);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        currentCustomerId = Convert.ToInt32(result);
                }
            }
            catch { }
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
                        sql += " WHERE address LIKE @dest OR name LIKE @dest";
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

                    if (string.IsNullOrWhiteSpace(destination))
                        lblHotelsTitle.Text = "Recommended Hotels";
                    else
                        lblHotelsTitle.Text = $"Hotels matching '{destination}'";

                    if (allHotels.Rows.Count == 0)
                    {
                        Label noResultsLabel = new Label();
                        noResultsLabel.Text = "No hotels found. Try searching for another location!";
                        noResultsLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
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

            // Hotel Image
            PictureBox picHotel = new PictureBox();
            picHotel.Size = new Size(280, 100);
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

            // Hotel name
            Label lblName = new Label();
            lblName.Text = hotelData["name"].ToString();
            lblName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.MaximumSize = new Size(280, 0);
            lblName.Location = new Point(10, 115);
            card.Controls.Add(lblName);

            // Location
            Label lblLocation = new Label();
            lblLocation.Text = "📍 " + hotelData["address"].ToString();
            lblLocation.Font = new Font("Arial", 9F);
            lblLocation.AutoSize = true;
            lblLocation.MaximumSize = new Size(280, 40);
            lblLocation.Location = new Point(10, 145);
            card.Controls.Add(lblLocation);

            // Booking time info
            Label lblTime = new Label();
            lblTime.Text = $"⏰ Default: {hotelData["default_booking_time"]} hours";
            lblTime.Font = new Font("Arial", 9F);
            lblTime.AutoSize = true;
            lblTime.Location = new Point(10, 185);
            card.Controls.Add(lblTime);

            // Hotel ID (hidden)
            Label lblId = new Label();
            lblId.Text = hotelData["id"].ToString();
            lblId.Visible = false;
            lblId.Name = "hotelId";
            card.Controls.Add(lblId);

            // Book button
            Button btnBook = new Button();
            btnBook.Text = "Book Now";
            btnBook.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Bold);
            btnBook.Size = new Size(280, 40);
            btnBook.Location = new Point(10, 220);
            btnBook.BackColor = Color.FromArgb(0, 122, 204);
            btnBook.ForeColor = Color.White;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Cursor = Cursors.Hand;
            btnBook.Click += (sender, e) => {
                BookHotel(hotelData);
            };
            card.Controls.Add(btnBook);

            // Hover effect
            card.MouseEnter += (sender, e) => card.BackColor = Color.FromArgb(240, 248, 255);
            card.MouseLeave += (sender, e) => card.BackColor = Color.White;

            return card;
        }

        private void BookHotel(DataRow hotelData)
        {
            int hotelId = Convert.ToInt32(hotelData["id"]);

            // Validar fechas
            if (dateCheckOut.Value <= dateCheckIn.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ABRIR EL FORMULARIO DE SELECCIÓN DE HABITACIÓN
            FormRoomSelection roomForm = new FormRoomSelection(
                hotelId,
                currentCustomerId,
                dateCheckIn.Value,
                dateCheckOut.Value
            );

            if (roomForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("¡Reserva realizada con éxito!\nTu código es: " + roomForm.BookingCode,
                    "BOOKIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadMyBookings(); // Actualiza la lista de reservas
            }
        }

        private void LoadMyBookings()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    string sql = @"
                        SELECT 
                            b.booking_code AS 'Code',
                            h.name AS 'Hotel',
                            CONCAT('Room ', r.id) AS 'Room',
                            b.start_time AS 'Check-In',
                            b.end_time AS 'Check-Out',
                            COALESCE(b.food_option, 'None') AS 'Food',
                            CASE 
                                WHEN NOW() BETWEEN b.start_time AND b.end_time THEN 'Active'
                                WHEN NOW() > b.end_time THEN 'Completed'
                                ELSE 'Upcoming'
                            END AS 'Status'
                        FROM bookings b
                        JOIN rooms r ON b.room_id = r.id
                        JOIN floors f ON r.floor_id = f.id
                        JOIN hotels h ON f.hotel_id = h.id
                        WHERE b.customer_id = @cid
                        ORDER BY b.start_time DESC";

                    MySqlCommand cmd = new MySqlCommand(sql, c);
                    cmd.Parameters.AddWithValue("@cid", currentCustomerId);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        dt.Columns.Add("Message");
                        dt.Rows.Add("You don't have any bookings yet. Search for hotels above to make your first booking!");
                    }

                    dataGridViewBookings.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // If error, show empty message
                DataTable dt = new DataTable();
                dt.Columns.Add("Message");
                dt.Rows.Add("No bookings found.");
                dataGridViewBookings.DataSource = dt;
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
    }
}