namespace Lisbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese un texto", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para eliminar", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
