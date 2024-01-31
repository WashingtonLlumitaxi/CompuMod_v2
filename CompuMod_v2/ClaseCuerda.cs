using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompuMod_v2
{
    class ClaseCuerda: ClaseVector
    {
        public double t;

        private double F(double x)
        {
            return (-x * (x - 4)) / 2;
        }

        private double G(double x)
        {
            return x;
        }

        public void FourierC(double x, out double fou)
        {
            double ak, bk, sumF, c;//c variable de elasticidad
            c = 1;
            int k = 0;
            sumF = 0;
            //t = 0.76;
            //t = 3.37;
         

            do
            {
                k = k + 1;
                ak = (0.11) * (4 * F(2) * Math.Sin(k * Math.PI * 0.5) + F(4) * Math.Sin(k * Math.PI));   //el 0.33 es de la divisiond de 2/6 de la formula de sipmson
                ak = ak *  0.5;
                bk = (0.11) * (4 * G(2) * Math.Sin(k * Math.PI * 0.5) + G(4) * Math.Sin(k * Math.PI));
                bk = bk * (2 / (k * Math.PI * c));
                sumF = sumF + (ak * Math.Cos((k * Math.PI * c * t) / 4) + bk * Math.Sin((k * Math.PI * c * t) / 4)) * Math.Sin((k * Math.PI * x) / 4);

            } while (k <= 20);

            fou = sumF;

        }

        public void Grafico(Bitmap pixelVec)
        {
            double x = 0;
            double dx = 0.002;
            ClaseVector vec = new();
            vec.color0 = Color.Blue;
            do
            {
                vec.Xo = x;
                FourierC(x, out double fou);
                vec.Yo = fou;
                vec.Encender(pixelVec);
                x = x + dx;
            } while (x <= 4);
        }

        public void ApagGrafico(Bitmap pixelVec)
        {
            double x = 0;
            double dx = 0.002;
            ClaseVector vec = new();
            vec.color0 = Color.White;
            do
            {
                vec.Xo = x;
                FourierC(x, out double fou);
                vec.Yo = fou;
                vec.Encender(pixelVec);
                x = x + dx;
            } while (x <= 4);
        }
    }
}
