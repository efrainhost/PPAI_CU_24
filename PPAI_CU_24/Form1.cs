using System.Xml;

namespace PPAI_CU_24
{
    public partial class FormGenerarRanking : Form
    {
        public FormGenerarRanking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRese�a.Items.Add("Normal");
            cmbRese�a.Items.Add("de Amigos");
            cmbRese�a.Items.Add("de Sommeliers");
            cmbRese�a.Items.Add("");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            dtFechaDesde.Text = "";
            dtFechaHasta.Text = "";
            rdPDF.Checked = false;
            rdExcel.Checked = false;
            rdPantalla.Checked = false;

        }
        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            DateTime fechaDesde = dtFechaDesde.Value;
            DateTime fechaHasta = dtFechaHasta.Value;
            resultado = validarFecha(fechaDesde, fechaHasta);
            if (resultado)
            {
                DialogResult confirmacion = MessageBox.Show("Esta seguro que desea generar el ranking?", "Generacion ranking", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.OK)
                {
                    MessageBox.Show("Se ha generado con �xito");
                }
            }
            else
            {
                MessageBox.Show("Las fechas no son validas");
            }
        }    

        private bool validarFecha(DateTime fechaDesde , DateTime fechaHasta)
        {
            int resultado = fechaDesde.CompareTo(fechaHasta);   
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
           // MessageBox.Show("�Est� seguro que quiere generar el Reporte?", "Confirmaci�n", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
    





