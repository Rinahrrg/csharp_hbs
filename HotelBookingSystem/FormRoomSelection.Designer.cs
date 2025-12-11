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
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 0;
            label1.Text = "BOOKING - ";
            // 
            // comboBoxFloor
            // 
            comboBoxFloor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFloor.Font = new Font("Segoe UI", 10F);
            comboBoxFloor.FormattingEnabled = true;
            comboBoxFloor.Location = new Point(86, 69);
            comboBoxFloor.Margin = new Padding(3, 4, 3, 4);
            comboBoxFloor.Name = "comboBoxFloor";
            comboBoxFloor.Size = new Size(137, 31);
            comboBoxFloor.TabIndex = 1;
            // 
            // lblHotelnName
            // 
            lblHotelnName.AutoSize = true;
            lblHotelnName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHotelnName.ForeColor = Color.FromArgb(0, 122, 204);
            lblHotelnName.Location = new Point(129, 12);
            lblHotelnName.Name = "lblHotelnName";
            lblHotelnName.Size = new Size(0, 28);
            lblHotelnName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(21, 73);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 3;
            label2.Text = "Floor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(251, 73);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 4;
            label3.Text = "Check-in:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(491, 73);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 5;
            label4.Text = "Check-out:";
            // 
            // dtpCheckin
            // 
            dtpCheckin.Font = new Font("Segoe UI", 10F);
            dtpCheckin.Format = DateTimePickerFormat.Short;
            dtpCheckin.Location = new Point(336, 69);
            dtpCheckin.Margin = new Padding(3, 4, 3, 4);
            dtpCheckin.Name = "dtpCheckin";
            dtpCheckin.Size = new Size(137, 30);
            dtpCheckin.TabIndex = 6;
            // 
            // dtpCheckout
            // 
            dtpCheckout.Font = new Font("Segoe UI", 10F);
            dtpCheckout.Format = DateTimePickerFormat.Short;
            dtpCheckout.Location = new Point(587, 69);
            dtpCheckout.Margin = new Padding(3, 4, 3, 4);
            dtpCheckout.Name = "dtpCheckout";
            dtpCheckout.Size = new Size(137, 30);
            dtpCheckout.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(21, 127);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 8;
            label5.Text = "Food Plans:";
            // 
            // chkBreakfast
            // 
            chkBreakfast.AutoSize = true;
            chkBreakfast.Font = new Font("Segoe UI", 9F);
            chkBreakfast.Location = new Point(137, 128);
            chkBreakfast.Margin = new Padding(3, 4, 3, 4);
            chkBreakfast.Name = "chkBreakfast";
            chkBreakfast.Size = new Size(92, 24);
            chkBreakfast.TabIndex = 9;
            chkBreakfast.Text = "Breakfast";
            chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // chkLunch
            // 
            chkLunch.AutoSize = true;
            chkLunch.Font = new Font("Segoe UI", 9F);
            chkLunch.Location = new Point(240, 128);
            chkLunch.Margin = new Padding(3, 4, 3, 4);
            chkLunch.Name = "chkLunch";
            chkLunch.Size = new Size(69, 24);
            chkLunch.TabIndex = 10;
            chkLunch.Text = "Lunch";
            chkLunch.UseVisualStyleBackColor = true;
            // 
            // chkDinner
            // 
            chkDinner.AutoSize = true;
            chkDinner.Font = new Font("Segoe UI", 9F);
            chkDinner.Location = new Point(326, 128);
            chkDinner.Margin = new Padding(3, 4, 3, 4);
            chkDinner.Name = "chkDinner";
            chkDinner.Size = new Size(75, 24);
            chkDinner.TabIndex = 11;
            chkDinner.Text = "Dinner";
            chkDinner.UseVisualStyleBackColor = true;
            chkDinner.CheckedChanged += chkDinner_CheckedChanged;
            // 
            // chkFullBoard
            // 
            chkFullBoard.AutoSize = true;
            chkFullBoard.Font = new Font("Segoe UI", 9F);
            chkFullBoard.Location = new Point(411, 128);
            chkFullBoard.Margin = new Padding(3, 4, 3, 4);
            chkFullBoard.Name = "chkFullBoard";
            chkFullBoard.Size = new Size(98, 24);
            chkFullBoard.TabIndex = 12;
            chkFullBoard.Text = "Full Board";
            chkFullBoard.UseVisualStyleBackColor = true;
            // 
            // chkNone
            // 
            chkNone.AutoSize = true;
            chkNone.Font = new Font("Segoe UI", 9F);
            chkNone.Location = new Point(520, 128);
            chkNone.Margin = new Padding(3, 4, 3, 4);
            chkNone.Name = "chkNone";
            chkNone.Size = new Size(67, 24);
            chkNone.TabIndex = 13;
            chkNone.Text = "None";
            chkNone.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(21, 173);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 14;
            label6.Text = "Available Rooms:";
            // 
            // flowLayoutPanelRooms
            // 
            flowLayoutPanelRooms.AutoScroll = true;
            flowLayoutPanelRooms.BackColor = Color.WhiteSmoke;
            flowLayoutPanelRooms.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelRooms.Location = new Point(21, 207);
            flowLayoutPanelRooms.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            flowLayoutPanelRooms.Size = new Size(480, 506);
            flowLayoutPanelRooms.TabIndex = 15;
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.FromArgb(30, 30, 30);
            panelSummary.Controls.Add(btnConfirm);
            panelSummary.Controls.Add(lblBookingCode);
            panelSummary.Location = new Point(514, 207);
            panelSummary.Margin = new Padding(3, 4, 3, 4);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(377, 507);
            panelSummary.TabIndex = 16;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 122, 204);
            btnConfirm.Enabled = false;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(23, 427);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(331, 60);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "✓ CONFIRM BOOKING";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblBookingCode
            // 
            lblBookingCode.Font = new Font("Segoe UI", 10F);
            lblBookingCode.ForeColor = Color.White;
            lblBookingCode.Location = new Point(17, 20);
            lblBookingCode.Name = "lblBookingCode";
            lblBookingCode.Size = new Size(343, 387);
            lblBookingCode.TabIndex = 0;
            lblBookingCode.Text = "Select a room to continue...";
            // 
            // FormRoomSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 733);
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
            Margin = new Padding(3, 4, 3, 4);
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