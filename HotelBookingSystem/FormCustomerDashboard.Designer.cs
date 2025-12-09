namespace HotelBookingSystem
{
    partial class FormCustomerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSearch = new TextBox();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            btnSearch = new Button();
            label2 = new Label();
            dataGridViewMyBookings = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txtBookingCode = new TextBox();
            btnViewBooking = new Button();
            flowLayoutPanelHotels = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            lblHotelName = new Label();
            lblPrice = new Label();
            btnViewRooms = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyBookings).BeginInit();
            flowLayoutPanelHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 65);
            label1.Name = "label1";
            label1.Size = new Size(168, 17);
            label1.TabIndex = 0;
            label1.Text = "Where are you going?";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(30, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(245, 27);
            txtSearch.TabIndex = 1;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(332, 93);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(109, 27);
            dtpCheckIn.TabIndex = 2;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(471, 93);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(109, 27);
            dtpCheckOut.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(627, 94);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 149);
            label2.Name = "label2";
            label2.Size = new Size(125, 17);
            label2.TabIndex = 6;
            label2.Text = "Available Hotels";
            // 
            // dataGridViewMyBookings
            // 
            dataGridViewMyBookings.BackgroundColor = Color.Black;
            dataGridViewMyBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMyBookings.Location = new Point(12, 462);
            dataGridViewMyBookings.Name = "dataGridViewMyBookings";
            dataGridViewMyBookings.RowHeadersWidth = 51;
            dataGridViewMyBookings.Size = new Size(776, 188);
            dataGridViewMyBookings.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 442);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 8;
            label3.Text = "My Bookings";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 686);
            label4.Name = "label4";
            label4.Size = new Size(175, 17);
            label4.TabIndex = 9;
            label4.Text = "View Booking by Code:";
            label4.Click += label4_Click;
            // 
            // txtBookingCode
            // 
            txtBookingCode.Location = new Point(211, 676);
            txtBookingCode.Name = "txtBookingCode";
            txtBookingCode.Size = new Size(248, 27);
            txtBookingCode.TabIndex = 10;
            // 
            // btnViewBooking
            // 
            btnViewBooking.BackColor = Color.Black;
            btnViewBooking.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewBooking.ForeColor = Color.White;
            btnViewBooking.Location = new Point(504, 674);
            btnViewBooking.Name = "btnViewBooking";
            btnViewBooking.Size = new Size(170, 29);
            btnViewBooking.TabIndex = 11;
            btnViewBooking.Text = "View Details";
            btnViewBooking.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelHotels
            // 
            flowLayoutPanelHotels.BackColor = Color.Black;
            flowLayoutPanelHotels.Controls.Add(pictureBox1);
            flowLayoutPanelHotels.Controls.Add(lblHotelName);
            flowLayoutPanelHotels.Controls.Add(lblPrice);
            flowLayoutPanelHotels.Controls.Add(btnViewRooms);
            flowLayoutPanelHotels.Location = new Point(30, 187);
            flowLayoutPanelHotels.Name = "flowLayoutPanelHotels";
            flowLayoutPanelHotels.Size = new Size(200, 222);
            flowLayoutPanelHotels.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHotelName.ForeColor = Color.White;
            lblHotelName.Location = new Point(3, 136);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(52, 17);
            lblHotelName.TabIndex = 1;
            lblHotelName.Text = "label5";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(61, 136);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 17);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "label5";
            // 
            // btnViewRooms
            // 
            btnViewRooms.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewRooms.Location = new Point(3, 156);
            btnViewRooms.Name = "btnViewRooms";
            btnViewRooms.Size = new Size(94, 29);
            btnViewRooms.TabIndex = 3;
            btnViewRooms.Text = "Book";
            btnViewRooms.UseVisualStyleBackColor = true;
            // 
            // FormCustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 750);
            Controls.Add(flowLayoutPanelHotels);
            Controls.Add(btnViewBooking);
            Controls.Add(txtBookingCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridViewMyBookings);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomerDashboard";
            Text = "FormCustomerDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyBookings).EndInit();
            flowLayoutPanelHotels.ResumeLayout(false);
            flowLayoutPanelHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private Button btnSearch;
        private Label label2;
        private DataGridView dataGridViewMyBookings;
        private Label label3;
        private Label label4;
        private TextBox txtBookingCode;
        private Button btnViewBooking;
        private FlowLayoutPanel flowLayoutPanelHotels;
        private PictureBox pictureBox1;
        private Label lblHotelName;
        private Label lblPrice;
        private Button btnViewRooms;
    }
}