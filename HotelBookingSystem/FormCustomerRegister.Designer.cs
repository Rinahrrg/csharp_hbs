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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(130, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(546, 276);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 97);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 186);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 97);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "E-mail";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 186);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // textName
            // 
            textName.Location = new Point(239, 140);
            textName.Name = "textName";
            textName.Size = new Size(125, 27);
            textName.TabIndex = 5;
            textName.TextChanged += textName_TextChanged;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(240, 230);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(125, 27);
            textUsername.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(446, 142);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(125, 27);
            textEmail.TabIndex = 7;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(439, 231);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(125, 27);
            textPassword.TabIndex = 8;
            // 
            // btnCustomerRegister
            // 
            btnCustomerRegister.BackColor = Color.SeaShell;
            btnCustomerRegister.Location = new Point(356, 290);
            btnCustomerRegister.Name = "btnCustomerRegister";
            btnCustomerRegister.Size = new Size(94, 29);
            btnCustomerRegister.TabIndex = 9;
            btnCustomerRegister.Text = "Register";
            btnCustomerRegister.UseVisualStyleBackColor = false;
            btnCustomerRegister.Click += btnCustomerRegister_Click;
            // 
            // FormCustomerRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormCustomerRegister";
            Text = "FormCustomerRegister";
            Load += FormCustomerRegister_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}