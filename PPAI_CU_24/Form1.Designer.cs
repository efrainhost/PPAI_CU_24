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
            gbTipoDeVisualizacion = new GroupBox();
            rdPantalla = new RadioButton();
            rdExcel = new RadioButton();
            rdPDF = new RadioButton();
            btnGenerar = new Button();
            btnLimpiar = new Button();
            gbTipoDeVisualizacion.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(219, 15);
            label1.Name = "label1";
            label1.Size = new Size(241, 28);
            label1.TabIndex = 0;
            label1.Text = "Generar ranking de vino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 57);
            label2.Name = "label2";
            label2.Size = new Size(249, 15);
            label2.TabIndex = 1;
            label2.Text = "Seleccione fechas de consideracion de reseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 112);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 88);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha desde:";
            // 
            // dtFechaDesde
            // 
            dtFechaDesde.Location = new Point(158, 83);
            dtFechaDesde.Margin = new Padding(3, 2, 3, 2);
            dtFechaDesde.Name = "dtFechaDesde";
            dtFechaDesde.Size = new Size(238, 23);
            dtFechaDesde.TabIndex = 4;
            // 
            // dtFechaHasta
            // 
            dtFechaHasta.Location = new Point(158, 108);
            dtFechaHasta.Margin = new Padding(3, 2, 3, 2);
            dtFechaHasta.Name = "dtFechaHasta";
            dtFechaHasta.Size = new Size(238, 23);
            dtFechaHasta.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 147);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 6;
            label5.Text = "Seleccione tipo de reseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 173);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 7;
            label6.Text = "Reseña:";
            // 
            // cmbReseña
            // 
            cmbReseña.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReseña.FormattingEnabled = true;
            cmbReseña.Location = new Point(158, 171);
            cmbReseña.Margin = new Padding(3, 2, 3, 2);
            cmbReseña.Name = "cmbReseña";
            cmbReseña.Size = new Size(133, 23);
            cmbReseña.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 212);
            label7.Name = "label7";
            label7.Size = new Size(188, 15);
            label7.TabIndex = 9;
            label7.Text = "Seleccione el tipo de visualizacion:";
            // 
            // gbTipoDeVisualizacion
            // 
            gbTipoDeVisualizacion.Controls.Add(rdPantalla);
            gbTipoDeVisualizacion.Controls.Add(rdExcel);
            gbTipoDeVisualizacion.Controls.Add(rdPDF);
            gbTipoDeVisualizacion.Location = new Point(102, 229);
            gbTipoDeVisualizacion.Margin = new Padding(3, 2, 3, 2);
            gbTipoDeVisualizacion.Name = "gbTipoDeVisualizacion";
            gbTipoDeVisualizacion.Padding = new Padding(3, 2, 3, 2);
            gbTipoDeVisualizacion.Size = new Size(299, 50);
            gbTipoDeVisualizacion.TabIndex = 10;
            gbTipoDeVisualizacion.TabStop = false;
            // 
            // rdPantalla
            // 
            rdPantalla.AutoSize = true;
            rdPantalla.Location = new Point(222, 20);
            rdPantalla.Margin = new Padding(3, 2, 3, 2);
            rdPantalla.Name = "rdPantalla";
            rdPantalla.Size = new Size(67, 19);
            rdPantalla.TabIndex = 2;
            rdPantalla.TabStop = true;
            rdPantalla.Text = "Pantalla";
            rdPantalla.UseVisualStyleBackColor = true;
            // 
            // rdExcel
            // 
            rdExcel.AutoSize = true;
            rdExcel.Location = new Point(117, 20);
            rdExcel.Margin = new Padding(3, 2, 3, 2);
            rdExcel.Name = "rdExcel";
            rdExcel.Size = new Size(52, 19);
            rdExcel.TabIndex = 1;
            rdExcel.TabStop = true;
            rdExcel.Text = "Excel";
            rdExcel.UseVisualStyleBackColor = true;
            // 
            // rdPDF
            // 
            rdPDF.AutoSize = true;
            rdPDF.Location = new Point(16, 20);
            rdPDF.Margin = new Padding(3, 2, 3, 2);
            rdPDF.Name = "rdPDF";
            rdPDF.Size = new Size(46, 19);
            rdPDF.TabIndex = 0;
            rdPDF.TabStop = true;
            rdPDF.Text = "PDF";
            rdPDF.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(278, 310);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 11;
            btnGenerar.Text = "generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(371, 310);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormGenerarRanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 348);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGenerar);
            Controls.Add(gbTipoDeVisualizacion);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGenerarRanking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar ranking de vinos";
            Load += Form1_Load;
            gbTipoDeVisualizacion.ResumeLayout(false);
            gbTipoDeVisualizacion.PerformLayout();
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
        private GroupBox gbTipoDeVisualizacion;
        private RadioButton rdPantalla;
        private RadioButton rdExcel;
        private RadioButton rdPDF;
        private Button btnGenerar;
        private Button btnLimpiar;
    }
}
