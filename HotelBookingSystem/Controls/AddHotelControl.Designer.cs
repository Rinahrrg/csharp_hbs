namespace HotelBookingSystem
{
    partial class AddHotelControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtAddress = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            numericUpDownFloors = new NumericUpDown();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnEdit = new Button();
            bynClear = new Button();
            btnAdd = new Button();
            btnBrowse = new Button();
            pictureBox1 = new PictureBox();
            dataGridViewHotels = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotels).BeginInit();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAddress.Location = new Point(129, 60);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(474, 27);
            txtAddress.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(493, 383);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 25);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 65);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 5;
            label2.Text = "Address";
            label2.Click += label2_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Location = new Point(129, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(473, 27);
            txtName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 20);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 10;
            label4.Text = "Floors:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 111);
            label5.Name = "label5";
            label5.Size = new Size(168, 17);
            label5.TabIndex = 11;
            label5.Text = "Default Booking Time:";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(numericUpDownFloors);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(bynClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnBrowse);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dataGridViewHotels);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 687);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // numericUpDownFloors
            // 
            numericUpDownFloors.Location = new Point(239, 101);
            numericUpDownFloors.Name = "numericUpDownFloors";
            numericUpDownFloors.Size = new Size(112, 27);
            numericUpDownFloors.TabIndex = 19;
            numericUpDownFloors.ValueChanged += numericUpDownFloors_ValueChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(336, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete Hotel";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDeleteHotel_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(650, 383);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 29);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(179, 383);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 29);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit Hotel";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEditHotel_Click;
            // 
            // bynClear
            // 
            bynClear.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bynClear.Location = new Point(412, 251);
            bynClear.Name = "bynClear";
            bynClear.Size = new Size(163, 29);
            bynClear.TabIndex = 17;
            bynClear.Text = "Clear Photo";
            bynClear.UseVisualStyleBackColor = true;
            bynClear.Click += btnClearPhoto_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(24, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add Hotel";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAddHotel_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(409, 195);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(166, 29);
            btnBrowse.TabIndex = 16;
            btnBrowse.Text = "Browse Photo";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowsePhoto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(161, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // dataGridViewHotels
            // 
            dataGridViewHotels.BackgroundColor = Color.White;
            dataGridViewHotels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHotels.Location = new Point(24, 427);
            dataGridViewHotels.Name = "dataGridViewHotels";
            dataGridViewHotels.RowHeadersWidth = 51;
            dataGridViewHotels.Size = new Size(766, 239);
            dataGridViewHotels.TabIndex = 14;
            dataGridViewHotels.CellContentClick += dataGridViewHotels_CellContentClick;
            // 
            // AddHotelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "AddHotelControl";
            Size = new Size(821, 693);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotels).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtAddress;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridViewHotels;
        private PictureBox pictureBox1;
        private Button bynClear;
        private Button btnBrowse;
        private Button btnRefresh;
        private NumericUpDown numericUpDownFloors;
    }
}
