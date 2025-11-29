using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelBookingSystem
{
    public partial class FormCustomerRegister : Form
    {
        // Reemplaza la declaración de txtPassword y asegúrate de que sea del tipo TextBox
        private TextBox txtPassword;

        public FormCustomerRegister()
        {
            InitializeComponent();
        }

        private void FormCustomerRegister_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // En el método btnCustomerRegister_Click, asegúrate de que txtPassword es un TextBox y accede a su propiedad Text
        private void btnCustomerRegister_Click(object sender, EventArgs e)
        {
            FormCustomerHotel customer = new FormCustomerHotel()
            {
                
            };

            CustomerRepository repo = new CustomerRepository();
            repo.AddCustomer(customer);

            MessageBox.Show("Cliente registrado con éxito");
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
