namespace HotelBookingSystem
{
    partial class FormAdminHotel
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
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            btnAdminRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(187, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(399, 247);
            dataGridView1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SeaShell;
            btnLogin.Location = new Point(345, 305);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Location = new Point(345, 98);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Location = new Point(350, 180);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(325, 132);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(125, 27);
            textUsername.TabIndex = 4;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(325, 214);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(125, 27);
            textPassword.TabIndex = 5;
            // 
            // btnAdminRegister
            // 
            btnAdminRegister.BackColor = Color.SeaShell;
            btnAdminRegister.Location = new Point(345, 349);
            btnAdminRegister.Name = "btnAdminRegister";
            btnAdminRegister.Size = new Size(94, 29);
            btnAdminRegister.TabIndex = 6;
            btnAdminRegister.Text = "Register";
            btnAdminRegister.UseVisualStyleBackColor = false;
            btnAdminRegister.Click += btnAdminRegister_Click;
            // 
            // FormAdminHotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdminRegister);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(dataGridView1);
            Name = "FormAdminHotel";
            Text = "Form2";
            Load += FormAdminHotel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button btnAdminRegister;
    }
}