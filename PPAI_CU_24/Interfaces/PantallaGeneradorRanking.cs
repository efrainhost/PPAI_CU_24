using PPAI_CU_24.Entidades;
using PPAI_CU_24.Gestor;
using PPAI_CU_24.Interfaces;
using System.Xml;

namespace PPAI_CU_24
{
    public partial class PantallaGeneradorRanking : Form
    {
        // Relaciones  
        public GestorGeneradorRankings gestorGeneradorRankings { get; set; }

        // Constructor
        public PantallaGeneradorRanking()
        {
            InitializeComponent();
            GestorGeneradorRankings gestorGeneradorRankings = new GestorGeneradorRankings();
            this.gestorGeneradorRankings = gestorGeneradorRankings;

        }

        // Eventos
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
            bool tipoReseñaSeleccionada = false;
            bool tipoVisualizacionSeleccionada = false;
            bool flujocorrecto = false;

            bool resultado = ValidarPeriodo(tomarFechaDesde(), tomarFechaHasta());
            gestorGeneradorRankings.tomarFechaDesde(tomarFechaDesde());
            gestorGeneradorRankings.tomarFechaHasta(tomarFechaHasta());
            if (resultado)
            {
                fechaValida = true;
            }
            else
            {
                MessageBox.Show("Fechas invalidas");
            }

            if (tomarSelecTipoReseña() == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de reseña");
            }
            else
            {
                tipoReseñaSeleccionada = true;
            }

            if (tomarSelecTipoVisualizacion() == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de visualizacion");
            }
            else
            {
                tipoVisualizacionSeleccionada = true;
            }

            if (tomarSelecTipoReseña() == "de Sommeliers" && tomarSelecTipoVisualizacion() == "Excel")
            {
                flujocorrecto = true;
            }

            else
            {
                MessageBox.Show("Se ha seleccionado un flujo alternativo");
            }


            if (fechaValida && tipoReseñaSeleccionada && tipoVisualizacionSeleccionada && flujocorrecto)

            {
                bool conf = tomarConfirmacionReporte();
                if (conf)
                {
                    opcGenerarRankingVinos();
                }
                else
                {
                    this.Close();
                }

            }
        }

        // Metodos
        public void habilitarPantalla()
        {
            this.Visible = true;
        }

        public void opcGenerarRankingVinos()
        {
            gestorGeneradorRankings.opcGenerarRankingVinos();
            informarGeneracionExitosa();
            gestorGeneradorRankings.finCU();
            
        }

        private bool tomarConfirmacionReporte()
        {
            if (MessageBox.Show("¿Desea confirmar generacion de reporte?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Se cancela la operacion");
                return false;
            }
        }

        private void informarGeneracionExitosa()
        {
            MessageBox.Show("Generacion exitosa");
            this.Hide();
        }


        public DateTime tomarFechaDesde()
        {
            return dtFechaDesde.Value;
        }
        public DateTime tomarFechaHasta()
        {
            return dtFechaHasta.Value;
        }

        private string tomarSelecTipoReseña()
        {
            return cmbReseña.Text;
        }

        private string tomarSelecTipoVisualizacion()
        {
            return cmbTipoVisualizacion.Text;
        }

        public bool ValidarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
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





