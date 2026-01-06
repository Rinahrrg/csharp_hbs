namespace HotelBookingSystem
{
    partial class AssetsControl
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
            panel1 = new Panel();
            btnDeleteAsset = new Button();
            btnUpdateAsset = new Button();
            btnEditAsset = new Button();
            dataGridViewAssets = new DataGridView();
            comboBoxStatus = new ComboBox();
            comboBoxAssetType = new ComboBox();
            txtDescription = new TextBox();
            txtAssetName = new TextBox();
            txtBrand = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRefresh = new Button();
            label3 = new Label();
            btnAddAsset = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssets).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnDeleteAsset);
            panel1.Controls.Add(btnUpdateAsset);
            panel1.Controls.Add(btnEditAsset);
            panel1.Controls.Add(dataGridViewAssets);
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(comboBoxAssetType);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(txtAssetName);
            panel1.Controls.Add(txtBrand);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAddAsset);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 642);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // btnDeleteAsset
            // 
            btnDeleteAsset.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteAsset.Location = new Point(625, 313);
            btnDeleteAsset.Name = "btnDeleteAsset";
            btnDeleteAsset.Size = new Size(94, 29);
            btnDeleteAsset.TabIndex = 38;
            btnDeleteAsset.Text = "Delete";
            btnDeleteAsset.UseVisualStyleBackColor = true;
            btnDeleteAsset.Click += btnDeleteAsset_Click;
            // 
            // btnUpdateAsset
            // 
            btnUpdateAsset.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateAsset.Location = new Point(336, 313);
            btnUpdateAsset.Name = "btnUpdateAsset";
            btnUpdateAsset.Size = new Size(94, 29);
            btnUpdateAsset.TabIndex = 37;
            btnUpdateAsset.Text = "Update";
            btnUpdateAsset.UseVisualStyleBackColor = true;
            btnUpdateAsset.Click += btnUpdateAsset_Click;
            // 
            // btnEditAsset
            // 
            btnEditAsset.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditAsset.Location = new Point(193, 313);
            btnEditAsset.Name = "btnEditAsset";
            btnEditAsset.Size = new Size(94, 29);
            btnEditAsset.TabIndex = 36;
            btnEditAsset.Text = "Edit";
            btnEditAsset.UseVisualStyleBackColor = true;
            btnEditAsset.Click += btnEditAsset_Click;
            // 
            // dataGridViewAssets
            // 
            dataGridViewAssets.BackgroundColor = Color.White;
            dataGridViewAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssets.GridColor = Color.White;
            dataGridViewAssets.Location = new Point(18, 364);
            dataGridViewAssets.Name = "dataGridViewAssets";
            dataGridViewAssets.RowHeadersWidth = 51;
            dataGridViewAssets.Size = new Size(769, 260);
            dataGridViewAssets.TabIndex = 35;
            dataGridViewAssets.CellContentClick += dataGridViewAssets_CellContentClick;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(191, 206);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(239, 28);
            comboBoxStatus.TabIndex = 34;
            // 
            // comboBoxAssetType
            // 
            comboBoxAssetType.FormattingEnabled = true;
            comboBoxAssetType.Location = new Point(191, 167);
            comboBoxAssetType.Name = "comboBoxAssetType";
            comboBoxAssetType.Size = new Size(239, 28);
            comboBoxAssetType.TabIndex = 33;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(192, 89);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(238, 27);
            txtDescription.TabIndex = 32;
            // 
            // txtAssetName
            // 
            txtAssetName.Location = new Point(193, 47);
            txtAssetName.Name = "txtAssetName";
            txtAssetName.Size = new Size(237, 27);
            txtAssetName.TabIndex = 31;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(191, 129);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(239, 27);
            txtBrand.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(67, 217);
            label8.Name = "label8";
            label8.Size = new Size(59, 17);
            label8.TabIndex = 18;
            label8.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 178);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 14;
            label4.Text = "Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(68, 139);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 13;
            label2.Text = "Brand:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 58);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 1;
            label1.Text = "Asset Name:";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(485, 313);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 99);
            label3.Name = "label3";
            label3.Size = new Size(97, 17);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // btnAddAsset
            // 
            btnAddAsset.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAsset.Location = new Point(67, 313);
            btnAddAsset.Name = "btnAddAsset";
            btnAddAsset.Size = new Size(94, 29);
            btnAddAsset.TabIndex = 5;
            btnAddAsset.Text = "Add ";
            btnAddAsset.UseVisualStyleBackColor = true;
            btnAddAsset.Click += btnAddAsset_Click;
            // 
            // AssetsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "AssetsControl";
            Size = new Size(821, 693);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown numericUpDownBeds;
        private ComboBox comboBoxCategory;
        private TextBox txtBrand;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewRooms;
        private Button btnEditRoom;
        private Button btnRefresh;
        private Button btnDeleteRoom;
        private Button btnUpdateRoom;
        private Label label3;
        private Button btnAddAsset;
        private TextBox txtDescription;
        private TextBox txtAssetName;
        private ComboBox comboBoxAssetType;
        private ComboBox comboBoxStatus;
        private DataGridView dataGridViewAssets;
        private Button btnDeleteAsset;
        private Button btnUpdateAsset;
        private Button btnEditAsset;
    }
}
