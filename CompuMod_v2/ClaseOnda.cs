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


        public void GrafOnda(Bitmap pixelVec)
        {
            double x, y, z;
            int color0;

            ColoresPaleta(); //Paleta para que se pinte
            //PaletaOndaNew();
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

        public void GrafOnda3D(Bitmap pixelVec)
        {

            ClaseVector3D cv3d = new ClaseVector3D();
            double x, y, z, z1, z2, z3, dx, dy;

           
            cv3d.color0 = Color.Green;

          

            //x = -9;
            //do
            //{
            //    y = -7;
            //    do
            //    {
            //        //No se utiliza el proceso Carta ya que esto es parte de la pantalla Real, antes se utilizaba porque
            //        //Era de la ventana Pantalla convietia en valores reales por que cual ya no es necesario pues ya son reales
            //        cv3d.Xo = x;
            //        cv3d.Yo = y;
            //        z1 = m * Math.Sin(w * (Math.Sqrt((x * x) + (y * y))) - v * t);
            //        z2 = m * Math.Sin(w * (Math.Sqrt((Math.Pow((x - 0), 2)) + (Math.Pow((y + 3), 2)))) - v * t);
            //        cv3d.Zo = z1 + z2;
            //        cv3d.Encender3D(pixelVec);

            //        y = y + 0.15;
            //    } while (y <= 7);
            //    x = x + 0.15;

            //} while (x <= 9);

            x = -7;
            do
            {
                y = -6;
                do
                {
                    //No se utiliza el proceso Carta ya que esto es parte de la pantalla Real, antes se utilizaba porque
                    //Era de la ventana Pantalla convietia en valores reales por que cual ya no es necesario pues ya son reales
                    //x = x - 3;
                    //y = y - 1;
                    cv3d.Xo = x;
                    cv3d.Yo = y;
                    cv3d.Zo = m * Math.Sin(w * (Math.Sqrt((x + 2) * (x + 2) + (y * y))) - v * t);
                    cv3d.Encender3D(pixelVec);

               

                    y = y + 0.1;
                } while (y <= 6);
                x = x + 0.1;

            } while (x <= 7);
        }

        public void ApagarGrafOnda1(Bitmap pixelVec)
        {
            ClaseVector3D cv3d = new ClaseVector3D();
            double x, y, z, z1, z2, z3, dx, dy;

            cv3d.color0 = Color.White;

            x = -7;
            do
            {
                y = -6;
                do
                {
                    cv3d.Xo = x;
                    cv3d.Yo = y;
                    cv3d.Zo = m * Math.Sin(w * (Math.Sqrt((x + 2) * (x + 2) + (y * y))) - v * t);
                    cv3d.Encender3D(pixelVec);
                    y = y + 0.1;
                } while (y <= 6);
                x = x + 0.1;

            } while (x <= 7);

        }

        public void GrafOnda3D2(Bitmap pixelVec)
        {
            ClaseVector3D cv3d = new ClaseVector3D();
            double x, y, z, z1, z2, z3, dx, dy;
          
            cv3d.color0 = Color.Red;
            x = -8;
            do
            {
                y = -7;
                do
                {
                    cv3d.Xo = x;
                    cv3d.Yo = y;
                    //cv3d.Zo = m * Math.Sin(w * (Math.Sqrt((x * x) + (y * y))) - v * t);
                    z1 = w * (Math.Sqrt((x * x) + ((y - 3) * (y - 3)))) - t * v;
                    z2 = w * (Math.Sqrt((x * x) + ((y + 3) * (y + 3)))) - t * v;
                    //z3 = w * (Math.Sqrt((x) * (x) + (y - 4) * (y - 4))) - v * t;
                    double z1e = m * Math.Sin(z1);
                    double z2e = m * Math.Sin(z2);
                    //z3 = m * Math.Sin(z3);
                    z = z1e + z2e;
                    cv3d.Zo = z;
                    cv3d.Encender3D(pixelVec);

                    y = y + 0.15;
                } while (y <= 7);
                x = x + 0.15;
            } while (x <= 8);

        }

        public void ApagarGrafOnda3D2(Bitmap pixelVec)
        {
            ClaseVector3D cv3d = new ClaseVector3D();
            double x, y, z, z1, z2, z3, dx, dy;

            cv3d.color0 = Color.White;
            x = -8;
            do
            {
                y = -7;
                do
                {
                    cv3d.Xo = x;
                    cv3d.Yo = y;
                    z1 = w * (Math.Sqrt((x * x) + ((y - 3) * (y - 3)))) - t * v;
                    z2 = w * (Math.Sqrt((x * x) + ((y + 3) * (y + 3)))) - t * v;
                    double z1e = m * Math.Sin(z1);
                    double z2e = m * Math.Sin(z2);
                    z = z1e + z2e;
                    cv3d.Zo = z;
                    cv3d.Encender3D(pixelVec);

                    y = y + 0.15;
                } while (y <= 7);
                x = x + 0.15;
            } while (x <= 8);

        }

        //public void GrafOndaInf(Bitmap pixelVec)
        public double[, ,] ObtenerDatosMatriz(Bitmap pixelVec)
        {
            double x, y, z1, z2;
            int color0;

            ColoresPaleta();
      
            Color c;

            double[,,] datosMatriz = new double[600, 500, 3];

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    //
                    //Transformar(i, j, out x, out y);
                    //z = w * (Math.Sqrt(((x + 4) * (x + 4)) + ((y + 1) * (y + 1))) - v * t);
                    //z = m * Math.Sin(z) + 1;
                    //color0 = (int)(z * 7.5);  //Se multiplica por 7.5 porque se tiene 15 colores y se lo divide para 2 porque la funcion seno toma valores de -1 a 1
                    //                          //Console.WriteLine($"X: {x:F3}   Y: {y:F3} RGB: {paleta0[color0].Name}");
                    //writer.WriteLine($"{x:F5};{y:F5};{z:F5};{paleta0[color0].Name}");
                    //c = paleta0[color0];
                    //viewPort.SetPixel(i, j, c);
                    //

                    Transforma(i, j, out x, out y);
                   // x = x + 6; 
                   // y = y - 0; 
                   // z1 = w * (Math.Sqrt((x * x) + (y * y))) - v * t;
                    z1 = w * (Math.Sqrt(((x + 6) * (x + 6)) + ((y + 1) * (y + 1))) - v * t);
                    z2 = m * Math.Sin(z1) + 1;

                    //datosMatriz[i, j] = z2;
                    datosMatriz[i, j, 0] = x;
                    datosMatriz[i, j, 1] = y;
                    datosMatriz[i, j, 2] = z2;



                    color0 = (int)(z2 * 7.5);
                    c = paleta0[color0];
                    pixelVec.SetPixel(i, j, c);
                }
            }
            return datosMatriz;
        }

        public double[,,] GrafOnda3Infor(Bitmap pixelVec)
        {


            //double[,,] datosMatriz = new double[600, 500, 3];

            ClaseVector3D cv3d = new ClaseVector3D();
            double x, y, z, z1, z2, z3;
            int dx, dy, dz;
            cv3d.color0 = Color.Green;

            //x = -7;
            //do
            //{
            //    y = -6;
            //    do
            //    {
            //        //x = x - 3;
            //        //y = y - 1;
            //        cv3d.Xo = x;
            //        cv3d.Yo = y;
            //        cv3d.Zo = m * Math.Sin(w * (Math.Sqrt((x + 2) * (x + 2) + (y * y))) - v * t);
            //        cv3d.Encender3D(pixelVec);

            //        dx = Convert.ToInt32(x);
            //        dy = Convert.ToInt32(y);
            //        dz = Convert.ToInt32(cv3d.Zo);

            //        datosMatriz[0, 0, 0] = x;
            //        datosMatriz[1, 1, 1] = y;
            //        datosMatriz[2, 2, 2] = cv3d.Zo;


            //        y = y + 0.1;
            //    } while (y <= 6);
            //    x = x + 0.1;

            //} while (x <= 7);
            int filas = 600;
            int columnas = 500;

            double[,,] datosMatriz = new double[filas, columnas, 3];

        
            for (double i = -7; i <= 7; i += 0.1)
            {
            
                for (double j = -6; j <= 6; j += 0.1)
                {
                    cv3d.Xo = i;
                    cv3d.Yo = j;
                    cv3d.Zo = m * Math.Sin(w * (Math.Sqrt((i + 2) * (i + 2) + (j * j))) - v * t);
                    cv3d.Encender3D(pixelVec);

                    //datosMatriz[i, j, 0] = x;
                    //datosMatriz[i, j, 1] = y;
                    //datosMatriz[i, j, 2] = cv3d.Zo;

                    int indiceFila = (int)((i + 7) / 0.1); // Ajusta según el rango y la resolución
                    int indiceColumna = (int)((j + 6) / 0.1); // Ajusta según el rango y la resolución

                    datosMatriz[indiceFila, indiceColumna, 0] = i;
                    datosMatriz[indiceFila, indiceColumna, 1] = j;
                    datosMatriz[indiceFila, indiceColumna, 2] = cv3d.Zo;

                 
                }

             
            }
            return datosMatriz;
        }

    }
    
}
