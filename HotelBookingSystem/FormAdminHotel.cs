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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelBookingSystem
{
    public partial class FormAdminHotel : Form
    {
        private HotelRepository _repo;
        public FormAdminHotel()
        {
            InitializeComponent();
            _repo = new HotelRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a user and password.");
                return;
            }

            bool loggedIn = _repo.AdminLogin(username, password);

            if (loggedIn)
            {
                MessageBox.Show("Successfull login.");

                // Abrir formulario principal del admin
                FormAdminDashboard dashboard = new FormAdminDashboard();
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect user or password.");
            }

        }

        private void FormAdminHotel_Load(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = checkBox1.Checked ? '\0' : '•';
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormChooseRole chooseRoleForm = new FormChooseRole();
            chooseRoleForm.FormClosed += (s, args) => this.Close();
            chooseRoleForm.Show();
        }
    }
}
