namespace HotelBookingSystem
{
    partial class FormChooseRole
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
            dataGridRoles = new DataGridView();
            btnCustomer = new Button();
            btnAdmin = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridRoles
            // 
            dataGridRoles.BackgroundColor = Color.White;
            dataGridRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRoles.Dock = DockStyle.Right;
            dataGridRoles.Location = new Point(296, 0);
            dataGridRoles.Name = "dataGridRoles";
            dataGridRoles.RowHeadersWidth = 51;
            dataGridRoles.Size = new Size(304, 450);
            dataGridRoles.TabIndex = 0;
            dataGridRoles.CellContentClick += dataGridRoles_CellContentClick;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.White;
            btnCustomer.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.Black;
            btnCustomer.Location = new Point(69, 292);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(123, 29);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.ControlText;
            btnAdmin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(374, 292);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(123, 29);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Administrator";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 112);
            label1.Name = "label1";
            label1.Size = new Size(188, 27);
            label1.TabIndex = 3;
            label1.Text = "Welcome Back!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(324, 198);
            label2.Name = "label2";
            label2.Size = new Size(203, 27);
            label2.TabIndex = 4;
            label2.Text = "Choose your role";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bookily__1__removebg_preview;
            pictureBox1.Location = new Point(42, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(385, 157);
            label3.Name = "label3";
            label3.Size = new Size(94, 27);
            label3.TabIndex = 6;
            label3.Text = "Please,";
            // 
            // FormChooseRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(600, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            Controls.Add(btnCustomer);
            Controls.Add(dataGridRoles);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChooseRole";
            Text = "FormChooseRole";
            ((System.ComponentModel.ISupportInitialize)dataGridRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridRoles;
        private Button btnCustomer;
        private Button btnAdmin;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}