using HotelBookingSystem.Repository;
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
        private HotelRepository _repo;
        public FormCustomerHotel()
        {
            InitializeComponent();
            _repo = new HotelRepository();
        }
        private void btnCustomerRegister_Click(object sender, EventArgs e)
        {
            FormCustomerRegister registerForm = new FormCustomerRegister();
            registerForm.Show();
            this.Hide();
        }


        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = checkBox1.Checked ? '\0' : '•';
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a user and password.");
                return;
            }

            bool loggedIn = _repo.CustomerLogin(username, password);

            if (loggedIn)
            {
                MessageBox.Show("Successfull login.");

                FormCustomerDashboard dashboard = new FormCustomerDashboard();
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect user or password.");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
