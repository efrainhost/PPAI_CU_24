using System.Xml;

namespace PPAI_CU_24
{
    public partial class FormGenerarRanking : Form
    {
        public FormGenerarRanking()
        {
            InitializeComponent();
        }

        private void PantallaGeneradorRanking_Load(object sender, EventArgs e)
        {
            cmbReseña.Items.Add("Normal");
            cmbReseña.Items.Add("de Amigos");
            cmbReseña.Items.Add("de Sommeliers");

            cmbTipoVisualizacion.Items.Add("PDF");
            cmbTipoVisualizacion.Items.Add("Excel");
            cmbTipoVisualizacion.Items.Add("Pantalla");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool fechaValida = false;
            bool reseñaSeleccionada = false;
            bool tipoVisualizacionSeleccionada = false;

            bool resultado = ValidarFecha(tomarFechaDesde(),tomarFechaHasta());
            if (resultado)
            {
                fechaValida = true;
            }
            else
            {
                MessageBox.Show("Fechas invalidas");
            }

            if (tomarTipoReseña() == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de reseña");
            }
            else
            {
                reseñaSeleccionada = true;
            }

            if (tomarTipoVisualizacion() == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de visualizacion");
            }
            else
            {
                tipoVisualizacionSeleccionada = true;
            }

            if (fechaValida && reseñaSeleccionada && tipoVisualizacionSeleccionada)
            {
                solicitarConfirmacionReporte();
            }
           
        }
        private void solicitarConfirmacionReporte()
        {
            if (MessageBox.Show("¿Desea confirmar generacion de reporte?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                informarGeneracionExitosa();
            }
            else
            {
                MessageBox.Show("Se cancela la operacion");
            }
        }

        private void informarGeneracionExitosa()
        {
            MessageBox.Show("Generacion exitosa");
            this.Hide();
        }

        private DateTime tomarFechaDesde()
        {
            return dtFechaDesde.Value;
        }
        private DateTime tomarFechaHasta()
        {
            return dtFechaHasta.Value;
        }

        private string tomarTipoReseña()
        {
            return cmbReseña.Text;
        }

        private string tomarTipoVisualizacion()
        {
            return cmbTipoVisualizacion.Text;
        }

        private bool ValidarFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            int resultado = fechaHasta.CompareTo(fechaDesde);
            if (resultado == -1)
            {
                bool res = false;
                return res;
            }
            else if (resultado == 1)
            {
                bool res = true;
                return res;
            }
            else
            {
                bool res = false;
                return res;
            }
        }

    }

}





