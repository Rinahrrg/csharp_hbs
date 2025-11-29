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
            ((System.ComponentModel.ISupportInitialize)dataGridRoles).BeginInit();
            SuspendLayout();
            // 
            // dataGridRoles
            // 
            dataGridRoles.BackgroundColor = Color.Azure;
            dataGridRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRoles.Location = new Point(215, 72);
            dataGridRoles.Name = "dataGridRoles";
            dataGridRoles.RowHeadersWidth = 51;
            dataGridRoles.Size = new Size(382, 252);
            dataGridRoles.TabIndex = 0;
            dataGridRoles.CellContentClick += dataGridRoles_CellContentClick;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.MintCream;
            btnCustomer.Location = new Point(340, 178);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(123, 29);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Linen;
            btnAdmin.Location = new Point(340, 236);
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
            label1.BackColor = Color.Azure;
            label1.Location = new Point(349, 131);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "What are you?";
            // 
            // FormChooseRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            Controls.Add(btnCustomer);
            Controls.Add(dataGridRoles);
            Name = "FormChooseRole";
            Text = "FormChooseRole";
            ((System.ComponentModel.ISupportInitialize)dataGridRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridRoles;
        private Button btnCustomer;
        private Button btnAdmin;
        private Label label1;
    }
}