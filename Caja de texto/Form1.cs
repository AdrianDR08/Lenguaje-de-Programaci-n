namespace Caja_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                labelResultado.Text = "Es un número válido: " + numero;
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show(
                    "La entrada no es un número válido",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                labelResultado.Text = "Entrada inválida";
                labelResultado.ForeColor = Color.Red;
            }
        }
    }
}
