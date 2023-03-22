using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallesCasas
{
    internal class Colonia
    {
        private static Graphics papel;
        public static void CrearCasa(PictureBox pictureBox1, int x, int y)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Purple);


       //papel.DrawRectangle(lapiz, 250, 150, 50, 50);
            //papel.DrawLine(lapiz, 250, 150, 250, 100);
            //papel.DrawLine(lapiz, 250, 100, 300, 150);

            //papel.DrawRectangle(lapiz, x, y, 50, 50);
            //papel.DrawLine(lapiz, x, y, 250, 100);
            //papel.DrawLine(lapiz, x, y-50, 300, 150);

            //papel.DrawRectangle(lapiz, 250, 40, 80, 20);
            //papel.DrawLine(lapiz, 250, 40, 250, 20);
            //papel.DrawLine(lapiz, 250, 20, 330, 40);
        }

        public static void CrearCalle(PictureBox pictureBox1)
        {
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            papel.DrawLine(lapiz, 10, 390, 590, 390);
        }
    }
}
