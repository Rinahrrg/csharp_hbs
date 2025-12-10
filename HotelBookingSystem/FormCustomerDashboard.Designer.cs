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
            lblTitle = new Label();
            txtDestination = new TextBox();
            btnSearch = new Button();
            flowLayoutPanelHotels = new FlowLayoutPanel();
            panelSearch = new Panel();
            lblDestination = new Label();
            lblCheckIn = new Label();
            dateCheckIn = new DateTimePicker();
            lblCheckOut = new Label();
            dateCheckOut = new DateTimePicker();
            lblHotelsTitle = new Label();
            lblMyBookings = new Label();
            dataGridViewBookings = new DataGridView();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(16, 14);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(153, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BOOKIFY";
            // 
            // txtDestination
            // 
            txtDestination.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDestination.Location = new Point(13, 49);
            txtDestination.Margin = new Padding(4, 5, 4, 5);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(265, 26);
            txtDestination.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(745, 32);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(155, 49);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search Hotels";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // flowLayoutPanelHotels
            // 
            flowLayoutPanelHotels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelHotels.AutoScroll = true;
            flowLayoutPanelHotels.BackColor = Color.WhiteSmoke;
            flowLayoutPanelHotels.Location = new Point(16, 265);
            flowLayoutPanelHotels.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelHotels.Name = "flowLayoutPanelHotels";
            flowLayoutPanelHotels.Padding = new Padding(13, 15, 13, 15);
            flowLayoutPanelHotels.Size = new Size(1028, 431);
            flowLayoutPanelHotels.TabIndex = 3;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSearch.BackColor = Color.Black;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(lblDestination);
            panelSearch.Controls.Add(txtDestination);
            panelSearch.Controls.Add(lblCheckIn);
            panelSearch.Controls.Add(dateCheckIn);
            panelSearch.Controls.Add(lblCheckOut);
            panelSearch.Controls.Add(dateCheckOut);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Location = new Point(16, 77);
            panelSearch.Margin = new Padding(4, 5, 4, 5);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1028, 114);
            panelSearch.TabIndex = 4;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestination.ForeColor = Color.White;
            lblDestination.Location = new Point(13, 18);
            lblDestination.Margin = new Padding(4, 0, 4, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(90, 17);
            lblDestination.TabIndex = 0;
            lblDestination.Text = "Destination";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckIn.ForeColor = Color.White;
            lblCheckIn.Location = new Point(293, 18);
            lblCheckIn.Margin = new Padding(4, 0, 4, 0);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(74, 17);
            lblCheckIn.TabIndex = 2;
            lblCheckIn.Text = "Check-In";
            // 
            // dateCheckIn
            // 
            dateCheckIn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateCheckIn.Format = DateTimePickerFormat.Short;
            dateCheckIn.Location = new Point(293, 49);
            dateCheckIn.Margin = new Padding(4, 5, 4, 5);
            dateCheckIn.Name = "dateCheckIn";
            dateCheckIn.Size = new Size(199, 26);
            dateCheckIn.TabIndex = 3;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckOut.ForeColor = Color.White;
            lblCheckOut.Location = new Point(507, 18);
            lblCheckOut.Margin = new Padding(4, 0, 4, 0);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(86, 17);
            lblCheckOut.TabIndex = 4;
            lblCheckOut.Text = "Check-Out";
            // 
            // dateCheckOut
            // 
            dateCheckOut.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateCheckOut.Format = DateTimePickerFormat.Short;
            dateCheckOut.Location = new Point(507, 49);
            dateCheckOut.Margin = new Padding(4, 5, 4, 5);
            dateCheckOut.Name = "dateCheckOut";
            dateCheckOut.Size = new Size(199, 26);
            dateCheckOut.TabIndex = 5;
            // 
            // lblHotelsTitle
            // 
            lblHotelsTitle.AutoSize = true;
            lblHotelsTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHotelsTitle.Location = new Point(16, 215);
            lblHotelsTitle.Margin = new Padding(4, 0, 4, 0);
            lblHotelsTitle.Name = "lblHotelsTitle";
            lblHotelsTitle.Size = new Size(225, 23);
            lblHotelsTitle.TabIndex = 5;
            lblHotelsTitle.Text = "Recommended Hotels";
            // 
            // lblMyBookings
            // 
            lblMyBookings.AutoSize = true;
            lblMyBookings.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMyBookings.Location = new Point(16, 723);
            lblMyBookings.Margin = new Padding(4, 0, 4, 0);
            lblMyBookings.Name = "lblMyBookings";
            lblMyBookings.Size = new Size(133, 23);
            lblMyBookings.TabIndex = 6;
            lblMyBookings.Text = "My Bookings";
            // 
            // dataGridViewBookings
            // 
            dataGridViewBookings.AllowUserToAddRows = false;
            dataGridViewBookings.AllowUserToDeleteRows = false;
            dataGridViewBookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBookings.BackgroundColor = Color.Black;
            dataGridViewBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookings.Location = new Point(16, 769);
            dataGridViewBookings.Margin = new Padding(4, 5, 4, 5);
            dataGridViewBookings.Name = "dataGridViewBookings";
            dataGridViewBookings.ReadOnly = true;
            dataGridViewBookings.RowHeadersVisible = false;
            dataGridViewBookings.RowHeadersWidth = 51;
            dataGridViewBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBookings.Size = new Size(1028, 277);
            dataGridViewBookings.TabIndex = 7;
            // 
            // FormCustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1060, 1055);
            Controls.Add(dataGridViewBookings);
            Controls.Add(lblMyBookings);
            Controls.Add(lblHotelsTitle);
            Controls.Add(panelSearch);
            Controls.Add(flowLayoutPanelHotels);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCustomerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard - Hotel Booking System";
            Load += FormCustomerDashboard_Load;
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dateCheckOut;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHotels;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblHotelsTitle;
        private System.Windows.Forms.Label lblMyBookings;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
    }
}