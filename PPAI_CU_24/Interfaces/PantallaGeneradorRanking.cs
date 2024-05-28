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
            cmbRese�a.Items.Add("Normal");
            cmbRese�a.Items.Add("de Amigos");
            cmbRese�a.Items.Add("de Sommeliers");

            cmbTipoVisualizacion.Items.Add("PDF");
            cmbTipoVisualizacion.Items.Add("Excel");
            cmbTipoVisualizacion.Items.Add("Pantalla");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool fechaValida = false;
            bool rese�aSeleccionada = false;
            bool tipoVisualizacionSeleccionada = false;
            bool flujocorrecto = false;

            bool resultado = ValidarPeriodo(tomarFechaDesde(), tomarFechaHasta());
            if (resultado)
            {
                fechaValida = true;
            }
            else
            {
                MessageBox.Show("Fechas invalidas");
            }

            if (tomarSelecTipoRese�a() == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de rese�a");
            }
            else
            {
                rese�aSeleccionada = true;
            }

            if (tomarSelecTipoVisualizacion() == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de visualizacion");
            }
            else
            {
                tipoVisualizacionSeleccionada = true;
            }

            if (tomarSelecTipoRese�a() == "de Sommeliers" && tomarSelecTipoVisualizacion() == "Pantalla")
            {
                flujocorrecto = true;
            }

            else
            {
                MessageBox.Show("Se ha seleccionado un flujo alternativo");
            }


            if (fechaValida && rese�aSeleccionada && tipoVisualizacionSeleccionada && flujocorrecto)
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
        private void habilitarPantalla()
        {
            this.Visible = true;
        }

        public void opcGenerarRankingVinos()
        {
            GestorGeneradorRankings.opcGenerarRankingVinos();


            var formVisualizacionVinos = new PantallaVisualizacionVinos();

            List<Vino> mejoresVinos = gestorGeneradorRankings.mejoresDiez();


            foreach (var vino in mejoresVinos)
            {
                List<Varietal> var = [];
                foreach (Varietal varietal in vino.varietales)
                {
                    var.Add(varietal);
                }

                (string nombreBodega, string nombreRegion, string nombreProvincia, string nombrePais, List<string> descripciones) = vino.obtenerBodega();
                string descripcionesString = string.Join(", ", descripciones);

                formVisualizacionVinos.dgvVinos.Rows.Add(vino.getNombre(), vino.getPrecioARS(), descripcionesString, vino.calificacionPromedio(), vino.bodega.getNombre(), nombreRegion, nombrePais);
            }


            formVisualizacionVinos.Show();
            informarGeneracionExitosa();
            gestorGeneradorRankings.finCU();
            
        }

        private bool tomarConfirmacionReporte()
        {
            if (MessageBox.Show("�Desea confirmar generacion de reporte?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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


        public static DateTime tomarFechaDesde()
        {
            return dtFechaDesde.Value;
        }
        public static DateTime tomarFechaHasta()
        {
            return dtFechaHasta.Value;
        }

        private string tomarSelecTipoRese�a()
        {
            return cmbRese�a.Text;
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

        private void PantallaGeneradorRanking_Leave(object sender, EventArgs e)
        {
            gestorGeneradorRankings.finCU();
        }
    }

}





