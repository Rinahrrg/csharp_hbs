namespace HotelBookingSystem
{
    partial class FormRoomSelection
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            comboBoxFloor = new ComboBox();
            lblHotelnName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpCheckin = new DateTimePicker();
            dtpCheckout = new DateTimePicker();
            label5 = new Label();
            chkBreakfast = new CheckBox();
            chkLunch = new CheckBox();
            chkDinner = new CheckBox();
            chkFullBoard = new CheckBox();
            chkNone = new CheckBox();
            label6 = new Label();
            flowLayoutPanelRooms = new FlowLayoutPanel();
            panelSummary = new Panel();
            btnConfirm = new Button();
            lblBookingCode = new Label();
            panelSummary.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "BOOKING - ";
            // 
            // comboBoxFloor
            // 
            comboBoxFloor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFloor.Font = new Font("Segoe UI", 10F);
            comboBoxFloor.FormattingEnabled = true;
            comboBoxFloor.Location = new Point(75, 52);
            comboBoxFloor.Name = "comboBoxFloor";
            comboBoxFloor.Size = new Size(120, 25);
            comboBoxFloor.TabIndex = 1;
            // 
            // lblHotelnName
            // 
            lblHotelnName.AutoSize = true;
            lblHotelnName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHotelnName.ForeColor = Color.FromArgb(0, 122, 204);
            lblHotelnName.Location = new Point(113, 9);
            lblHotelnName.Name = "lblHotelnName";
            lblHotelnName.Size = new Size(0, 21);
            lblHotelnName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(18, 55);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 3;
            label2.Text = "Floor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(220, 55);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 4;
            label3.Text = "Check-in:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(430, 55);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 5;
            label4.Text = "Check-out:";
            // 
            // dtpCheckin
            // 
            dtpCheckin.Font = new Font("Segoe UI", 10F);
            dtpCheckin.Format = DateTimePickerFormat.Short;
            dtpCheckin.Location = new Point(294, 52);
            dtpCheckin.Name = "dtpCheckin";
            dtpCheckin.Size = new Size(120, 25);
            dtpCheckin.TabIndex = 6;
            // 
            // dtpCheckout
            // 
            dtpCheckout.Font = new Font("Segoe UI", 10F);
            dtpCheckout.Format = DateTimePickerFormat.Short;
            dtpCheckout.Location = new Point(514, 52);
            dtpCheckout.Name = "dtpCheckout";
            dtpCheckout.Size = new Size(120, 25);
            dtpCheckout.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(18, 95);
            label5.Name = "label5";
            label5.Size = new Size(89, 19);
            label5.TabIndex = 8;
            label5.Text = "Food Plans:";
            // 
            // chkBreakfast
            // 
            chkBreakfast.AutoSize = true;
            chkBreakfast.Font = new Font("Segoe UI", 9F);
            chkBreakfast.Location = new Point(120, 96);
            chkBreakfast.Name = "chkBreakfast";
            chkBreakfast.Size = new Size(76, 19);
            chkBreakfast.TabIndex = 9;
            chkBreakfast.Text = "Breakfast";
            chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // chkLunch
            // 
            chkLunch.AutoSize = true;
            chkLunch.Font = new Font("Segoe UI", 9F);
            chkLunch.Location = new Point(210, 96);
            chkLunch.Name = "chkLunch";
            chkLunch.Size = new Size(58, 19);
            chkLunch.TabIndex = 10;
            chkLunch.Text = "Lunch";
            chkLunch.UseVisualStyleBackColor = true;
            // 
            // chkDinner
            // 
            chkDinner.AutoSize = true;
            chkDinner.Font = new Font("Segoe UI", 9F);
            chkDinner.Location = new Point(285, 96);
            chkDinner.Name = "chkDinner";
            chkDinner.Size = new Size(61, 19);
            chkDinner.TabIndex = 11;
            chkDinner.Text = "Dinner";
            chkDinner.UseVisualStyleBackColor = true;
            // 
            // chkFullBoard
            // 
            chkFullBoard.AutoSize = true;
            chkFullBoard.Font = new Font("Segoe UI", 9F);
            chkFullBoard.Location = new Point(360, 96);
            chkFullBoard.Name = "chkFullBoard";
            chkFullBoard.Size = new Size(80, 19);
            chkFullBoard.TabIndex = 12;
            chkFullBoard.Text = "Full Board";
            chkFullBoard.UseVisualStyleBackColor = true;
            // 
            // chkNone
            // 
            chkNone.AutoSize = true;
            chkNone.Font = new Font("Segoe UI", 9F);
            chkNone.Location = new Point(455, 96);
            chkNone.Name = "chkNone";
            chkNone.Size = new Size(54, 19);
            chkNone.TabIndex = 13;
            chkNone.Text = "None";
            chkNone.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(18, 130);
            label6.Name = "label6";
            label6.Size = new Size(130, 19);
            label6.TabIndex = 14;
            label6.Text = "Available Rooms:";
            // 
            // flowLayoutPanelRooms
            // 
            flowLayoutPanelRooms.AutoScroll = true;
            flowLayoutPanelRooms.BackColor = Color.WhiteSmoke;
            flowLayoutPanelRooms.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelRooms.Location = new Point(18, 155);
            flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            flowLayoutPanelRooms.Size = new Size(420, 380);
            flowLayoutPanelRooms.TabIndex = 15;
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.FromArgb(30, 30, 30);
            panelSummary.Controls.Add(btnConfirm);
            panelSummary.Controls.Add(lblBookingCode);
            panelSummary.Location = new Point(450, 155);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(330, 380);
            panelSummary.TabIndex = 16;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 122, 204);
            btnConfirm.Enabled = false;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(20, 320);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(290, 45);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "✓ CONFIRM BOOKING";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblBookingCode
            // 
            lblBookingCode.Font = new Font("Segoe UI", 10F);
            lblBookingCode.ForeColor = Color.White;
            lblBookingCode.Location = new Point(15, 15);
            lblBookingCode.Name = "lblBookingCode";
            lblBookingCode.Size = new Size(300, 290);
            lblBookingCode.TabIndex = 0;
            lblBookingCode.Text = "Select a room to continue...";
            // 
            // FormRoomSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 550);
            Controls.Add(panelSummary);
            Controls.Add(flowLayoutPanelRooms);
            Controls.Add(label6);
            Controls.Add(chkNone);
            Controls.Add(chkFullBoard);
            Controls.Add(chkDinner);
            Controls.Add(chkLunch);
            Controls.Add(chkBreakfast);
            Controls.Add(label5);
            Controls.Add(dtpCheckout);
            Controls.Add(dtpCheckin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblHotelnName);
            Controls.Add(comboBoxFloor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormRoomSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Room - BOOKIFY";
            panelSummary.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxFloor;
        private Label lblHotelnName;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpCheckin;
        private DateTimePicker dtpCheckout;
        private Label label5;
        private CheckBox chkBreakfast;
        private CheckBox chkLunch;
        private CheckBox chkDinner;
        private CheckBox chkFullBoard;
        private CheckBox chkNone;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanelRooms;
        private Panel panelSummary;
        private Button btnConfirm;
        private Label lblBookingCode;
    }
}