namespace PPAI_CU_24.Interfaces
{
    partial class PantallaVisualizacionVinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaVisualizacionVinos));
            dgvVinos = new DataGridView();
            NombreVino = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Varietales = new DataGridViewTextBoxColumn();
            Calificacion = new DataGridViewTextBoxColumn();
            NombreBodega = new DataGridViewTextBoxColumn();
            NombreRegion = new DataGridViewTextBoxColumn();
            NombrePais = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVinos).BeginInit();
            SuspendLayout();
            // 
            // dgvVinos
            // 
            dgvVinos.AllowUserToAddRows = false;
            dgvVinos.AllowUserToDeleteRows = false;
            dgvVinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVinos.Columns.AddRange(new DataGridViewColumn[] { NombreVino, Precio, Varietales, Calificacion, NombreBodega, NombreRegion, NombrePais });
            dgvVinos.Dock = DockStyle.Fill;
            dgvVinos.Location = new Point(0, 0);
            dgvVinos.Name = "dgvVinos";
            dgvVinos.ReadOnly = true;
            dgvVinos.RowHeadersWidth = 82;
            dgvVinos.Size = new Size(1984, 1015);
            dgvVinos.TabIndex = 0;
            // 
            // NombreVino
            // 
            NombreVino.HeaderText = "Nombre Vino";
            NombreVino.MinimumWidth = 10;
            NombreVino.Name = "NombreVino";
            NombreVino.ReadOnly = true;
            NombreVino.Width = 400;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 10;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 200;
            // 
            // Varietales
            // 
            Varietales.HeaderText = "Varietales";
            Varietales.MinimumWidth = 10;
            Varietales.Name = "Varietales";
            Varietales.ReadOnly = true;
            Varietales.Width = 350;
            // 
            // Calificacion
            // 
            Calificacion.HeaderText = "Calificacion";
            Calificacion.MinimumWidth = 10;
            Calificacion.Name = "Calificacion";
            Calificacion.ReadOnly = true;
            Calificacion.Width = 200;
            // 
            // NombreBodega
            // 
            NombreBodega.HeaderText = "Nombre Bodega";
            NombreBodega.MinimumWidth = 10;
            NombreBodega.Name = "NombreBodega";
            NombreBodega.ReadOnly = true;
            NombreBodega.Width = 250;
            // 
            // NombreRegion
            // 
            NombreRegion.HeaderText = "Region";
            NombreRegion.MinimumWidth = 10;
            NombreRegion.Name = "NombreRegion";
            NombreRegion.ReadOnly = true;
            NombreRegion.Width = 300;
            // 
            // NombrePais
            // 
            NombrePais.HeaderText = "Pais";
            NombrePais.MinimumWidth = 10;
            NombrePais.Name = "NombrePais";
            NombrePais.ReadOnly = true;
            NombrePais.Width = 200;
            // 
            // PantallaVisualizacionVinos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1984, 1015);
            Controls.Add(dgvVinos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PantallaVisualizacionVinos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaVisualizacionVinos";
            ((System.ComponentModel.ISupportInitialize)dgvVinos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvVinos;
        private DataGridViewTextBoxColumn NombreVino;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Varietales;
        private DataGridViewTextBoxColumn Calificacion;
        private DataGridViewTextBoxColumn NombreBodega;
        private DataGridViewTextBoxColumn NombreRegion;
        private DataGridViewTextBoxColumn NombrePais;
    }
}