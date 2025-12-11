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
    public partial class FormAdminDashboard : Form
    {
        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            LoadControl(new AddHotelControl());
        }

        private void LoadControl(UserControl control)
        {
            panelCentral.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(control);
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnFloors_Click(object sender, EventArgs e)
        {
            LoadControl(new FloorsControl());
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            LoadControl(new RoomsControl());
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            LoadControl(new AssetsControl());
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            LoadControl(new BookingsControl());
        }

        private void btnFoodOrder_Click(object sender, EventArgs e)
        {
            LoadControl(new FoodOrdersControl());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewHotelControl());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadControl(new ReportsControl());
        }

        private void btnAdminManagement_Click(object sender, EventArgs e)
        {
            LoadControl(new AdminManagementControl());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdminHotel loginForm = new FormAdminHotel();
            loginForm.Show();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
        }
    }
}
