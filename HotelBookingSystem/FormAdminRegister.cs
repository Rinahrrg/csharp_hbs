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
    public partial class FormAdminRegister : Form
    {
        public FormAdminRegister()
        {
            InitializeComponent();
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin registered successfully!");

            this.Hide();
            new FormAdminHotel().Show();
        }

    }
}
