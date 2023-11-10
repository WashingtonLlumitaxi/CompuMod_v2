﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompuMod_v2
{
    class ClaseVector
    {
        public int sx1 = 0;
        public int sx2 = 600;
        public int sy1 = 0;
        public int sy2 = 500;
        public double x1 = -10;
        public double x2 = 10;
        public double y1 = -8.33;//-5;
        public double y2 = 8.33;//5;
        public double Xo;
        public double Yo;
        public Color color0;

         public ClaseVector() { }
        //constructor
        public ClaseVector(double Xo, double Yo, Color color0)
        {
            this.Xo = Xo;
            this.Yo = Yo;
            this.color0 = color0;
        }

        //Proceso Pantalla
        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }

        //Proceso Encencer
        public void Encender(Bitmap pixelVec)
        {
            int Sx, Sy;

            Pantalla(Xo, Yo, out Sx, out Sy);

            if (Sx >= 0 && Sx < 600 && Sy >= 0 && Sy < 500)
            {
                pixelVec.SetPixel(Sx, Sy, color0);

            }
        }
    }
}
