namespace PPAI_CU_24
{
    partial class PantallaGeneradorRanking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaGeneradorRanking));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtFechaDesde = new DateTimePicker();
            dtFechaHasta = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            cmbReseña = new ComboBox();
            label7 = new Label();
            btnGenerar = new Button();
            cmbTipoVisualizacion = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(406, 32);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(478, 54);
            label1.TabIndex = 0;
            label1.Text = "Generar ranking de vino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 122);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(507, 32);
            label2.TabIndex = 1;
            label2.Text = "Seleccione fechas de consideracion de reseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 238);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 2;
            label3.Text = "Fecha hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 187);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 32);
            label4.TabIndex = 3;
            label4.Text = "Fecha desde:";
            // 
            // dtFechaDesde
            // 
            dtFechaDesde.Location = new Point(294, 178);
            dtFechaDesde.Margin = new Padding(5);
            dtFechaDesde.Name = "dtFechaDesde";
            dtFechaDesde.Size = new Size(438, 39);
            dtFechaDesde.TabIndex = 4;
            // 
            // dtFechaHasta
            // 
            dtFechaHasta.Location = new Point(294, 230);
            dtFechaHasta.Margin = new Padding(5);
            dtFechaHasta.Name = "dtFechaHasta";
            dtFechaHasta.Size = new Size(438, 39);
            dtFechaHasta.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 314);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(293, 32);
            label5.TabIndex = 6;
            label5.Text = "Seleccione tipo de reseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 370);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 32);
            label6.TabIndex = 7;
            label6.Text = "Reseña:";
            // 
            // cmbReseña
            // 
            cmbReseña.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReseña.FormattingEnabled = true;
            cmbReseña.Location = new Point(294, 365);
            cmbReseña.Margin = new Padding(5);
            cmbReseña.Name = "cmbReseña";
            cmbReseña.Size = new Size(243, 40);
            cmbReseña.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 453);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(383, 32);
            label7.TabIndex = 9;
            label7.Text = "Seleccione el tipo de visualizacion:";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(527, 616);
            btnGenerar.Margin = new Padding(5, 6, 5, 6);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(140, 81);
            btnGenerar.TabIndex = 11;
            btnGenerar.Text = "Generar Ranking";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cmbTipoVisualizacion
            // 
            cmbTipoVisualizacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVisualizacion.FormattingEnabled = true;
            cmbTipoVisualizacion.Location = new Point(294, 504);
            cmbTipoVisualizacion.Margin = new Padding(5);
            cmbTipoVisualizacion.Name = "cmbTipoVisualizacion";
            cmbTipoVisualizacion.Size = new Size(243, 40);
            cmbTipoVisualizacion.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(218, 507);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 32);
            label8.TabIndex = 13;
            label8.Text = "Tipo:";
            // 
            // PantallaGeneradorRanking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 773);
            Controls.Add(label8);
            Controls.Add(cmbTipoVisualizacion);
            Controls.Add(btnGenerar);
            Controls.Add(label7);
            Controls.Add(cmbReseña);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtFechaHasta);
            Controls.Add(dtFechaDesde);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "PantallaGeneradorRanking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar ranking de vinos";
            Load += PantallaGeneradorRanking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbReseña;
        private Label label7;
        private Button btnGenerar;
        private ComboBox cmbTipoVisualizacion;
        private Label label8;
        private static DateTimePicker dtFechaDesde;
        private static DateTimePicker dtFechaHasta;
    }
}
