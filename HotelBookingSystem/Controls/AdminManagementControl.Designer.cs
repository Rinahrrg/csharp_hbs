namespace HotelBookingSystem
{
    partial class AdminManagementControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            checkBoxShowPassword = new CheckBox();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnRefresh = new Button();
            dataGridViewAdmins = new DataGridView();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmins).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(checkBoxShowPassword);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(dataGridViewAdmins);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 642);
            panel1.TabIndex = 14;
//            panel1.Paint += this.panel1_Paint;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxShowPassword.ForeColor = Color.White;
            checkBoxShowPassword.Location = new Point(160, 210);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(146, 21);
            checkBoxShowPassword.TabIndex = 41;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(186, 160);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(280, 27);
            txtConfirmPassword.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 170);
            label3.Name = "label3";
            label3.Size = new Size(147, 17);
            label3.TabIndex = 39;
            label3.Text = "Confirm Password:";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(550, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(290, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(160, 270);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 35);
            btnEdit.TabIndex = 36;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(30, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Add Admin";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(420, 270);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdmins
            // 
            dataGridViewAdmins.BackgroundColor = Color.White;
            dataGridViewAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdmins.GridColor = Color.White;
            dataGridViewAdmins.Location = new Point(18, 330);
            dataGridViewAdmins.Name = "dataGridViewAdmins";
            dataGridViewAdmins.RowHeadersWidth = 51;
            dataGridViewAdmins.Size = new Size(769, 294);
            dataGridViewAdmins.TabIndex = 35;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(186, 115);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(280, 27);
            txtPassword.TabIndex = 32;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(186, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 27);
            txtUsername.TabIndex = 31;
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 27);
            txtName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 125);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 13;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // AdminManagementControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "AdminManagementControl";
            Size = new Size(821, 693);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmins).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnRefresh;
        private DataGridView dataGridViewAdmins;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtName;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtConfirmPassword;
        private CheckBox checkBoxShowPassword;
    }
}
