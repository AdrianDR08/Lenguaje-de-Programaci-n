namespace Radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                labelResultado.Text = "Seleccionaste: Opción 1";
            }
            else if (radioButton2.Checked)
            {
                labelResultado.Text = "Seleccionaste: Opción 2";
            }
            else if (radioButton3.Checked)
            {
                labelResultado.Text = "Seleccionaste: Opción 3";
            }
            else
            {
                labelResultado.Text = "No seleccionaste ninguna opción";
            }
        }

    }
}
