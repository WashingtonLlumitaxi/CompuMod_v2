using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompuMod_v2
{
    class ClaseVector
    {

        //Parametros Iniciales de la ventana pantalla y real


        public int sx1 = 0;
        public int sx2 = 600;
        public int sy1 = 0;
        public int sy2 = 500;
        public double x1 = -5;//-10;//-2.5;//-10;
        public double x2 = 5;//10;//2.5;//10;
        public double y1 = -4.16;//-8.33;//-2;//-8.33;//-5;
        public double y2 = 4.16;//8.33;//2;//8.33;//5;
        public double Xo;
        public double Yo;
        public Color color0;

        
         public ClaseVector() { }
        //constructor con parametros
        public ClaseVector(double Xo, double Yo, Color color0)
        {
            this.Xo = Xo;
            this.Yo = Yo;
            this.color0 = color0;
        }
         

        //Procesos iniciales de para el fucnionamiento correcto del aplicativo
        //Proceso Pantalla
        public void Pantalla(double x, double y, out int sx, out int sy) //Prametros de ingreso y salisa
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }

        //Proceso Encender
        //Funcion principal que utiliza la funcion Pantalla
        public void Encender(Bitmap pixelVec)
        {
            int Sx, Sy;

            Pantalla(Xo, Yo, out Sx, out Sy);

            if (Sx >= 0 && Sx < 600 && Sy >= 0 && Sy < 500)
            {
                pixelVec.SetPixel(Sx, Sy, color0);

            }
        }


        //Proceso Encencer
        public void Apagar(Bitmap pixelVec)
        {
            //    int Sx, Sy;

            //    Pantalla(Xo, Yo, out Sx, out Sy);

            //    if (Sx >= 0 && Sx < 600 && Sy >= 0 && Sy < 500)
            //    {
            //        for (int i = 0; i < 600; i++)
            //        {
            //            for (int j = 0; j < 500; j++)
            //            {
            //                pixelVec.SetPixel(i, j, Color.White);
            //            }
            //        }


            //        //pixelVec.SetPixel(Sx, Sy, Color.White);

            //    }
            //}

            color0 = Color.White;
            Encender(pixelVec);
        }


        //Proceso Transforma

        public void Transforma(int sx, int sy, out double x, out double y)
        {
            //x = (int)(((sx - sx1) * (x1 - x2)) / (sx1 - sx2) + x1);
            //y = (int)(((sy - sy1) * (y2 - y1)) / (sy1 - sy2) + y2);

            x = ((x1 - x2) * (sx - sx1) / (sx1 - sx2)) + x1;
            y = ((y2 - y1) * (sy - sy1) / (sy1 - sy2)) + y2;

            //x = (((sx - sx1) * (x1 - x2)) / (sx1 - sx2) + x1);
            //y = (((sy - sy1) * (y2 - y1)) / (sy1 - sy2) + y2);
        }
    }
}
