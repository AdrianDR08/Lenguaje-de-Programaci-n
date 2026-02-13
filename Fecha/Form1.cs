namespace Fecha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMostrarFecha_Click(object sender, EventArgs e)
        {
            labelFecha.Text = "Fecha seleccionada: " +
                dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }
    }
}


