using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallesCasas
{
    internal class Colonia
    {
        private static Graphics papel; 
        private static int x = 10, y = 380; //el punto inicial de la primera casa ya estara definido por defecto 

        public static void CrearVecindario(PictureBox pictureBox1, int ancho, int separacion)
        {
 

            CrearCasa(pictureBox1, ancho, x, y);
            x += ancho + separacion;
     
        }
        public static void CrearCasa(PictureBox pictureBox1, int ancho, int a , int b)
        {
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Purple);

            papel.DrawRectangle(lapiz, x, y - ancho, ancho, ancho);
            papel.DrawLine(lapiz, x, y - ancho, x, y - 2* ancho);
            papel.DrawLine(lapiz, x, y - 2* ancho, x+ancho, y - ancho);
        }











        public static void CrearCalle(PictureBox pictureBox1)
        {
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            papel.DrawLine(lapiz, 10, 390, 590, 390);
        }

        public static void ReiniciarCanva(PictureBox pictureBox1)
        {
            pictureBox1.CreateGraphics().Clear(Color.White);
        }

    }
}
