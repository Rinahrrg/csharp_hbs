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
    public partial class FormRoomSelection : Form
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int hotelId;
        private int customerId;

        public FormRoomSelection(int hotelId, int customerId)
        {
            InitializeComponent();
            this.hotelId = hotelId;
            this.customerId = customerId;
            LoadFloors();
        }

        private void LoadFloors()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = "SELECT id FROM floors WHERE hotel_id = @hid ORDER BY id";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                da.SelectCommand.Parameters.AddWithValue("@hid", hotelId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxFloor.DataSource = dt;
                comboBoxFloor.DisplayMember = "id";
                comboBoxFloor.ValueMember = "id";
            }
        }

        private void comboBoxFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableRooms();
        }

        private void LoadAvailableRooms()
        {
            flowLayoutPanelRooms.Controls.Clear(); // limpia el FlowLayoutPanel
            if (comboBoxFloor.SelectedValue == null) return;

            int floorId = Convert.ToInt32(comboBoxFloor.SelectedValue);
            DateTime checkIn = dtpCheckin.Value.Date;
            DateTime checkOut = dtpCheckout.Value.Date;

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT 
                        r.id,
                        r.max_beds,
                        (SELECT GROUP_CONCAT(at.type) 
                         FROM room_type_assets rta
                         JOIN assets a ON rta.asset_id = a.id
                         JOIN asset_types at ON a.asset_type = at.id
                         WHERE rta.room_id = r.id) AS assets
                    FROM rooms r
                    WHERE r.floor_id = @fid
                    AND r.id NOT IN (
                        SELECT room_id FROM bookings 
                        WHERE (start_time < @out AND end_time > @in)
                    )";

                MySqlCommand cmd = new MySqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@fid", floorId);
                cmd.Parameters.AddWithValue("@in", checkIn);
                cmd.Parameters.AddWithValue("@out", checkOut);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // CREA UNA TARJETA POR CADA HABITACIÓN
                    Panel roomCard = new Panel();
                    roomCard.Width = 400;
                    roomCard.Height = 120;
                    roomCard.BorderStyle = BorderStyle.FixedSingle;

                    Label lblRoom = new Label();
                    lblRoom.Text = "Room " + reader["id"];
                    lblRoom.Location = new System.Drawing.Point(10, 10);
                    lblRoom.AutoSize = true;

                    Label lblBeds = new Label();
                    lblBeds.Text = "Beds: " + reader["max_beds"];
                    lblBeds.Location = new System.Drawing.Point(10, 40);
                    lblBeds.AutoSize = true;

                    Label lblAssets = new Label();
                    lblAssets.Text = "Assets: " + (reader["assets"] == DBNull.Value ? "None" : reader["assets"]);
                    lblAssets.Location = new System.Drawing.Point(10, 70);
                    lblAssets.AutoSize = true;

                    Button btnBook = new Button();
                    btnBook.Text = "Book";
                    btnBook.Location = new System.Drawing.Point(300, 40);
                    btnBook.Tag = reader["id"]; // guarda el ID de la habitación
                    btnBook.Click += btnBookRoom_Click;

                    roomCard.Controls.Add(lblRoom);
                    roomCard.Controls.Add(lblBeds);
                    roomCard.Controls.Add(lblAssets);
                    roomCard.Controls.Add(btnBook);

                    flowLayoutPanelRooms.Controls.Add(roomCard); // añade al FlowLayoutPanel
                }
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int roomId = Convert.ToInt32(btn.Tag);

            DateTime checkIn = dtpCheckin.Value;
            DateTime checkOut = dtpCheckout.Value;

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out must be after check-in.");
                return;
            }

            string foodOption = "";
            if (chkBreakfast.Checked) foodOption += "Breakfast ";
            if (chkLunch.Checked) foodOption += "Lunch ";
            if (chkDinner.Checked) foodOption += "Dinner ";
            if (chkFullBoard.Checked) foodOption += "Full Board ";
            if (chkNone.Checked) foodOption = "None";
            foodOption = foodOption.Trim();

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();

                // Generar código único con Random
                Random rnd = new Random();
                string code = "BK-" + DateTime.Now.ToString("yyyyMMdd") + "-" + rnd.Next(0, 9999).ToString("D4");

                // Verificar que no exista
                while (true)
                {
                    MySqlCommand check = new MySqlCommand("SELECT COUNT(*) FROM bookings WHERE booking_code = @code", c);
                    check.Parameters.AddWithValue("@code", code);
                    if (Convert.ToInt32(check.ExecuteScalar()) == 0) break;
                    code = "BK-" + DateTime.Now.ToString("yyyyMMdd") + "-" + rnd.Next(0, 9999).ToString("D4");
                }

                MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO bookings 
                    (booking_code, room_id, customer_id, start_time, end_time, food_option)
                    VALUES (@code, @rid, @cid, @in, @out, @food)", c);

                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@rid", roomId);
                cmd.Parameters.AddWithValue("@cid", customerId);
                cmd.Parameters.AddWithValue("@in", checkIn);
                cmd.Parameters.AddWithValue("@out", checkOut);
                cmd.Parameters.AddWithValue("@food", foodOption);
                cmd.ExecuteNonQuery();

                lblBookingCode.Text = "Code: " + code;
                MessageBox.Show($"Booking successful!\nYour code is: {code}", "BOOKIFY");
            }
        }
        private void chkLunch_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
