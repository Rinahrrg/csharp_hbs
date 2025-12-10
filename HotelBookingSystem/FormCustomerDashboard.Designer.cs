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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanelHotels = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblHotelsTitle = new System.Windows.Forms.Label();
            this.lblMyBookings = new System.Windows.Forms.Label();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hotel Booking Dashboard";
            //
            // lblDestination
            //
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(10, 12);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(79, 15);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "Destination";
            //
            // txtDestination
            //
            this.txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(10, 32);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(200, 23);
            this.txtDestination.TabIndex = 1;
            //
            // lblCheckIn
            //
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(220, 12);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(63, 15);
            this.lblCheckIn.TabIndex = 2;
            this.lblCheckIn.Text = "Check-In";
            //
            // dateCheckIn
            //
            this.dateCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCheckIn.Location = new System.Drawing.Point(220, 32);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(150, 23);
            this.dateCheckIn.TabIndex = 3;
            //
            // lblCheckOut
            //
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(380, 12);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(74, 15);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check-Out";
            //
            // dateCheckOut
            //
            this.dateCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCheckOut.Location = new System.Drawing.Point(380, 32);
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.Size = new System.Drawing.Size(150, 23);
            this.dateCheckOut.TabIndex = 5;
            //
            // btnSearch
            //
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(545, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search Hotels";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // flowLayoutPanelHotels
            //
            this.flowLayoutPanelHotels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelHotels.AutoScroll = true;
            this.flowLayoutPanelHotels.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelHotels.Location = new System.Drawing.Point(12, 172);
            this.flowLayoutPanelHotels.Name = "flowLayoutPanelHotels";
            this.flowLayoutPanelHotels.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelHotels.Size = new System.Drawing.Size(976, 280);
            this.flowLayoutPanelHotels.TabIndex = 3;
            //
            // panelSearch
            //
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.lblDestination);
            this.panelSearch.Controls.Add(this.txtDestination);
            this.panelSearch.Controls.Add(this.lblCheckIn);
            this.panelSearch.Controls.Add(this.dateCheckIn);
            this.panelSearch.Controls.Add(this.lblCheckOut);
            this.panelSearch.Controls.Add(this.dateCheckOut);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Location = new System.Drawing.Point(12, 50);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(976, 75);
            this.panelSearch.TabIndex = 4;
            //
            // lblHotelsTitle
            //
            this.lblHotelsTitle.AutoSize = true;
            this.lblHotelsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelsTitle.Location = new System.Drawing.Point(12, 140);
            this.lblHotelsTitle.Name = "lblHotelsTitle";
            this.lblHotelsTitle.Size = new System.Drawing.Size(174, 20);
            this.lblHotelsTitle.TabIndex = 5;
            this.lblHotelsTitle.Text = "Recommended Hotels";
            //
            // lblMyBookings
            //
            this.lblMyBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMyBookings.AutoSize = true;
            this.lblMyBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBookings.Location = new System.Drawing.Point(12, 470);
            this.lblMyBookings.Name = "lblMyBookings";
            this.lblMyBookings.Size = new System.Drawing.Size(115, 20);
            this.lblMyBookings.TabIndex = 6;
            this.lblMyBookings.Text = "My Bookings";
            //
            // dataGridViewBookings
            //
            this.dataGridViewBookings.AllowUserToAddRows = false;
            this.dataGridViewBookings.AllowUserToDeleteRows = false;
            this.dataGridViewBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookings.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(12, 500);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.ReadOnly = true;
            this.dataGridViewBookings.RowHeadersVisible = false;
            this.dataGridViewBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookings.Size = new System.Drawing.Size(976, 180);
            this.dataGridViewBookings.TabIndex = 7;
            //
            // FormCustomerDashboard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.dataGridViewBookings);
            this.Controls.Add(this.lblMyBookings);
            this.Controls.Add(this.lblHotelsTitle);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.flowLayoutPanelHotels);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormCustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard - Hotel Booking System";
            this.Load += new System.EventHandler(this.FormCustomerDashboard_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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