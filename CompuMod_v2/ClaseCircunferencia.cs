using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompuMod_v2
{
    class ClaseCircunferencia: ClaseVector
    {
        public double Rd;

        //Constructores

        public ClaseCircunferencia() { }

        public ClaseCircunferencia(double xo, double yo, double Rd, Color color0) 
        {
            this.Xo = xo;
            this.Yo = yo;
            this.Rd = Rd;
            this.color0 = color0;
        }

        public void EncenderCirc(Bitmap pixelVec)
        {
            double pi = Math.PI;
            double t = -pi;
            double dt = 0.001;

            ClaseVector cv = new();

            do
            {
                cv.Xo = Xo + Rd * Math.Cos(t);
                cv.Yo = Yo + Rd * Math.Sin(t);
                cv.color0 = color0;
                cv.Encender(pixelVec);
                t += dt;
            }
            while (t <= pi);

        }

    }
}
