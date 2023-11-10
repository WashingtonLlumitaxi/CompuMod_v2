using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompuMod_v2
{
    public partial class Form1 : Form
    {
        Bitmap pixelVec = new Bitmap(600, 500); //Demencion de la ventana

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {

        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            // Coordenadas del dibujo
            int x = 270, y = 250;

            for (int i = 270; i <= 320; i++)
            {
                pixelVec.SetPixel(i, y, Color.Blue);
            }

            for (int j = 180; j <= 250; j++)
            {
                pixelVec.SetPixel(x, j, Color.Blue);
            }
            ptbPixel.Image = pixelVec;
        }

        private void btnDegradado_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 600; i++)
            {
                for(int j = 0; j < 500; j++)
                {
                    //pixelVec.SetPixel(i, j, Color.FromArgb((int)(0), (int)(0.42 * i), (int)(-0.42 * i + 255)));

                    pixelVec.SetPixel(i, j, Color.FromArgb((int)(-0.118 * i + 178), (int)(-0.071 * i + 170), (int)(0.32 * i + 49)));
                }
            }
            ptbPixel.Image = pixelVec;
        }

       

        private void btnTrazo_Click_1(object sender, EventArgs e)
        {

            ClaseVector cv = new ClaseVector();
            double x = -9;
            do
            {

                cv.Xo = x;
                cv.Yo = 2 * x - 5;
                cv.color0 = Color.Blue;

                cv.Encender(pixelVec);



                x += 0.02;

            } while (x < 2.5);

            double x2 = 2.5;
            do
            {

                cv.Xo = x2;
                cv.Yo = -2 * x2 + 5;
                cv.color0 = Color.Blue;

                cv.Encender(pixelVec);



                x2 += 0.02;

            } while (x2 < 9);

            ptbPixel.Image = pixelVec;
        }

        private void btnSegmento_Click(object sender, EventArgs e)
        {
            ClaseSegmento cs = new ClaseSegmento();
            cs.color0 = Color.Red;
            cs.Xo = -10;
            cs.Yo = -2;
            cs.Xf = 6;
            cs.Yf = 4;
            cs.EncenderSeg(pixelVec);

            ClaseSegmento cs1 = new ClaseSegmento();
            cs1.color0 = Color.Red;
            cs1.Xo = 6;
            cs1.Yo = 4;
            cs1.Xf = 6;
            cs1.Yf = -2;
            cs1.EncenderSeg(pixelVec);

            ClaseSegmento cs2 = new ClaseSegmento();
            cs2.color0 = Color.Red;
            cs2.Xo = 6;
            cs2.Yo = -2;
            cs2.Xf = 10;
            cs2.Yf = 5;
            cs2.EncenderSeg(pixelVec);

            ClaseCircunferencia cc = new();

            cc.Xo = -2;
            cc.Yo = -1;
            cc.Rd = 3;
            cc.color0 = Color.Blue;
            cc.EncenderCirc(pixelVec);
            

            ////Tarea en clase

            //ClaseCircunferencia cc1 = new();

            //cc1.Xo = -2;
            //cc1.Yo = -1;
            //cc1.Rd = 1;
            //cc1.color0 = Color.Black;
            //cc1.EncenderCirc(pixelVec);

            //ClaseCircunferencia cc2 = new();

            //cc2.Xo = 6;
            //cc2.Yo = 4;
            //cc2.Rd = 1;
            //cc2.color0 = Color.Green;
            //cc2.EncenderCirc(pixelVec);

            ptbPixel.Image = pixelVec;

        }

        private void btnCircunferencia_Click(object sender, EventArgs e)
        {

            //Tarea en clase

            ClaseCircunferencia cc1 = new();

            cc1.Xo = -2;
            cc1.Yo = -1;
            cc1.Rd = 1;
            cc1.color0 = Color.Black;
            cc1.EncenderCirc(pixelVec);

            ClaseCircunferencia cc2 = new();

            cc2.Xo = 6;
            cc2.Yo = 4;
            cc2.Rd = 1;
            cc2.color0 = Color.Green;
            cc2.EncenderCirc(pixelVec);

            ptbPixel.Image = pixelVec;

        }
    }
}
