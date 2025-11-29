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
    public partial class FormCustomerHotel : Form
    {
        private CustomerRepository customerRepo = new CustomerRepository();
        public FormCustomerHotel()
        {
            InitializeComponent();
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            dataGridView1.DataSource = customerRepo.GetAllCustomers();
        }
        private void btnCustomerRegister_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            customerRepo.Register(username, password);
            MessageBox.Show("Cliente registrado con éxito");
            LoadCustomers();
        }


    }
}
