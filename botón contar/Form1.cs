namespace botón_contar
{
    public partial class Form1 : Form
    {
        int contador = 0; // Variable para contar clicks

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++; // Aumenta el conteo
            label1.Text = "Presiones: " + contador;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}