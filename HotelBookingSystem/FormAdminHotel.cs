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
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }

            bool loggedIn = _repo.AdminLogin(username, password);

            if (loggedIn)
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                // Abrir formulario principal del admin
                FormAdminDashboard dashboard = new FormAdminDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }

        private void FormAdminHotel_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAdminRegister().Show();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
