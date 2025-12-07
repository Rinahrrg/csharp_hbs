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

        // Método que carga cualquier UserControl en panelCentral
        private void LoadControl(UserControl control)
        {
            panelCentral.Controls.Clear(); // limpia lo que estaba antes
            control.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(control);
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
            // Si no necesitas hacer nada al pintar, déjalo vacío
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            // Si quieres cargar algo al iniciar, hazlo aquí. Si no, déjalo vacío.
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
            LoadControl(new CustomerControl());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadControl(new ReportsControl());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
