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
            int anchoInput = (int)numericUpDown1.Value;
            int separacion = (int)numericUpDown2.Value; 

            Colonia.ReiniciarCanva(pictureBox1);
            Colonia.CrearCalle(pictureBox1);

            Colonia.CrearVecindario(pictureBox1, anchoInput, separacion);
        }

    }
}