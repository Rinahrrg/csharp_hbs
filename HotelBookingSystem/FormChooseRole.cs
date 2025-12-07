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
    public partial class FormChooseRole : Form
    {
        public FormChooseRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormCustomerHotel().Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAdminHotel().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
