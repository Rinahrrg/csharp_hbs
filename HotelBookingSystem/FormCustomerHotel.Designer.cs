namespace HotelBookingSystem
{
    partial class FormCustomerHotel
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
            btnCustomerLogin = new Button();
            btnCustomerRegister = new Button();
            textBox1 = new TextBox();
            textPassword = new TextBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
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
            dataGridView1.Location = new Point(208, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(374, 403);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(252, 122);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(252, 204);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.BackColor = SystemColors.ControlText;
            btnCustomerLogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerLogin.ForeColor = Color.White;
            btnCustomerLogin.Location = new Point(299, 331);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new Size(150, 29);
            btnCustomerLogin.TabIndex = 3;
            btnCustomerLogin.Text = "Login";
            btnCustomerLogin.UseVisualStyleBackColor = false;
            btnCustomerLogin.Click += btnCustomerLogin_Click;
            // 
            // btnCustomerRegister
            // 
            btnCustomerRegister.BackColor = Color.White;
            btnCustomerRegister.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerRegister.ForeColor = SystemColors.ControlText;
            btnCustomerRegister.Location = new Point(30, 331);
            btnCustomerRegister.Name = "btnCustomerRegister";
            btnCustomerRegister.Size = new Size(150, 29);
            btnCustomerRegister.TabIndex = 4;
            btnCustomerRegister.Text = "Register";
            btnCustomerRegister.UseVisualStyleBackColor = false;
            btnCustomerRegister.Click += btnCustomerRegister_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 5;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(252, 234);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(257, 27);
            textPassword.TabIndex = 6;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Bookily__1__removebg_preview;
            pictureBox1.Location = new Point(30, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ControlText;
            checkBox1.Location = new Point(252, 278);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.BackColor = Color.White;
            Close.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Close.ForeColor = SystemColors.ControlText;
            Close.Location = new Point(551, 9);
            Close.Name = "Close";
            Close.Size = new Size(19, 20);
            Close.TabIndex = 11;
            Close.Text = "X";
            Close.Click += Close_Click;
            // 
            // FormCustomerHotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 403);
            Controls.Add(Close);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textPassword);
            Controls.Add(textBox1);
            Controls.Add(btnCustomerRegister);
            Controls.Add(btnCustomerLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomerHotel";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button btnCustomerLogin;
        private Button btnCustomerRegister;
        private TextBox textBox1;
        private TextBox textPassword;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Label Close;
    }
}