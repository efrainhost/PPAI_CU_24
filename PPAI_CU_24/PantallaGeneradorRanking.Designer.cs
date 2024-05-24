namespace PPAI_CU_24
{
    partial class FormGenerarRanking
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(250, 20);
            label1.Name = "label1";
            label1.Size = new Size(299, 35);
            label1.TabIndex = 0;
            label1.Text = "Generar ranking de vino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 76);
            label2.Name = "label2";
            label2.Size = new Size(314, 20);
            label2.TabIndex = 1;
            label2.Text = "Seleccione fechas de consideracion de reseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 149);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 117);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha desde:";
            // 
            // dtFechaDesde
            // 
            dtFechaDesde.Location = new Point(181, 111);
            dtFechaDesde.Name = "dtFechaDesde";
            dtFechaDesde.Size = new Size(271, 27);
            dtFechaDesde.TabIndex = 4;
            // 
            // dtFechaHasta
            // 
            dtFechaHasta.Location = new Point(181, 144);
            dtFechaHasta.Name = "dtFechaHasta";
            dtFechaHasta.Size = new Size(271, 27);
            dtFechaHasta.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 196);
            label5.Name = "label5";
            label5.Size = new Size(182, 20);
            label5.TabIndex = 6;
            label5.Text = "Seleccione tipo de reseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 231);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 7;
            label6.Text = "Reseña:";
            // 
            // cmbReseña
            // 
            cmbReseña.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReseña.FormattingEnabled = true;
            cmbReseña.Location = new Point(181, 228);
            cmbReseña.Name = "cmbReseña";
            cmbReseña.Size = new Size(151, 28);
            cmbReseña.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 283);
            label7.Name = "label7";
            label7.Size = new Size(239, 20);
            label7.TabIndex = 9;
            label7.Text = "Seleccione el tipo de visualizacion:";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(343, 420);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(86, 31);
            btnGenerar.TabIndex = 11;
            btnGenerar.Text = "generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cmbTipoVisualizacion
            // 
            cmbTipoVisualizacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVisualizacion.FormattingEnabled = true;
            cmbTipoVisualizacion.Location = new Point(181, 315);
            cmbTipoVisualizacion.Name = "cmbTipoVisualizacion";
            cmbTipoVisualizacion.Size = new Size(151, 28);
            cmbTipoVisualizacion.TabIndex = 12;
            // 
            // FormGenerarRanking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
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
            Name = "FormGenerarRanking";
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
        private DateTimePicker dtFechaDesde;
        private DateTimePicker dtFechaHasta;
        private Label label5;
        private Label label6;
        private ComboBox cmbReseña;
        private Label label7;
        private Button btnGenerar;
        private ComboBox cmbTipoVisualizacion;
    }
}
