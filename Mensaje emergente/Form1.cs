namespace Mensaje_emergente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hola, soy Adrian Rodriguez Luciano y mi matrícula es SD-2024-00988",
                "Mensaje",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}