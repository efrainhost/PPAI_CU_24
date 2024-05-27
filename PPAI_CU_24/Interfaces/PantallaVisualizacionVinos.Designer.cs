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
            dgvVinos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVinos).BeginInit();
            SuspendLayout();
            // 
            // dgvVinos
            // 
            dgvVinos.AllowUserToAddRows = false;
            dgvVinos.AllowUserToDeleteRows = false;
            dgvVinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVinos.Location = new Point(141, 67);
            dgvVinos.Name = "dgvVinos";
            dgvVinos.ReadOnly = true;
            dgvVinos.RowHeadersWidth = 82;
            dgvVinos.Size = new Size(1235, 642);
            dgvVinos.TabIndex = 0;
            // 
            // PantallaVisualizacionVinos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 1015);
            Controls.Add(dgvVinos);
            Name = "PantallaVisualizacionVinos";
            Text = "PantallaVisualizacionVinos";
            ((System.ComponentModel.ISupportInitialize)dgvVinos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvVinos;
    }
}