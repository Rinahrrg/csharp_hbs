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
            panelMenu = new Panel();
            btnReports = new Button();
            btnCustomers = new Button();
            btnFoodOrder = new Button();
            btnBookings = new Button();
            button1 = new Button();
            btnAddHotel = new Button();
            btnFloors = new Button();
            btnRooms = new Button();
            btnAssets = new Button();
            pictureLogo = new PictureBox();
            panelCentral = new Panel();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnCustomers);
            panelMenu.Controls.Add(btnFoodOrder);
            panelMenu.Controls.Add(btnBookings);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnAddHotel);
            panelMenu.Controls.Add(btnFloors);
            panelMenu.Controls.Add(btnRooms);
            panelMenu.Controls.Add(btnAssets);
            panelMenu.Controls.Add(pictureLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(180, 693);
            panelMenu.TabIndex = 1;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(12, 492);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(150, 40);
            btnReports.TabIndex = 8;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.Location = new Point(12, 446);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(150, 40);
            btnCustomers.TabIndex = 7;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnFoodOrder
            // 
            btnFoodOrder.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFoodOrder.Location = new Point(12, 400);
            btnFoodOrder.Name = "btnFoodOrder";
            btnFoodOrder.Size = new Size(150, 40);
            btnFoodOrder.TabIndex = 6;
            btnFoodOrder.Text = "Food Orders";
            btnFoodOrder.UseVisualStyleBackColor = true;
            btnFoodOrder.Click += btnFoodOrder_Click;
            // 
            // btnBookings
            // 
            btnBookings.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookings.Location = new Point(12, 354);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(150, 40);
            btnBookings.TabIndex = 5;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 611);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAddHotel
            // 
            btnAddHotel.BackColor = Color.White;
            btnAddHotel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddHotel.Location = new Point(12, 170);
            btnAddHotel.Name = "btnAddHotel";
            btnAddHotel.Size = new Size(150, 40);
            btnAddHotel.TabIndex = 0;
            btnAddHotel.Text = "Add Hotel";
            btnAddHotel.UseVisualStyleBackColor = false;
            btnAddHotel.Click += btnAddHotel_Click;
            // 
            // btnFloors
            // 
            btnFloors.BackColor = Color.White;
            btnFloors.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFloors.Location = new Point(12, 216);
            btnFloors.Name = "btnFloors";
            btnFloors.Size = new Size(150, 40);
            btnFloors.TabIndex = 1;
            btnFloors.Text = "Floors";
            btnFloors.UseVisualStyleBackColor = false;
            btnFloors.Click += btnFloors_Click;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = Color.White;
            btnRooms.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRooms.Location = new Point(12, 262);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(150, 40);
            btnRooms.TabIndex = 2;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = false;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnAssets
            // 
            btnAssets.BackColor = Color.White;
            btnAssets.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAssets.Location = new Point(12, 308);
            btnAssets.Name = "btnAssets";
            btnAssets.Size = new Size(150, 40);
            btnAssets.TabIndex = 3;
            btnAssets.Text = "Assets";
            btnAssets.UseVisualStyleBackColor = false;
            btnAssets.Click += btnAssets_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.Dock = DockStyle.Top;
            pictureLogo.Image = Properties.Resources.Bookily__1__removebg_preview;
            pictureLogo.Location = new Point(0, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(180, 184);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 4;
            pictureLogo.TabStop = false;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.White;
            panelCentral.BackgroundImageLayout = ImageLayout.Center;
            panelCentral.Dock = DockStyle.Bottom;
            panelCentral.Location = new Point(180, 96);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(820, 597);
            panelCentral.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(206, 43);
            label1.Name = "label1";
            label1.Size = new Size(234, 23);
            label1.TabIndex = 2;
            label1.Text = "Welcome Back, Admin!";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = Color.Black;
            dateTimePicker1.Location = new Point(676, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // FormAdminDashboard
            // 
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1000, 693);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(panelCentral);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdminDashboard";
            Text = "Admin Dashboard";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelCentral;
        private Button btnAddHotel;
        private Button btnFloors;
        private Button btnRooms;
        private Button btnAssets;
        private PictureBox pictureLogo;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button btnReports;
        private Button btnCustomers;
        private Button btnFoodOrder;
        private Button btnBookings;
    }
}
