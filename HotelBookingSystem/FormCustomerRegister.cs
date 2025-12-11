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
        private CustomerRepository customerRepo = new CustomerRepository();
        public FormCustomerRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string username = textUsername.Text.Trim();
            string email = textEmail.Text.Trim();
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;

            // Validations
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password minimum length validation
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password confirmation validation
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email format validation
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = customerRepo.RegisterCustomer(name, username, email, password);

            if (success)
            {
                MessageBox.Show("Registration successful! You can now log in.");
                this.DialogResult = DialogResult.OK;
                this.Close();
                FormCustomerHotel loginForm = new FormCustomerHotel();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Username or email already exists.");
            }
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

        private void textName_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = checkBox1.Checked ? '\0' : '•';
            textConfirmPassword.PasswordChar = checkBox1.Checked ? '\0' : '•';
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormCustomerHotel chooseRoleForm = new FormCustomerHotel();
            chooseRoleForm.FormClosed += (s, args) => this.Close();
            chooseRoleForm.Show();
        }
    }
}