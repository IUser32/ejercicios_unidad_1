namespace Ejercicio1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            MessageBox.Show(string.Format("Hola {0}! Espero que estes bien.", nombre));
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(txtValor1.Text);
            float valor2 = float.Parse(txtValor2.Text);

            float resultado = valor1 + valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(txtValor1Restar.Text);
            float valor2 = float.Parse(txtValor2Restar.Text);

            float resultado = valor1 - valor2;

            txtResultadoRestar.Text = resultado.ToString();
        }
    }
}
