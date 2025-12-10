namespace HotelBookingSystem
{
    partial class FormRoomSelection
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
            lblHotelName = new Label();
            lblDatesLabel = new Label();
            lblDates = new Label();
            lblNightsLabel = new Label();
            lblNights = new Label();
            dataGridViewRooms = new DataGridView();
            btnSelectRoom = new Button();
            btnCancel = new Button();
            lblInstructions = new Label();
            groupBoxFoodPlan = new GroupBox();
            radioFullBoard = new RadioButton();
            radioHalfBoard = new RadioButton();
            radioBreakfast = new RadioButton();
            radioNoPlan = new RadioButton();
            panelRoomDetails = new Panel();
            lblRoomDetailsContent = new Label();
            lblRoomDetailsTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            groupBoxFoodPlan.SuspendLayout();
            panelRoomDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(16, 14);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(259, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Select Your Room";
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHotelName.ForeColor = Color.DarkBlue;
            lblHotelName.Location = new Point(16, 69);
            lblHotelName.Margin = new Padding(4, 0, 4, 0);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(174, 32);
            lblHotelName.TabIndex = 1;
            lblHotelName.Text = "Hotel Name";
            // 
            // lblDatesLabel
            // 
            lblDatesLabel.AutoSize = true;
            lblDatesLabel.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDatesLabel.Location = new Point(16, 123);
            lblDatesLabel.Margin = new Padding(4, 0, 4, 0);
            lblDatesLabel.Name = "lblDatesLabel";
            lblDatesLabel.Size = new Size(73, 23);
            lblDatesLabel.TabIndex = 2;
            lblDatesLabel.Text = "Dates:";
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDates.Location = new Point(97, 123);
            lblDates.Margin = new Padding(4, 0, 4, 0);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(167, 23);
            lblDates.TabIndex = 3;
            lblDates.Text = "MM/DD - MM/DD";
            // 
            // lblNightsLabel
            // 
            lblNightsLabel.AutoSize = true;
            lblNightsLabel.Font = new Font("Arial Rounded MT Bold", 12F);
            lblNightsLabel.Location = new Point(333, 123);
            lblNightsLabel.Margin = new Padding(4, 0, 4, 0);
            lblNightsLabel.Name = "lblNightsLabel";
            lblNightsLabel.Size = new Size(100, 23);
            lblNightsLabel.TabIndex = 4;
            lblNightsLabel.Text = "Duration:";
            // 
            // lblNights
            // 
            lblNights.AutoSize = true;
            lblNights.Font = new Font("Arial Rounded MT Bold", 12F);
            lblNights.Location = new Point(445, 123);
            lblNights.Margin = new Padding(4, 0, 4, 0);
            lblNights.Name = "lblNights";
            lblNights.Size = new Size(87, 23);
            lblNights.TabIndex = 5;
            lblNights.Text = "X nights";
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.AllowUserToAddRows = false;
            dataGridViewRooms.AllowUserToDeleteRows = false;
            dataGridViewRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRooms.BackgroundColor = Color.White;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(16, 223);
            dataGridViewRooms.Margin = new Padding(4, 5, 4, 5);
            dataGridViewRooms.MultiSelect = false;
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.ReadOnly = true;
            dataGridViewRooms.RowHeadersVisible = false;
            dataGridViewRooms.RowHeadersWidth = 51;
            dataGridViewRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRooms.Size = new Size(667, 385);
            dataGridViewRooms.TabIndex = 6;
            dataGridViewRooms.SelectionChanged += dataGridViewRooms_SelectionChanged;
            // 
            // btnSelectRoom
            // 
            btnSelectRoom.BackColor = Color.Black;
            btnSelectRoom.FlatStyle = FlatStyle.Flat;
            btnSelectRoom.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectRoom.ForeColor = Color.White;
            btnSelectRoom.Location = new Point(784, 715);
            btnSelectRoom.Margin = new Padding(4, 5, 4, 5);
            btnSelectRoom.Name = "btnSelectRoom";
            btnSelectRoom.Size = new Size(267, 69);
            btnSelectRoom.TabIndex = 7;
            btnSelectRoom.Text = "Confirm Booking";
            btnSelectRoom.UseVisualStyleBackColor = false;
            btnSelectRoom.Click += btnSelectRoom_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(707, 715);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(67, 69);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "✕";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = Color.Gray;
            lblInstructions.Location = new Point(16, 177);
            lblInstructions.Margin = new Padding(4, 0, 4, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(497, 20);
            lblInstructions.TabIndex = 9;
            lblInstructions.Text = "Select a room from the list below and click Confirm Booking";
            // 
            // groupBoxFoodPlan
            // 
            groupBoxFoodPlan.BackColor = Color.White;
            groupBoxFoodPlan.Controls.Add(radioFullBoard);
            groupBoxFoodPlan.Controls.Add(radioHalfBoard);
            groupBoxFoodPlan.Controls.Add(radioBreakfast);
            groupBoxFoodPlan.Controls.Add(radioNoPlan);
            groupBoxFoodPlan.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxFoodPlan.Location = new Point(16, 631);
            groupBoxFoodPlan.Margin = new Padding(4, 5, 4, 5);
            groupBoxFoodPlan.Name = "groupBoxFoodPlan";
            groupBoxFoodPlan.Padding = new Padding(4, 5, 4, 5);
            groupBoxFoodPlan.Size = new Size(667, 154);
            groupBoxFoodPlan.TabIndex = 10;
            groupBoxFoodPlan.TabStop = false;
            groupBoxFoodPlan.Text = "Select Food Plan";
            // 
            // radioFullBoard
            // 
            radioFullBoard.AutoSize = true;
            radioFullBoard.Font = new Font("Arial Rounded MT Bold", 9F);
            radioFullBoard.Location = new Point(347, 77);
            radioFullBoard.Margin = new Padding(4, 5, 4, 5);
            radioFullBoard.Name = "radioFullBoard";
            radioFullBoard.Size = new Size(250, 21);
            radioFullBoard.TabIndex = 3;
            radioFullBoard.Text = "Full Board (All Meals Included)";
            radioFullBoard.UseVisualStyleBackColor = true;
            // 
            // radioHalfBoard
            // 
            radioHalfBoard.AutoSize = true;
            radioHalfBoard.Font = new Font("Arial Rounded MT Bold", 9F);
            radioHalfBoard.Location = new Point(347, 38);
            radioHalfBoard.Margin = new Padding(4, 5, 4, 5);
            radioHalfBoard.Name = "radioHalfBoard";
            radioHalfBoard.Size = new Size(259, 21);
            radioHalfBoard.TabIndex = 2;
            radioHalfBoard.Text = "Half Board (Breakfast + Dinner)";
            radioHalfBoard.UseVisualStyleBackColor = true;
            // 
            // radioBreakfast
            // 
            radioBreakfast.AutoSize = true;
            radioBreakfast.Font = new Font("Arial Rounded MT Bold", 9F);
            radioBreakfast.Location = new Point(20, 77);
            radioBreakfast.Margin = new Padding(4, 5, 4, 5);
            radioBreakfast.Name = "radioBreakfast";
            radioBreakfast.Size = new Size(201, 21);
            radioBreakfast.TabIndex = 1;
            radioBreakfast.Text = "Bed and Breakfast (BB)";
            radioBreakfast.UseVisualStyleBackColor = true;
            // 
            // radioNoPlan
            // 
            radioNoPlan.AutoSize = true;
            radioNoPlan.Checked = true;
            radioNoPlan.Font = new Font("Arial Rounded MT Bold", 9F);
            radioNoPlan.Location = new Point(20, 38);
            radioNoPlan.Margin = new Padding(4, 5, 4, 5);
            radioNoPlan.Name = "radioNoPlan";
            radioNoPlan.Size = new Size(188, 21);
            radioNoPlan.TabIndex = 0;
            radioNoPlan.TabStop = true;
            radioNoPlan.Text = "Room Only (No Meals)";
            radioNoPlan.UseVisualStyleBackColor = true;
            // 
            // panelRoomDetails
            // 
            panelRoomDetails.BackColor = Color.FromArgb(245, 248, 250);
            panelRoomDetails.BorderStyle = BorderStyle.FixedSingle;
            panelRoomDetails.Controls.Add(lblRoomDetailsContent);
            panelRoomDetails.Controls.Add(lblRoomDetailsTitle);
            panelRoomDetails.Location = new Point(707, 223);
            panelRoomDetails.Margin = new Padding(4, 5, 4, 5);
            panelRoomDetails.Name = "panelRoomDetails";
            panelRoomDetails.Size = new Size(343, 384);
            panelRoomDetails.TabIndex = 11;
            // 
            // lblRoomDetailsContent
            // 
            lblRoomDetailsContent.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomDetailsContent.Location = new Point(13, 62);
            lblRoomDetailsContent.Margin = new Padding(4, 0, 4, 0);
            lblRoomDetailsContent.Name = "lblRoomDetailsContent";
            lblRoomDetailsContent.Size = new Size(315, 308);
            lblRoomDetailsContent.TabIndex = 1;
            lblRoomDetailsContent.Text = "Select a room to view details";
            // 
            // lblRoomDetailsTitle
            // 
            lblRoomDetailsTitle.AutoSize = true;
            lblRoomDetailsTitle.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomDetailsTitle.Location = new Point(13, 15);
            lblRoomDetailsTitle.Margin = new Padding(4, 0, 4, 0);
            lblRoomDetailsTitle.Name = "lblRoomDetailsTitle";
            lblRoomDetailsTitle.Size = new Size(127, 21);
            lblRoomDetailsTitle.TabIndex = 0;
            lblRoomDetailsTitle.Text = "Room Details";
            // 
            // FormRoomSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1067, 808);
            Controls.Add(panelRoomDetails);
            Controls.Add(groupBoxFoodPlan);
            Controls.Add(lblInstructions);
            Controls.Add(btnCancel);
            Controls.Add(btnSelectRoom);
            Controls.Add(dataGridViewRooms);
            Controls.Add(lblNights);
            Controls.Add(lblNightsLabel);
            Controls.Add(lblDates);
            Controls.Add(lblDatesLabel);
            Controls.Add(lblHotelName);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRoomSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Room Selection - Hotel Booking System";
            Load += FormRoomSelection_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            groupBoxFoodPlan.ResumeLayout(false);
            groupBoxFoodPlan.PerformLayout();
            panelRoomDetails.ResumeLayout(false);
            panelRoomDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label lblDatesLabel;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblNightsLabel;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Button btnSelectRoom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.GroupBox groupBoxFoodPlan;
        private System.Windows.Forms.RadioButton radioFullBoard;
        private System.Windows.Forms.RadioButton radioHalfBoard;
        private System.Windows.Forms.RadioButton radioBreakfast;
        private System.Windows.Forms.RadioButton radioNoPlan;
        private System.Windows.Forms.Panel panelRoomDetails;
        private System.Windows.Forms.Label lblRoomDetailsContent;
        private System.Windows.Forms.Label lblRoomDetailsTitle;
    }
}