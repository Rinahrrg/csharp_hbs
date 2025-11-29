namespace HotelBookingSystem
{
    partial class ViewHotelControl
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
            dataGridViewHotels = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotels).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHotels
            // 
            dataGridViewHotels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHotels.Location = new Point(0, 0);
            dataGridViewHotels.Name = "dataGridViewHotels";
            dataGridViewHotels.RowHeadersWidth = 51;
            dataGridViewHotels.Size = new Size(650, 475);
            dataGridViewHotels.TabIndex = 0;
            dataGridViewHotels.CellContentClick += dataGridViewHotels_CellContentClick;
            // 
            // ViewHotelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewHotels);
            Name = "ViewHotelControl";
            Size = new Size(945, 502);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotels).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewHotels;
    }
}
