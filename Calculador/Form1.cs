using System;
using System.Windows.Forms;

namespace Calculador
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        string operacion = "";
        bool nuevaEntrada = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (nuevaEntrada)
            {
                textBoxPantalla.Text = "";
                nuevaEntrada = false;
            }

            textBoxPantalla.Text += btn.Text;
        }

        private void BotonOperacion_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(textBoxPantalla.Text);
            operacion = ((Button)sender).Text;
            nuevaEntrada = true;
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            double numero2 = double.Parse(textBoxPantalla.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        return;
                    }
                    resultado = numero1 / numero2;
                    break;
            }

            textBoxPantalla.Text = resultado.ToString();
            nuevaEntrada = true;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = "0";
            numero1 = 0;
            operacion = "";
            nuevaEntrada = true;
        }
    }
}
