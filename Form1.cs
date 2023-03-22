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
            float anchoInput = (float)numericUpDown1.Value;
            float separacion = (float)numericUpDown2.Value; 


            Colonia.CrearVecindario(pictureBox1, anchoInput, separacion);
        }

    }
}