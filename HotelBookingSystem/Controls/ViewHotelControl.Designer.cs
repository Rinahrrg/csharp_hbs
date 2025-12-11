namespace HotelBookingSystem
{
    partial class ViewHotelControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridViewHotel = new DataGridView();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotel).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(dataGridViewHotel);
            panel1.Controls.Add(btnRefresh);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 642);
            panel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(20, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(769, 442);
            flowLayoutPanel1.TabIndex = 36;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // dataGridViewHotel
            // 
            dataGridViewHotel.BackgroundColor = Color.White;
            dataGridViewHotel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHotel.GridColor = Color.White;
            dataGridViewHotel.Location = new Point(20, 57);
            dataGridViewHotel.Name = "dataGridViewHotel";
            dataGridViewHotel.RowHeadersWidth = 51;
            dataGridViewHotel.Size = new Size(769, 442);
            dataGridViewHotel.TabIndex = 35;
            dataGridViewHotel.CellContentClick += dataGridViewFoodOrders_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(20, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh All Bookings";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ViewHotelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "ViewHotelControl";
            Size = new Size(821, 693);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewHotel;
        private Button btnRefresh;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
