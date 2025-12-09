using MySql.Data.MySqlClient;
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
    public partial class AssetsControl : UserControl
    {
        private readonly string conn = "server=localhost;database=hotel_system;user=root;password=Hrrg2906_;";
        private int editingAssetId = -1;

        public AssetsControl()
        {
            InitializeComponent();
            LoadAssetTypes();
            LoadAssets();
            LoadStatusCombo();
        }

        private void LoadAssetTypes()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, type FROM asset_types", c);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxAssetType.DisplayMember = "type";  
                comboBoxAssetType.ValueMember = "id";     
                comboBoxAssetType.DataSource = dt;        
            }
        }


        private void LoadAssets()
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                string sql = @"
                    SELECT 
                        a.id,
                        a.name AS 'Name',
                        a.description AS 'Description',
                        a.brand AS 'Brand',
                        at.type AS 'Type',
                        at.status AS 'Status',
                        (SELECT COUNT(*) FROM room_type_assets rta WHERE rta.asset_id = a.id) AS 'Used in Rooms'
                    FROM assets a
                    JOIN asset_types at ON a.asset_type = at.id
                    ORDER BY a.name";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAssets.DataSource = dt;
            }
        }

        private void LoadStatusCombo()
        {
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("working");
            comboBoxStatus.Items.Add("under maintenance");
            comboBoxStatus.Items.Add("damaged");
            comboBoxStatus.SelectedIndex = 0;
        }
        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssetName.Text))
            {
                MessageBox.Show("Asset name is required!");
                return;
            }

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO assets (name, description, brand, asset_type, status) VALUES (@name, @desc, @brand, @type, @status)", c);
                cmd.Parameters.AddWithValue("@name", txtAssetName.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text.Trim());
                cmd.Parameters.AddWithValue("@type", Convert.ToInt32(comboBoxAssetType.SelectedValue));
                cmd.Parameters.AddWithValue("@status", comboBoxStatus.SelectedItem.ToString()); // Aseguramos que se usa el estado seleccionado
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Asset added successfully!");
            LoadAssets();
            ClearForm();
        }
        private void btnEditAsset_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssets.SelectedRows.Count == 0) return;

            var row = dataGridViewAssets.SelectedRows[0];
            editingAssetId = Convert.ToInt32(row.Cells["id"].Value);
            txtAssetName.Text = row.Cells["Name"].Value.ToString();
            txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";
            txtBrand.Text = row.Cells["Brand"].Value?.ToString() ?? "";
            comboBoxAssetType.Text = row.Cells["Type"].Value.ToString();
            comboBoxStatus.SelectedItem = row.Cells["Status"].Value.ToString(); // Cargar el estado del asset
        }
        private void btnUpdateAsset_Click(object sender, EventArgs e)
        {
            if (editingAssetId == -1) return;

            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();

                // Primero, actualizamos la tabla assets, sin tocar el campo status.
                MySqlCommand cmdUpdateAsset = new MySqlCommand(
                    "UPDATE assets SET name=@name, description=@desc, brand=@brand, asset_type=@type WHERE id=@id", c);
                cmdUpdateAsset.Parameters.AddWithValue("@name", txtAssetName.Text.Trim());
                cmdUpdateAsset.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                cmdUpdateAsset.Parameters.AddWithValue("@brand", txtBrand.Text.Trim());
                cmdUpdateAsset.Parameters.AddWithValue("@type", Convert.ToInt32(comboBoxAssetType.SelectedValue));
                cmdUpdateAsset.Parameters.AddWithValue("@id", editingAssetId);
                cmdUpdateAsset.ExecuteNonQuery();

                // Luego, actualizamos el campo status en la tabla asset_types.
                MySqlCommand cmdUpdateStatus = new MySqlCommand(
                    "UPDATE asset_types SET status=@status WHERE id=@typeId", c);
                cmdUpdateStatus.Parameters.AddWithValue("@status", comboBoxStatus.SelectedItem.ToString()); // Usamos el estado seleccionado
                cmdUpdateStatus.Parameters.AddWithValue("@typeId", Convert.ToInt32(comboBoxAssetType.SelectedValue)); // ID del tipo de asset
                cmdUpdateStatus.ExecuteNonQuery();
            }

            MessageBox.Show("Asset updated!");
            LoadAssets();
            ClearForm();
        }

        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssets.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Delete this asset? It will be removed from all rooms.", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int assetId = Convert.ToInt32(dataGridViewAssets.SelectedRows[0].Cells["id"].Value);
                using (MySqlConnection c = new MySqlConnection(conn))
                {
                    c.Open();
                    new MySqlCommand($"DELETE FROM room_type_assets WHERE asset_id = {assetId}", c).ExecuteNonQuery();
                    new MySqlCommand($"DELETE FROM assets WHERE id = {assetId}", c).ExecuteNonQuery();
                }
                LoadAssets();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadAssets();

        private void AssetsControl_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("working");
            comboBoxStatus.Items.Add("under maintenance");
            comboBoxStatus.Items.Add("damaged");
            comboBoxStatus.SelectedIndex = 0;
        }

        private void ClearForm()
        {
            editingAssetId = -1;
            txtAssetName.Clear();
            txtDescription.Clear();
            txtBrand.Clear();
            comboBoxAssetType.SelectedIndex = -1;  
        }
    }
}
