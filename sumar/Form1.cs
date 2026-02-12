namespace sumar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);

            int suma = numero1 + numero2;

            label1.Text = "Resultado: " + suma;
        }

    }
}
