namespace Convertit_temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                labelResultado.Text = "Resultado: " + fahrenheit.ToString("0.00") + " °F";
            }
            else
            {
                MessageBox.Show(
                    "Por favor, ingrese un número válido",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}