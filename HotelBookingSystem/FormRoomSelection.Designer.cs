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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.lblDatesLabel = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblNightsLabel = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.groupBoxFoodPlan = new System.Windows.Forms.GroupBox();
            this.radioNoPlan = new System.Windows.Forms.RadioButton();
            this.radioBreakfast = new System.Windows.Forms.RadioButton();
            this.radioHalfBoard = new System.Windows.Forms.RadioButton();
            this.radioFullBoard = new System.Windows.Forms.RadioButton();
            this.panelRoomDetails = new System.Windows.Forms.Panel();
            this.lblRoomDetailsTitle = new System.Windows.Forms.Label();
            this.lblRoomDetailsContent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.groupBoxFoodPlan.SuspendLayout();
            this.panelRoomDetails.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select Your Room";
            //
            // lblHotelName
            //
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHotelName.Location = new System.Drawing.Point(12, 45);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(118, 24);
            this.lblHotelName.TabIndex = 1;
            this.lblHotelName.Text = "Hotel Name";
            //
            // lblDatesLabel
            //
            this.lblDatesLabel.AutoSize = true;
            this.lblDatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatesLabel.Location = new System.Drawing.Point(12, 80);
            this.lblDatesLabel.Name = "lblDatesLabel";
            this.lblDatesLabel.Size = new System.Drawing.Size(55, 17);
            this.lblDatesLabel.TabIndex = 2;
            this.lblDatesLabel.Text = "Dates:";
            //
            // lblDates
            //
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.Location = new System.Drawing.Point(73, 80);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(124, 17);
            this.lblDates.TabIndex = 3;
            this.lblDates.Text = "MM/DD - MM/DD";
            //
            // lblNightsLabel
            //
            this.lblNightsLabel.AutoSize = true;
            this.lblNightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightsLabel.Location = new System.Drawing.Point(250, 80);
            this.lblNightsLabel.Name = "lblNightsLabel";
            this.lblNightsLabel.Size = new System.Drawing.Size(78, 17);
            this.lblNightsLabel.TabIndex = 4;
            this.lblNightsLabel.Text = "Duration:";
            //
            // lblNights
            //
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.Location = new System.Drawing.Point(334, 80);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(62, 17);
            this.lblNights.TabIndex = 5;
            this.lblNights.Text = "X nights";
            //
            // dataGridViewRooms
            //
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(12, 145);
            this.dataGridViewRooms.MultiSelect = false;
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersVisible = false;
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(500, 250);
            this.dataGridViewRooms.TabIndex = 6;
            this.dataGridViewRooms.SelectionChanged += new System.EventHandler(this.dataGridViewRooms_SelectionChanged);
            //
            // groupBoxFoodPlan
            //
            this.groupBoxFoodPlan.Controls.Add(this.radioFullBoard);
            this.groupBoxFoodPlan.Controls.Add(this.radioHalfBoard);
            this.groupBoxFoodPlan.Controls.Add(this.radioBreakfast);
            this.groupBoxFoodPlan.Controls.Add(this.radioNoPlan);
            this.groupBoxFoodPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFoodPlan.Location = new System.Drawing.Point(12, 410);
            this.groupBoxFoodPlan.Name = "groupBoxFoodPlan";
            this.groupBoxFoodPlan.Size = new System.Drawing.Size(500, 100);
            this.groupBoxFoodPlan.TabIndex = 10;
            this.groupBoxFoodPlan.TabStop = false;
            this.groupBoxFoodPlan.Text = "Select Food Plan";
            //
            // radioNoPlan
            //
            this.radioNoPlan.AutoSize = true;
            this.radioNoPlan.Checked = true;
            this.radioNoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNoPlan.Location = new System.Drawing.Point(15, 25);
            this.radioNoPlan.Name = "radioNoPlan";
            this.radioNoPlan.Size = new System.Drawing.Size(149, 19);
            this.radioNoPlan.TabIndex = 0;
            this.radioNoPlan.TabStop = true;
            this.radioNoPlan.Text = "Room Only (No Meals)";
            this.radioNoPlan.UseVisualStyleBackColor = true;
            //
            // radioBreakfast
            //
            this.radioBreakfast.AutoSize = true;
            this.radioBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBreakfast.Location = new System.Drawing.Point(15, 50);
            this.radioBreakfast.Name = "radioBreakfast";
            this.radioBreakfast.Size = new System.Drawing.Size(147, 19);
            this.radioBreakfast.TabIndex = 1;
            this.radioBreakfast.Text = "Bed and Breakfast (BB)";
            this.radioBreakfast.UseVisualStyleBackColor = true;
            //
            // radioHalfBoard
            //
            this.radioHalfBoard.AutoSize = true;
            this.radioHalfBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHalfBoard.Location = new System.Drawing.Point(260, 25);
            this.radioHalfBoard.Name = "radioHalfBoard";
            this.radioHalfBoard.Size = new System.Drawing.Size(211, 19);
            this.radioHalfBoard.TabIndex = 2;
            this.radioHalfBoard.Text = "Half Board (Breakfast + Dinner)";
            this.radioHalfBoard.UseVisualStyleBackColor = true;
            //
            // radioFullBoard
            //
            this.radioFullBoard.AutoSize = true;
            this.radioFullBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFullBoard.Location = new System.Drawing.Point(260, 50);
            this.radioFullBoard.Name = "radioFullBoard";
            this.radioFullBoard.Size = new System.Drawing.Size(192, 19);
            this.radioFullBoard.TabIndex = 3;
            this.radioFullBoard.Text = "Full Board (All Meals Included)";
            this.radioFullBoard.UseVisualStyleBackColor = true;
            //
            // panelRoomDetails
            //
            this.panelRoomDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelRoomDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRoomDetails.Controls.Add(this.lblRoomDetailsContent);
            this.panelRoomDetails.Controls.Add(this.lblRoomDetailsTitle);
            this.panelRoomDetails.Location = new System.Drawing.Point(530, 145);
            this.panelRoomDetails.Name = "panelRoomDetails";
            this.panelRoomDetails.Size = new System.Drawing.Size(258, 250);
            this.panelRoomDetails.TabIndex = 11;
            //
            // lblRoomDetailsTitle
            //
            this.lblRoomDetailsTitle.AutoSize = true;
            this.lblRoomDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDetailsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblRoomDetailsTitle.Name = "lblRoomDetailsTitle";
            this.lblRoomDetailsTitle.Size = new System.Drawing.Size(109, 18);
            this.lblRoomDetailsTitle.TabIndex = 0;
            this.lblRoomDetailsTitle.Text = "Room Details";
            //
            // lblRoomDetailsContent
            //
            this.lblRoomDetailsContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDetailsContent.Location = new System.Drawing.Point(10, 40);
            this.lblRoomDetailsContent.Name = "lblRoomDetailsContent";
            this.lblRoomDetailsContent.Size = new System.Drawing.Size(236, 200);
            this.lblRoomDetailsContent.TabIndex = 1;
            this.lblRoomDetailsContent.Text = "Select a room to view details";
            //
            // btnSelectRoom
            //
            this.btnSelectRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSelectRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRoom.ForeColor = System.Drawing.Color.White;
            this.btnSelectRoom.Location = new System.Drawing.Point(588, 465);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(200, 45);
            this.btnSelectRoom.TabIndex = 7;
            this.btnSelectRoom.Text = "Confirm Booking";
            this.btnSelectRoom.UseVisualStyleBackColor = false;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            //
            // btnCancel
            //
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(530, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "✕";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // lblInstructions
            //
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Gray;
            this.lblInstructions.Location = new System.Drawing.Point(12, 115);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(334, 15);
            this.lblInstructions.TabIndex = 9;
            this.lblInstructions.Text = "Select a room from the list below and click Confirm Booking";
            //
            // FormRoomSelection
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.panelRoomDetails);
            this.Controls.Add(this.groupBoxFoodPlan);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectRoom);
            this.Controls.Add(this.dataGridViewRooms);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.lblNightsLabel);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.lblDatesLabel);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormRoomSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room Selection - Hotel Booking System";
            this.Load += new System.EventHandler(this.FormRoomSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.groupBoxFoodPlan.ResumeLayout(false);
            this.groupBoxFoodPlan.PerformLayout();
            this.panelRoomDetails.ResumeLayout(false);
            this.panelRoomDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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