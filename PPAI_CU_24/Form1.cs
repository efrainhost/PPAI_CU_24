namespace PPAI_CU_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbReseña.Items.Add("Normal");
            cmbReseña.Items.Add("de Amigos");
            cmbReseña.Items.Add("de no me acuerdo");
        }
    }
}
