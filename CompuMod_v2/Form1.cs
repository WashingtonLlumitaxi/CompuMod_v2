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
  /// <summary>
  /// Clase principal del formulario
  /// en esta clase se insertan solamente los puntos estrategios y se hace el llamado
  /// a las distintas funciones de las clases que se han desarrollado, no obstante se puede 
  /// relaizar la programacion general de lo que se nos pidiera pues todas las clases se hallan
  /// heredadas unas a otras.
  /// </summary>
  /// 

    public partial class btnTaylor1 : Form
    {
        Bitmap pixelVec = new Bitmap(600, 500); //Demensiones de la ventana Pantalla



        public Color[] paleta2 = new Color[16];


        public void paleta ()
        {
            paleta2[0] = Color.Black;
            paleta2[1] = Color.Navy;
            paleta2[2] = Color.Green;
            paleta2[3] = Color.Aqua;
            paleta2[4] = Color.Red;
            paleta2[5] = Color.Purple;
            paleta2[6] = Color.Maroon;
            paleta2[7] = Color.LightGray;
            paleta2[8] = Color.DarkGray;
            paleta2[9] = Color.Blue;
            paleta2[10] = Color.Lime;
            paleta2[11] = Color.Silver;
            paleta2[12] = Color.Teal;
            paleta2[13] = Color.Fuchsia;
            paleta2[14] = Color.Yellow;
            paleta2[15] = Color.White;


        }

        
      


        public btnTaylor1()
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
                    
                    if (j <= 250)
                    {
                        pixelVec.SetPixel(i, j, Color.FromArgb((int)(0), (int)(0.51 * j), (int)(-0.51 * j + 255)));

                    }
                    else
                    {
                        pixelVec.SetPixel(i, j, Color.FromArgb((int)(0), (int)(-0.51 * j + 255), (int)(0.51 * j)));

                    }

                   

                    //pixelVec.SetPixel(i, j, Color.FromArgb((int)(-0.118 * i + 178), (int)(-0.071 * i + 170), (int)(0.32 * i + 49)));
                    //if(j <= 300)
                    //{
                    //    pixelVec.SetPixel(i, j, Color.FromArgb((int)(-0.118 * i + 178), (int)(-0.071 * i + 170), (int)(0.32 * i + 49)));

                    //} else
                    //{
                    //    pixelVec.SetPixel(i, j, Color.FromArgb((int)(-0.118 * i + 178), (int)(-0.071 * i + 170), (int)(0.32 * i + 49)));
                    //}
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

        private void btnCurvaV_Click(object sender, EventArgs e)
        {
            ClaseCurvaV cv = new();
            cv.Xo = 3;
            cv.Yo = -1;
            cv.Rd = 2;
            cv.color0 = Color.Blue;
            cv.EncenderCurvaV(pixelVec);

            ptbPixel.Image = pixelVec;
        }

        private void btnCurvaV2_Click(object sender, EventArgs e)
        {

            ClaseCurvaV cv = new();
            cv.Xo = 5;
            cv.Yo = -1;
            cv.Rd = 3;
            cv.color0 = Color.Red;
            cv.EncenderCurvaV2(pixelVec);

            ClaseCurvaV cv1 = new();
            cv1.Xo = -4;
            cv1.Yo = 5;
            cv1.Rd = 2;
            cv1.color0 = Color.Blue;
            cv1.EncenderCurvaV2(pixelVec);

            ClaseCurvaV cv2 = new();
            cv2.Xo = -6;
            cv2.Yo = -6;
            cv2.Rd = 1;
            cv2.color0 = Color.Green;
            cv2.EncenderCurvaV2(pixelVec);

            ptbPixel.Image = pixelVec;

        }

        private void btnRectas_Click(object sender, EventArgs e)
        {
            ClaseSegmento cs = new ClaseSegmento();
            cs.color0 = Color.Black;
            cs.Xo = -10;
            cs.Yo = 0;
            cs.Xf = 10;
            cs.Yf = 0;
            cs.EncenderSeg(pixelVec);

            ClaseSegmento cs1 = new ClaseSegmento();
            cs1.color0 = Color.Black;
            cs1.Xo = 0;
            cs1.Yo = -8.33;
            cs1.Xf = 0;
            cs1.Yf = 8.33;
            cs1.EncenderSeg(pixelVec);

            ptbPixel.Image = pixelVec;
        }

        private void btnCurvas3_Click(object sender, EventArgs e)
        {
            ClaseCurvaV cv2 = new();
            //cv2.Xo = -6;
            //cv2.Yo = -6;
            //cv2.Rd = 1;
            cv2.color0 = Color.Green;
            cv2.EncenderCurvaV3(pixelVec);

            ptbPixel.Image = pixelVec;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = -8;
            double dt = 0.001;

            ClaseVector cv = new();


            do
            {
                cv.Xo = (t);
                cv.Yo = Math.Pow(3, t);
                cv.color0 = Color.Red;
                cv.Encender(pixelVec);

                //Taylor
                cv.Yo = 1 + (1.098 * (t -0)) + (((1.206) * Math.Pow((t - 0), 2))/ 2) + (((1.325) * Math.Pow((t - 0), 3)) / 6) + (((1.456) * Math.Pow((t - 0), 4)) / 24);
                cv.color0 = Color.Blue;
                cv.Encender(pixelVec);


                t = t + dt;

            } while (t <= 8);
            ptbPixel.Image = pixelVec;

        }

        private void btnEspejo_Click(object sender, EventArgs e)
        {
            ClaseVector cv = new();
            double t = -10;

            do
            {
                cv.Xo = t;
                cv.Yo = (-0.03 * Math.Pow(t, 2) + 3);
                cv.color0 = Color.Red;
                cv.Encender(pixelVec);
                t += 0.001;
            } while (t <= 10);

            ptbPixel.Image = pixelVec;
        }

        private void btnTangen_Click(object sender, EventArgs e)
        {
            ///
            /// Grafica la tangente
         
            /// 
            double Xa1 = 3;

            ClaseSegmento cs = new ClaseSegmento();
            cs.color0 = Color.Blue;
            cs.Xo = -10;
            cs.Yo = ((-0.06 * Xa1) * ((-10) - Xa1) + (-0.03 * Math.Pow(Xa1, 2) + 3));
            cs.Xf = 10;
            cs.Yf = ((-0.06 * Xa1) * ((10) - Xa1) + (-0.03 * Math.Pow(Xa1, 2) + 3)); ;
            cs.EncenderSeg(pixelVec);

            //////
            double Xa = -5;

         
            cs.color0 = Color.Blue;
            cs.Xo = -10;
            cs.Yo = ((-0.06 * Xa) * ((-10) - Xa) + (-0.03 * Math.Pow(Xa, 2) + 3));
            cs.Xf = 10;
            cs.Yf = ((-0.06 * Xa) * ((10) - Xa) + (-0.03 * Math.Pow(Xa, 2) + 3)); ;
            cs.EncenderSeg(pixelVec);


            ////
            ///
              //////
            double Xa2 = 6;


            cs.color0 = Color.Blue;
            cs.Xo = -10;
            cs.Yo = ((-0.06 * Xa2) * ((-10) - Xa2) + (-0.03 * Math.Pow(Xa2, 2) + 3));
            cs.Xf = 10;
            cs.Yf = ((-0.06 * Xa2) * ((10) - Xa2) + (-0.03 * Math.Pow(Xa2, 2) + 3)); ;
            cs.EncenderSeg(pixelVec);

            ptbPixel.Image = pixelVec;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 600; i++)
            //{
            //    for (int j = 0; j < 500; j++)
            //    {
            //        pixelVec.SetPixel(i, j, Color.White);
            //    }
            //}

            ClaseVector cv = new();
            cv.Apagar(pixelVec);
            ptbPixel.Image = pixelVec;
        }

        private void btnPaleta_Click(object sender, EventArgs e)
        {
            Color[] paleta1 = new Color[16];

            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int colorT;
            Color c;

            ClaseVector cv = new();
            for (int i = 0; i < 600; i++)
            {
                for(int j = 0; j < 500; j++)
                {
                    colorT = (int)(i + j * j + Math.Sin(j)) % 15; ;
                    c = paleta1[colorT];
                    pixelVec.SetPixel(i, j, c);
                    
                }
          
            }
            ptbPixel.Image = pixelVec;

        }

       

        private void cbxTapetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tapeteSelect = cbxTapetes.SelectedItem.ToString();

            ///Paleta de colores
            ///
            Color[] paleta1 = new Color[16];

            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            switch (tapeteSelect)
            {
                case "Tapete 1":

                    int colorT;
                    Color c;

                   
                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            colorT = (int)(Math.Pow( i + j , 3)/ 5) % 15; 
                            c = paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
               

                    break;


                case "Tapete 2":


                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            colorT = (int)(i * Math.Sqrt(j) * 3.14) % 15; ;
                            c = paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;

                    break;

                case "Tapete 3":

                    int cont3 = 1;

                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            cont3 += 5;
                            colorT = (int)(((j + cont3) / Math.Log(cont3) / 5) % 15);
                            c = paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
                    break;

                case "Tapete 4":

                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            //colorT = (int)(Math.Sqrt(j) * Math.Sqrt(i) * j / 100) % 15; 
                            colorT = (int)((Math.Sqrt(i + 50.5) + Math.Cos(i) + 10 * j) / 2.3) % 15;
                            c = paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
                    break;

                case "Tapete 5":
                    double acum = 0;
                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            acum =+ 2.4;
                            //colorT = (int)(Math.Sqrt(j) * j / 70) % 15;
                            colorT = (int)((Math.Pow(j, acum) *  Math.Sin(acum * j) / 100) + Math.Pow(j, acum)) % 15;
                            c = paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
                    break;

                case "Tapete 6":

                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            colorT = (int)((Math.Sqrt(j) * i / 80) + 6) % 15;
                            c = paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
                    break;

                case "Tapete 7":


                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            colorT = (int)(((j * Math.Sqrt(i) * i + Math.Cos(j) * 4)) + (Math.Sqrt(j) * i + Math.Pow(i, 2)) ) / 1000 % 15; ;
                            c = paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
                    break;

                case "Tapete 8":


                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            //colorT = (int)((i + j * 0.5 * j + Math.Sin(i * 7.9)) / 40) % 15;
                            colorT = (int)(((Math.Pow(3, i * 0.01) + Math.Pow(4, j * 0.01))) % 15);
                            c = paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec; ;
                    break;

                default:
                    MessageBox.Show("Elija alguna de las opciones");
                    break;


            }
        }
    }
}
