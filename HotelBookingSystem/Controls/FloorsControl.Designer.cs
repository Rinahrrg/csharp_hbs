namespace HotelBookingSystem
{
    partial class FloorsControl
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
            dataGridViewFloors = new DataGridView();
            label1 = new Label();
            comboBoxHotel = new ComboBox();
            label3 = new Label();
            btnAddFloor = new Button();
            btnUpdateFloor = new Button();
            btnDeleteFloor = new Button();
            btnRefreshFloor = new Button();
            numericUpDownMaxRooms = new NumericUpDown();
            btnEditFloor = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFloors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxRooms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewFloors
            // 
            dataGridViewFloors.BackgroundColor = Color.White;
            dataGridViewFloors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFloors.Location = new Point(37, 225);
            dataGridViewFloors.Name = "dataGridViewFloors";
            dataGridViewFloors.RowHeadersWidth = 51;
            dataGridViewFloors.Size = new Size(740, 374);
            dataGridViewFloors.TabIndex = 0;
            dataGridViewFloors.CellContentClick += dataGridViewFloors_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 58);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 1;
            label1.Text = "Hotel:";
            // 
            // comboBoxHotel
            // 
            comboBoxHotel.FormattingEnabled = true;
            comboBoxHotel.Location = new Point(180, 47);
            comboBoxHotel.Name = "comboBoxHotel";
            comboBoxHotel.Size = new Size(240, 28);
            comboBoxHotel.TabIndex = 2;
            comboBoxHotel.Click += comboBoxHotel_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 115);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 4;
            label3.Text = "Max Rooms:";
            // 
            // btnAddFloor
            // 
            btnAddFloor.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddFloor.Location = new Point(67, 181);
            btnAddFloor.Name = "btnAddFloor";
            btnAddFloor.Size = new Size(94, 29);
            btnAddFloor.TabIndex = 5;
            btnAddFloor.Text = "Add ";
            btnAddFloor.UseVisualStyleBackColor = true;
            btnAddFloor.Click += btnAddFloor_Click;
            // 
            // btnUpdateFloor
            // 
            btnUpdateFloor.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateFloor.Location = new Point(346, 181);
            btnUpdateFloor.Name = "btnUpdateFloor";
            btnUpdateFloor.Size = new Size(94, 29);
            btnUpdateFloor.TabIndex = 6;
            btnUpdateFloor.Text = "Update ";
            btnUpdateFloor.UseVisualStyleBackColor = true;
            btnUpdateFloor.Click += btnUpdateFloor_Click;
            // 
            // btnDeleteFloor
            // 
            btnDeleteFloor.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteFloor.Location = new Point(493, 181);
            btnDeleteFloor.Name = "btnDeleteFloor";
            btnDeleteFloor.Size = new Size(94, 29);
            btnDeleteFloor.TabIndex = 7;
            btnDeleteFloor.Text = "Delete";
            btnDeleteFloor.UseVisualStyleBackColor = true;
            btnDeleteFloor.Click += btnDeleteFloor_Click;
            // 
            // btnRefreshFloor
            // 
            btnRefreshFloor.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshFloor.Location = new Point(645, 181);
            btnRefreshFloor.Name = "btnRefreshFloor";
            btnRefreshFloor.Size = new Size(94, 29);
            btnRefreshFloor.TabIndex = 8;
            btnRefreshFloor.Text = "Refresh";
            btnRefreshFloor.UseVisualStyleBackColor = true;
            btnRefreshFloor.Click += btnRefresh_Click;
            // 
            // numericUpDownMaxRooms
            // 
            numericUpDownMaxRooms.Location = new Point(180, 105);
            numericUpDownMaxRooms.Name = "numericUpDownMaxRooms";
            numericUpDownMaxRooms.Size = new Size(99, 27);
            numericUpDownMaxRooms.TabIndex = 10;
            // 
            // btnEditFloor
            // 
            btnEditFloor.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditFloor.Location = new Point(208, 181);
            btnEditFloor.Name = "btnEditFloor";
            btnEditFloor.Size = new Size(94, 29);
            btnEditFloor.TabIndex = 11;
            btnEditFloor.Text = "Edit";
            btnEditFloor.UseVisualStyleBackColor = true;
            btnEditFloor.Click += btnEditFloor_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridViewFloors);
            panel1.Controls.Add(btnEditFloor);
            panel1.Controls.Add(numericUpDownMaxRooms);
            panel1.Controls.Add(btnRefreshFloor);
            panel1.Controls.Add(btnDeleteFloor);
            panel1.Controls.Add(comboBoxHotel);
            panel1.Controls.Add(btnUpdateFloor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAddFloor);
            panel1.Location = new Point(3, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 627);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // FloorsControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "FloorsControl";
            Size = new Size(821, 693);
            Load += FloorsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFloors).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxRooms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFloors;
        private Label label1;
        private ComboBox comboBoxHotel;
        private Label label3;
        private Button btnAddFloor;
        private Button btnUpdateFloor;
        private Button btnDeleteFloor;
        private Button btnRefreshFloor;
        private NumericUpDown numericUpDownMaxRooms;
        private Button btnEditFloor;
        private Panel panel1;
    }
}
