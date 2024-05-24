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
            cmbReseña.Items.Add("Normal");
            cmbReseña.Items.Add("de Amigos");
            cmbReseña.Items.Add("de Sommeliers");
            cmbReseña.Items.Add("");
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
            MessageBox.Show("¿Está seguro que quiere generar el Reporte?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
    }





