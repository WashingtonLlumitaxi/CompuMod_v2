﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompuMod_v2
{
    class ClaseCurvaV: ClaseCircunferencia
    {
        

        public ClaseCurvaV() { }

        public void EncenderCurvaV(Bitmap pixelVec)
        {
           

            double t = 0;
            double dt = 0.001;
            int tipo = 2;

            ClaseVector cv = new();

            if (tipo == 0)
            {
                 //Primera Ecuacion
                do
                {
                    cv.Xo = Xo + Rd * Math.Sin(2 * t);
                    cv.Yo = Yo + Rd * Math.Cos(3 * t);
                    cv.color0 = color0;
                    cv.Encender(pixelVec);
                    t = t + dt;

                } while (t <= 2 * Math.PI); 
                

            } else if( tipo == 1)
            {
                double t1 = 0;
                //Segunda Ecuacion 
                do
                {
                    cv.Xo = Xo + Rd * Math.Cos(4 * t1) * Math.Cos(t1);
                    cv.Yo = Yo + Rd * Math.Cos(4 * t1) * Math.Sin(t1);
                    cv.color0 = color0;
                    cv.Encender(pixelVec);
                    t1 = t1 + dt;

                } while (t1 <= 2 * Math.PI);


            } else if( tipo == 2)
            {

                ///
                  //Primera Ecuacion
                do
                {
                    cv.Xo = -2 + Rd * Math.Sin(2 * t);
                    cv.Yo = -3 + Rd * Math.Cos(3 * t);
                    cv.color0 = color0;
                    cv.Encender(pixelVec);
                    t = t + dt;

                } while (t <= 2 * Math.PI);
                //

                double t1 = 0;
                //Segunda Ecuacion 
                do
                {
                    cv.Xo = -4 + Rd * Math.Cos(4 * t1) * Math.Cos(t1);
                    cv.Yo = 6 + Rd * Math.Cos(4 * t1) * Math.Sin(t1);
                    cv.color0 = color0;
                    cv.Encender(pixelVec);
                    t1 = t1 + dt;

                } while (t1 <= 2 * Math.PI);

                ///
                //Tercera Ecuacion 
                double t2 = 0;
                do
                {
                    cv.Xo = 4 + Rd * (Math.Sin(t2) * Math.Sin(t2) * Math.Sin(t2));
                    cv.Yo = 4 + Rd * (Math.Cos(t2) * Math.Cos(t2) * Math.Cos(t2));
                    cv.color0 = color0;
                    cv.Encender(pixelVec);
                    t2 = t2 + dt;

                } while (t2 <= 2 * Math.PI);


            }
        }



    }
}
