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
            MessageBox.Show("�Est� seguro que quiere generar el Reporte?", "Confirmaci�n", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
    }





