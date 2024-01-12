using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompuMod_v2
{
    class ClaseOnda: ClaseVector
    {

        Color[] paleta0 = new Color[16];

        public double w;
        public double v;
        public double t;
        public double m;
        double x, y, z;
        int sx, sy;
        int color0;

        public void ColoresPaleta()
        {
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.Maroon;
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;
        }

        public void PaletaOndaNew()
        {
            for (int i = 0; i < 15; i++)
            {
                int r = (int)(-11.33 * i) + 200;
                int g = (int)(-11.33 * i) + 200;
                int b = (int)(-11.33 * i )+ 200;
                paleta0[i] = Color.FromArgb(r, g, b);
            }
        }
        //ColoresPaleta(); //Paleta para que se pinte
       //PaletaOndaNew();

        public void GrafOnda(Bitmap pixelVec)
        {
            double x, y, z;
            int sx, sy;
            int color0;

            //ColoresPaleta(); //Paleta para que se pinte
            PaletaOndaNew();
            Color c;

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    Transforma(i, j, out x, out y);
                    x = x + 6; //Posicion en el punto X
                    y = y - 0; //Posicion en el punto Y
                    z = w * (Math.Sqrt((x * x) + (y * y))) - v * t;
                    //z = w * (Math.Sqrt((x * x) + (y * y)) - t * v);
                    z = m * Math.Sin(z) + 1;
                    color0 = (int)(z * 7.5);
                    c = paleta0[color0];
                    pixelVec.SetPixel(i, j, c);
                }
            }
        }

        public void Interferencia(Bitmap pixelVec)
        {
            double x, y, z, z1, z2, z3;
            int color0;
            //ColoresPaleta();
            PaletaOndaNew();
            Color c;

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    Transforma(i, j, out x, out y);
                    //x = x - 2;
                    //y = y - 1;

                    z1 = w * (Math.Sqrt((x + 5) * (x  + 5) + (y - (-2)) * (y - (-2))) - v * t); //Fuente 1
                    z2 = w * (Math.Sqrt((x + 5) * (x + 5) + (y - 2) * (y - 2)) - v * t); //Fuente 2
                    z1 = m * Math.Sin(z1) + 1; //Se suma +1 debido a un numero adicional de la paleta el seno va de rango -1 a 1 y por eso se da  + 1 para que no haya valores negativos
                    z2 = m * Math.Sin(z2) + 1;
                    z = z1 + z2;

                    color0 = (int)(z * 3.75);
                    c = paleta0[color0];
                    pixelVec.SetPixel(i, j, c);
                }
            }
        }

        public void Interferencia2(Bitmap pixelVec)
        {
            double x, y, z, z1, z2, z3, z4, z5, z6, z7;
            int color0;
            ColoresPaleta();
            //PaletaOndaNew();
            Color c;

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    Transforma(i, j, out x, out y);

                    z1 = w * (Math.Sqrt((x + 5) * (x + 5) + (y - (-2)) * (y - (-2))) - v * t); //Fuente 1
                    z2 = w * (Math.Sqrt((x + 5) * (x + 5) + (y - 2) * (y - 2)) - v * t); //Fuente 2
                    //POSICION (2.3 , 0.4)
                    z3 = w * (Math.Sqrt((x - 2.3) * (x - 2.3) + (y - 0.4) * (y - 0.4)) - v * t);
           

                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;
                 

                    z = z1 + z2 + z3;
                    color0 = (int)(z * 2.5);
                    c = paleta0[color0];
                    pixelVec.SetPixel(i, j, c);
                }
            }
        }

    }
    
}
