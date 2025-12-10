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
            btnBook = new Button();
            pictureBox1 = new PictureBox();
            lblPrice = new Label();
            lblAssets = new Label();
            lblRoomInfo = new Label();
            lblBookingCode = new Label();
            btnConfirm = new Button();
            flowLayoutPanelRooms.SuspendLayout();
            panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 0;
            label1.Text = "BOOKING - ";
            // 
            // comboBoxFloor
            // 
            comboBoxFloor.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFloor.FormattingEnabled = true;
            comboBoxFloor.Location = new Point(75, 52);
            comboBoxFloor.Name = "comboBoxFloor";
            comboBoxFloor.Size = new Size(81, 25);
            comboBoxFloor.TabIndex = 1;
            // 
            // lblHotelnName
            // 
            lblHotelnName.AutoSize = true;
            lblHotelnName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHotelnName.Location = new Point(113, 9);
            lblHotelnName.Name = "lblHotelnName";
            lblHotelnName.Size = new Size(0, 17);
            lblHotelnName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 60);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 3;
            label2.Text = "Floor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 115);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 4;
            label3.Text = "Check-in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(250, 115);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 5;
            label4.Text = "Check-out";
            // 
            // dtpCheckin
            // 
            dtpCheckin.CalendarFont = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckin.Location = new Point(105, 108);
            dtpCheckin.Name = "dtpCheckin";
            dtpCheckin.Size = new Size(108, 27);
            dtpCheckin.TabIndex = 6;
            // 
            // dtpCheckout
            // 
            dtpCheckout.CalendarFont = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckout.Location = new Point(339, 108);
            dtpCheckout.Name = "dtpCheckout";
            dtpCheckout.Size = new Size(108, 27);
            dtpCheckout.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 166);
            label5.Name = "label5";
            label5.Size = new Size(93, 17);
            label5.TabIndex = 8;
            label5.Text = "Food Plans:";
            // 
            // chkBreakfast
            // 
            chkBreakfast.AutoSize = true;
            chkBreakfast.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBreakfast.Location = new Point(23, 208);
            chkBreakfast.Name = "chkBreakfast";
            chkBreakfast.Size = new Size(102, 21);
            chkBreakfast.TabIndex = 9;
            chkBreakfast.Text = "Breakfast";
            chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // chkLunch
            // 
            chkLunch.AutoSize = true;
            chkLunch.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLunch.Location = new Point(152, 208);
            chkLunch.Name = "chkLunch";
            chkLunch.Size = new Size(75, 21);
            chkLunch.TabIndex = 10;
            chkLunch.Text = "Lunch";
            chkLunch.UseVisualStyleBackColor = true;
            chkLunch.CheckedChanged += chkLunch_CheckedChanged;
            // 
            // chkDinner
            // 
            chkDinner.AutoSize = true;
            chkDinner.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDinner.Location = new Point(254, 208);
            chkDinner.Name = "chkDinner";
            chkDinner.Size = new Size(79, 21);
            chkDinner.TabIndex = 11;
            chkDinner.Text = "Dinner";
            chkDinner.UseVisualStyleBackColor = true;
            // 
            // chkFullBoard
            // 
            chkFullBoard.AutoSize = true;
            chkFullBoard.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFullBoard.Location = new Point(371, 208);
            chkFullBoard.Name = "chkFullBoard";
            chkFullBoard.Size = new Size(105, 21);
            chkFullBoard.TabIndex = 12;
            chkFullBoard.Text = "Full Board";
            chkFullBoard.UseVisualStyleBackColor = true;
            // 
            // chkNone
            // 
            chkNone.AutoSize = true;
            chkNone.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkNone.Location = new Point(504, 208);
            chkNone.Name = "chkNone";
            chkNone.Size = new Size(68, 21);
            chkNone.TabIndex = 13;
            chkNone.Text = "None";
            chkNone.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 255);
            label6.Name = "label6";
            label6.Size = new Size(158, 17);
            label6.TabIndex = 14;
            label6.Text = "Available Rooms for ";
            // 
            // flowLayoutPanelRooms
            // 
            flowLayoutPanelRooms.Controls.Add(pictureBox1);
            flowLayoutPanelRooms.Controls.Add(lblRoomInfo);
            flowLayoutPanelRooms.Controls.Add(lblAssets);
            flowLayoutPanelRooms.Controls.Add(lblPrice);
            flowLayoutPanelRooms.Controls.Add(btnBook);
            flowLayoutPanelRooms.Location = new Point(23, 294);
            flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            flowLayoutPanelRooms.Size = new Size(218, 223);
            flowLayoutPanelRooms.TabIndex = 15;
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.Black;
            panelSummary.Controls.Add(btnConfirm);
            panelSummary.Controls.Add(lblBookingCode);
            panelSummary.ForeColor = Color.White;
            panelSummary.Location = new Point(-1, 552);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(803, 213);
            panelSummary.TabIndex = 16;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Black;
            btnBook.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(3, 175);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(94, 29);
            btnBook.TabIndex = 0;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 149);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(101, 155);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 17);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "label";
            // 
            // lblAssets
            // 
            lblAssets.AutoSize = true;
            lblAssets.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssets.Location = new Point(52, 155);
            lblAssets.Name = "lblAssets";
            lblAssets.Size = new Size(43, 17);
            lblAssets.TabIndex = 18;
            lblAssets.Text = "label";
            // 
            // lblRoomInfo
            // 
            lblRoomInfo.AutoSize = true;
            lblRoomInfo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomInfo.Location = new Point(3, 155);
            lblRoomInfo.Name = "lblRoomInfo";
            lblRoomInfo.Size = new Size(43, 17);
            lblRoomInfo.TabIndex = 19;
            lblRoomInfo.Text = "label";
            // 
            // lblBookingCode
            // 
            lblBookingCode.AutoSize = true;
            lblBookingCode.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingCode.Location = new Point(13, 22);
            lblBookingCode.Name = "lblBookingCode";
            lblBookingCode.Size = new Size(51, 17);
            lblBookingCode.TabIndex = 0;
            lblBookingCode.Text = "Code:";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Location = new Point(18, 171);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // FormRoomSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 764);
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
            Name = "FormRoomSelection";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "FormRoomSelection";
            flowLayoutPanelRooms.ResumeLayout(false);
            flowLayoutPanelRooms.PerformLayout();
            panelSummary.ResumeLayout(false);
            panelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnBook;
        private PictureBox pictureBox1;
        private Label lblRoomInfo;
        private Label lblAssets;
        private Label lblPrice;
        private Button btnConfirm;
        private Label lblBookingCode;
    }
}