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
    public partial class ViewHotelControl : UserControl
    {
        private HotelRepository _repo;
        public ViewHotelControl()
        {
            InitializeComponent();
            _repo = new HotelRepository();
            LoadHotels();
        }

        private void dataGridViewHotels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar clics en las celdas si quieres
            // Si no necesitas acción, deja vacío
        }

        private void LoadHotels()
        {
            DataTable dt = _repo.GetHotels();
         //   dataGridViewHotel.DataSource = dt;
        }

        private void dataGridViewFoodOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
