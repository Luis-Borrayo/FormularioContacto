namespace FormularioContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MensjBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void Enviarmensj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(EmailBox.Text) ||
                string.IsNullOrWhiteSpace(MensjBox.Text))
            {
                MessageBox.Show("Los campo no deben estar vacíos. Vuelva a intentar",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("¡¡Mensaje enviado con exito!!",
                    "Completado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }
}
