
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
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(302, 320);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(255, 110);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(258, 201);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(252, 151);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(257, 27);
            textUsername.TabIndex = 4;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(255, 233);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(257, 27);
            textPassword.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(252, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Bookily__1__removebg_preview;
            pictureBox1.Location = new Point(31, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.BackColor = Color.White;
            Close.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Close.Location = new Point(551, 9);
            Close.Name = "Close";
            Close.Size = new Size(19, 20);
            Close.TabIndex = 9;
            Close.Text = "X";
            Close.Click += Close_Click;
            // 
            // FormAdminHotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 403);
            Controls.Add(Close);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdminHotel";
            Text = "Form2";
            Load += FormAdminHotel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox textUsername;
        private TextBox textPassword;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Label Close;
    }
}