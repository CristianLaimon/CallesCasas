﻿using System;
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
        private static float x = 10, y = 380; //el punto inicial de la primera casa ya estara definido por defecto 
        private static Random random = new Random();

        public static void CrearVecindario(PictureBox pictureBox1, float ancho, float separacion)
        {
            x = 10; 
            y = 380;

            ReiniciarCanva(pictureBox1);
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            papel.DrawLine(lapiz, 10, 390, 590, 390);


            while( (x+ancho) < pictureBox1.Width-10)
            {
                CrearCasa(pictureBox1, ancho, x, y);
                x += ancho + separacion;
                ancho -= (float)(ancho * 0.2);
            }

 
        }
        public static void CrearCasa(PictureBox pictureBox1, float ancho, float a, float b)
        {
            Color randomColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(randomColor);

            papel.DrawRectangle(lapiz, x, y - ancho, ancho, ancho);
            papel.DrawLine(lapiz, x, y - ancho, x, y - 2 * ancho);
            papel.DrawLine(lapiz, x, y - 2 * ancho, x + ancho, y - ancho);
        }

        public static void ReiniciarCanva(PictureBox pictureBox1)
        {
            pictureBox1.CreateGraphics().Clear(Color.White);
        }

    }
}
