namespace HotelBookingSystem
{
    partial class ReportsControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Refresh = new Button();
            btnAssetsStatus = new Button();
            dataGridViewReports = new DataGridView();
            btnRoomsByStatus = new Button();
            btnMostBookedRoom = new Button();
            btnHotelRevenue = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnHotelRevenue);
            panel1.Controls.Add(Refresh);
            panel1.Controls.Add(btnAssetsStatus);
            panel1.Controls.Add(dataGridViewReports);
            panel1.Controls.Add(btnRoomsByStatus);
            panel1.Controls.Add(btnMostBookedRoom);
            panel1.Location = new Point(3, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 642);
            panel1.TabIndex = 15;
            // 
            // Refresh
            // 
            Refresh.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Refresh.Location = new Point(571, 103);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(197, 29);
            Refresh.TabIndex = 38;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += btnRefresh_Click;
            // 
            // btnAssetsStatus
            // 
            btnAssetsStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAssetsStatus.Location = new Point(339, 103);
            btnAssetsStatus.Name = "btnAssetsStatus";
            btnAssetsStatus.Size = new Size(197, 29);
            btnAssetsStatus.TabIndex = 36;
            btnAssetsStatus.Text = "Assets Status";
            btnAssetsStatus.UseVisualStyleBackColor = true;
            btnAssetsStatus.Click += btnAssetsStatus_Click;
            // 
            // dataGridViewReports
            // 
            dataGridViewReports.BackgroundColor = Color.White;
            dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReports.GridColor = Color.White;
            dataGridViewReports.Location = new Point(18, 155);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.RowHeadersWidth = 51;
            dataGridViewReports.Size = new Size(769, 469);
            dataGridViewReports.TabIndex = 35;
            // 
            // btnRoomsByStatus
            // 
            btnRoomsByStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoomsByStatus.Location = new Point(85, 103);
            btnRoomsByStatus.Name = "btnRoomsByStatus";
            btnRoomsByStatus.Size = new Size(191, 29);
            btnRoomsByStatus.TabIndex = 8;
            btnRoomsByStatus.Text = "Rooms By Status";
            btnRoomsByStatus.UseVisualStyleBackColor = true;
            btnRoomsByStatus.Click += btnRoomsStatus_Click;
            // 
            // btnMostBookedRoom
            // 
            btnMostBookedRoom.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostBookedRoom.Location = new Point(85, 45);
            btnMostBookedRoom.Name = "btnMostBookedRoom";
            btnMostBookedRoom.Size = new Size(191, 29);
            btnMostBookedRoom.TabIndex = 5;
            btnMostBookedRoom.Text = "Most Booked Room";
            btnMostBookedRoom.UseVisualStyleBackColor = true;
            btnMostBookedRoom.Click += btnMostBookedRoom_Click;
            // 
            // btnHotelRevenue
            // 
            btnHotelRevenue.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHotelRevenue.Location = new Point(339, 45);
            btnHotelRevenue.Name = "btnHotelRevenue";
            btnHotelRevenue.Size = new Size(221, 29);
            btnHotelRevenue.TabIndex = 39;
            btnHotelRevenue.Text = "Hotel With Most Revenue";
            btnHotelRevenue.UseVisualStyleBackColor = true;
            btnHotelRevenue.Click += btnHotelRevenue_Click;
            // 
            // ReportsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "ReportsControl";
            Size = new Size(821, 693);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDeleteAsset;
        private Button btnUpdateAsset;
        private Button btnAssetsStatus;
        private DataGridView dataGridViewReports;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxAssetType;
        private TextBox txtDescription;
        private TextBox txtAssetName;
        private TextBox txtBrand;
        private Label label8;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnRoomsByStatus;
        private Label label3;
        private Button btnMostBookedRoom;
        private Button Refresh;
        private Button btnHotelRevenue;
    }
}
