using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompuMod_v2
{
    class ClaseSegmento : ClaseVector //Herencia 
    {
        /// <summary>
        /// La clase segmento grafica una linea, gracias a que utiliza la herencia 
        ///  de la clase vector, le podemos dar una longitud de acuerdo a 
        ///  que utiliza los puntos iniciales y finales.
        ///  Principalmente utiliza la funcion encender pues el segmento es un vector
        /// </summary>

        

        public double Xf;
        public double Yf;

        public ClaseSegmento() { }

        ClaseSegmento(double x0, double y0, double xf, double yf, Color color0) {
            this.Xo = x0;
            this.Yo = y0;
            this.Xf = xf;
            this.Yf = yf;
            this.color0 = color0;
        }

        public void EncenderSeg(Bitmap pixelVec)
        {
            double t = 0, dt = 0.001;

            ClaseVector cv = new ClaseVector();

            do
            {
                cv.Xo = Xo + (Xf - Xo) * t;
                cv.Yo = Yo + (Yf - Yo) * t;
                cv.color0 = color0;
                cv.Encender(pixelVec);
                t += dt;

            }
            while (t <= 1);
        }
    }
}
