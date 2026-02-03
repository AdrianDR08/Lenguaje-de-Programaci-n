namespace suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero1) &&
        int.TryParse(textBox2.Text, out int numero2))
            {
                label1.Text = "Resultado: " + (numero1 + numero2);
            }
    }
}
}
