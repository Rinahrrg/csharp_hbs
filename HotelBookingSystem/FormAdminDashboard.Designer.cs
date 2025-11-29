namespace HotelBookingSystem
{
    partial class FormAdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminDashboard));
            panelMenu = new Panel();
            btnAddHotel = new Button();
            btnViewHotels = new Button();
            btnUpdateHotels = new Button();
            btnAssets = new Button();
            pictureLogo = new PictureBox();
            panelCentral = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightSteelBlue;
            panelMenu.Controls.Add(btnAddHotel);
            panelMenu.Controls.Add(btnViewHotels);
            panelMenu.Controls.Add(btnUpdateHotels);
            panelMenu.Controls.Add(btnAssets);
            panelMenu.Controls.Add(pictureLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(180, 600);
            panelMenu.TabIndex = 1;
            // 
            // btnAddHotel
            // 
            btnAddHotel.Location = new Point(10, 120);
            btnAddHotel.Name = "btnAddHotel";
            btnAddHotel.Size = new Size(160, 40);
            btnAddHotel.TabIndex = 0;
            btnAddHotel.Text = "Add";
            btnAddHotel.Click += btnAddHotel_Click;
            // 
            // btnViewHotels
            // 
            btnViewHotels.Location = new Point(10, 170);
            btnViewHotels.Name = "btnViewHotels";
            btnViewHotels.Size = new Size(160, 40);
            btnViewHotels.TabIndex = 1;
            btnViewHotels.Text = "View Hotels";
            // 
            // btnUpdateHotels
            // 
            btnUpdateHotels.Location = new Point(10, 220);
            btnUpdateHotels.Name = "btnUpdateHotels";
            btnUpdateHotels.Size = new Size(160, 40);
            btnUpdateHotels.TabIndex = 2;
            btnUpdateHotels.Text = "Update";
            // 
            // btnAssets
            // 
            btnAssets.Location = new Point(10, 270);
            btnAssets.Name = "btnAssets";
            btnAssets.Size = new Size(160, 40);
            btnAssets.TabIndex = 3;
            btnAssets.Text = "Assets";
            // 
            // pictureLogo
            // 
            pictureLogo.Dock = DockStyle.Top;
            pictureLogo.Image = Properties.Resources.Bookily_removebg_preview;
            pictureLogo.Location = new Point(0, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(180, 100);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 4;
            pictureLogo.TabStop = false;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.White;
            panelCentral.BackgroundImage = (Image)resources.GetObject("panelCentral.BackgroundImage");
            panelCentral.BackgroundImageLayout = ImageLayout.Center;
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(180, 0);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(820, 600);
            panelCentral.TabIndex = 0;
            // 
            // FormAdminDashboard
            // 
            ClientSize = new Size(1000, 600);
            Controls.Add(panelCentral);
            Controls.Add(panelMenu);
            Name = "FormAdminDashboard";
            Text = "Admin Dashboard";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelCentral;
        private Button btnAddHotel;
        private Button btnViewHotels;
        private Button btnUpdateHotels;
        private Button btnAssets;
        private PictureBox pictureLogo;
    }
}
