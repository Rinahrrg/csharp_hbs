namespace HotelBookingSystem
{
    partial class FormCustomerRegister
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textName = new TextBox();
            textUsername = new TextBox();
            textEmail = new TextBox();
            textPassword = new TextBox();
            btnCustomerRegister = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            textConfirmPassword = new TextBox();
            label5 = new Label();
            Close = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(198, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(384, 403);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(220, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(220, 85);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(220, 149);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 3;
            label3.Text = "E-mail:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(220, 210);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // textName
            // 
            textName.BackColor = Color.White;
            textName.ForeColor = SystemColors.ControlText;
            textName.Location = new Point(220, 44);
            textName.Name = "textName";
            textName.Size = new Size(318, 25);
            textName.TabIndex = 5;
            textName.TextChanged += textName_TextChanged;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.White;
            textUsername.ForeColor = SystemColors.ControlText;
            textUsername.Location = new Point(220, 110);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(318, 25);
            textUsername.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.White;
            textEmail.ForeColor = SystemColors.ControlText;
            textEmail.Location = new Point(220, 172);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(318, 25);
            textEmail.TabIndex = 7;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.White;
            textPassword.ForeColor = SystemColors.ControlText;
            textPassword.Location = new Point(220, 234);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(318, 25);
            textPassword.TabIndex = 8;
            // 
            // btnCustomerRegister
            // 
            btnCustomerRegister.BackColor = Color.Black;
            btnCustomerRegister.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerRegister.ForeColor = Color.White;
            btnCustomerRegister.Location = new Point(301, 366);
            btnCustomerRegister.Name = "btnCustomerRegister";
            btnCustomerRegister.Size = new Size(145, 25);
            btnCustomerRegister.TabIndex = 9;
            btnCustomerRegister.Text = "Register";
            btnCustomerRegister.UseVisualStyleBackColor = false;
            btnCustomerRegister.Click += btnRegister_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ControlText;
            checkBox1.Location = new Point(220, 331);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(146, 21);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Bookily__1__removebg_preview;
            pictureBox1.Location = new Point(30, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.BackColor = Color.White;
            textConfirmPassword.ForeColor = SystemColors.ControlText;
            textConfirmPassword.Location = new Point(220, 300);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.PasswordChar = '*';
            textConfirmPassword.Size = new Size(318, 25);
            textConfirmPassword.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(220, 271);
            label5.Name = "label5";
            label5.Size = new Size(147, 17);
            label5.TabIndex = 13;
            label5.Text = "Confirm Password:";
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.BackColor = Color.White;
            Close.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Close.Location = new Point(551, 9);
            Close.Name = "Close";
            Close.Size = new Size(19, 20);
            Close.TabIndex = 14;
            Close.Text = "X";
            Close.Click += Close_Click;
            // 
            // FormCustomerRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 403);
            Controls.Add(Close);
            Controls.Add(label5);
            Controls.Add(textConfirmPassword);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(btnCustomerRegister);
            Controls.Add(textPassword);
            Controls.Add(textEmail);
            Controls.Add(textUsername);
            Controls.Add(textName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomerRegister";
            Text = "FormCustomerRegister";
            Load += FormCustomerRegister_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textName;
        private TextBox textUsername;
        private TextBox textEmail;
        private TextBox textPassword;
        private Button btnCustomerRegister;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private TextBox textConfirmPassword;
        private Label label5;
        private Label Close;
    }
}