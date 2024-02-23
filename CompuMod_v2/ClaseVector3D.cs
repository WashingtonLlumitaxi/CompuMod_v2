using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompuMod_v2
{
    class ClaseVector3D: ClaseVector
    {

        public double Zo;
        double ax, ay;
        int sx, sy;

        public void Axonometrial(double x, double y, double z, out double ax, out double ay)
        {
            ax = x + (0.55) * y * Math.Cos(0.8);
            ay = (0.55) * y * Math.Sin(0.8) + z;
        }


        public void Encender3D(Bitmap pixelVec)
        {
            Axonometrial(Xo, Yo, Zo, out ax, out ay);
            Pantalla(ax, ay, out sx, out sy);

            if (sx >= 0 && sx < 600 && sy >= 0 && sy < 500)
            {
                pixelVec.SetPixel(sx, sy, color0);
            }

        }
    }
}
