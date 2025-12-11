namespace HotelBookingSystem
{
    partial class FoodOrdersControl
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
            btnSearch = new Button();
            dataGridViewFoodOrders = new DataGridView();
            txtSearchCode = new TextBox();
            label1 = new Label();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoodOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(dataGridViewFoodOrders);
            panel1.Controls.Add(txtSearchCode);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRefresh);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 642);
            panel1.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(513, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // dataGridViewFoodOrders
            // 
            dataGridViewFoodOrders.BackgroundColor = Color.White;
            dataGridViewFoodOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFoodOrders.GridColor = Color.White;
            dataGridViewFoodOrders.Location = new Point(20, 147);
            dataGridViewFoodOrders.Name = "dataGridViewFoodOrders";
            dataGridViewFoodOrders.RowHeadersWidth = 51;
            dataGridViewFoodOrders.Size = new Size(769, 381);
            dataGridViewFoodOrders.TabIndex = 35;
            // 
            // txtSearchCode
            // 
            txtSearchCode.Location = new Point(240, 31);
            txtSearchCode.Name = "txtSearchCode";
            txtSearchCode.Size = new Size(237, 27);
            txtSearchCode.TabIndex = 31;
            txtSearchCode.TextChanged += txtSearchCode_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 41);
            label1.Name = "label1";
            label1.Size = new Size(195, 17);
            label1.TabIndex = 1;
            label1.Text = "Search By Booking Code:";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(39, 93);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh All Bookings";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // FoodOrdersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "FoodOrdersControl";
            Size = new Size(821, 693);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoodOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSearch;
        private DataGridView dataGridViewFoodOrders;
        private TextBox txtSearchCode;
        private Label label1;
        private Button btnRefresh;
    }
}
