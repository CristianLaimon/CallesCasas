namespace CallesCasas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Colonia.CrearCasa(pictureBox1, 10, 10);
            Colonia.CrearCalle(pictureBox1);
        }
    }
}