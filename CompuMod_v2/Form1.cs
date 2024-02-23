using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                        //pixelVec.SetPixel(i, j, Color.FromArgb((int)(-0.118 * i + 178), (int)(-0.071 * i + 170), (int)(0.32 * i + 49)));

                    }



                    //pixelVec.SetPixel(i, j, Color.FromArgb((int)(-0.118 * i + 178), (int)(-0.071 * i + 170), (int)(0.32 * i + 49)));
                    //if (i <= 300)
                    //{
                    //    pixelVec.SetPixel(i, j, Color.FromArgb((int)(-0.118 * i + 178), (int)(-0.071 * i + 170), (int)(0.32 * i + 49)));

                    //}
                    //else
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

        //btnTaylor
        private void button1_Click(object sender, EventArgs e)
        {
            double t = -8;
            double dt = 0.001;

            ClaseVector cv = new();


            do
            {
                cv.Xo = (t);
                //cv.Yo = Math.Pow(3, t);
                cv.Yo = Math.Log(t + 8);
                cv.color0 = Color.Red;
                cv.Encender(pixelVec);

                //Taylor
                //cv.Yo = 1 + (1.098 * (t - 0)) + (((1.206) * Math.Pow((t - 0), 2)) / 2) + (((1.325) * Math.Pow((t - 0), 3)) / 6) + (((1.456) * Math.Pow((t - 0), 4)) / 24);
                cv.Yo = 2.19 + (0.11 * (t -1)) - (0.012* Math.Pow((t-1),2)/2) + (0.0027 * Math.Pow((t - 1), 3)/6);
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
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    pixelVec.SetPixel(i, j, Color.White);
                }
            }

            ptbPixel.Image = pixelVec;
            //ClaseVector cv = new();
            //cv.Apagar(pixelVec);
            //ptbPixel.Image = pixelVec;
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
                            colorT = (int)((i + j * 0.5 * j + Math.Sin(i * 7.9))) % 15;
                            //colorT = (int)(((Math.Pow(3, i * 0.01) + Math.Pow(4, j * 0.01))) % 15);
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

        private void btnTextMade_Click(object sender, EventArgs e)
        {

        
            int colorT;
            Color c;

            Color[] paletaT = new Color[16];

            int red, green, blue;
            for (int ir = 0; ir <= 15; ir++)
            {
                red = (int)((4.666 * ir) + 130);
                green = (int)((2 * ir) + 70);
                blue = (int)((1.333 * ir) + 30);
                paletaT[ir] = Color.FromArgb(red, green, blue);
            }

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    
                    colorT = (int)((Math.Sqrt(i + 50.5) + Math.Cos(i) + 10 * j) / 2.3) % 15;
                    c = paletaT[colorT];
                    pixelVec.SetPixel(i, j, c);

                }

            }
            ptbPixel.Image = pixelVec;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tapeteSelect = cbxTexturas.SelectedItem.ToString();



            int colorT;
            Color c;



            switch (tapeteSelect)
            {
                case "Madera":

                    Color[] paletaM = new Color[16];

                    int red, green, blue;
                    int acumM = 0;

                    for (int ir = 0; ir <= 15; ir++)
                    {
                        red = (int)((-9 * ir) + 213);
                        green = (int)((-4.266 * ir) + 116);
                        blue = (int)((-2.466 * ir) + 37);
                        paletaM[ir] = Color.FromArgb(red, green, blue);
                    }

                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            acumM += 5;
                            colorT = (int)(((j + acumM) / Math.Log(acumM) / 5) % 15);
                            c = paletaM[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
                    break;

                case "Tela":

                    Color[] paletaJ = new Color[16];

               
                    double acum = 0;

                    for (int ir = 0; ir <= 15; ir++)
                    {
                        red = (int)((12.133 * ir) + 30);
                        green = (int)((9.6 * ir) + 78);
                        blue = (int)((7.6 * ir) + 138);
                        paletaJ[ir] = Color.FromArgb(red, green, blue);
                    }

                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            //acum = + 1.4;
                            //colorT = (int)(Math.Sqrt(j) * j / 70) % 15;
                            //colorT = (int)((Math.Pow(j, acum) * Math.Sin(acum * j) / 80) + Math.Pow(j, 2)) % 15;
                            //colorT = (int)((j + i * 0.5 * Math.Sqrt(j) + Math.Cos(i * 7.9))) % 15;
                            //colorT = (int)((j + i * 0.8 * Math.Sqrt(j) + Math.Sin(i * 5))) % 15;

                            //colorT = (int)(20 * Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 3)) + Math.Log(i)) % 15;
                            colorT = (int)((j * i * Math.Sin(i * j)) + (Math.Sin(j)) / Math.Log(i + j)) % 15;
                            if (colorT > 15 || colorT < 0)
                            {
                                colorT = 1;
                            }


                            c = paletaJ[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
                    break;

                case "Fuego":

                    Color[] paletaF = new Color[16];

                   

                    for (int ir = 0; ir <= 15; ir++)
                    {
                        red = (int)((10.866 * ir) + 92);
                        green = (int)((15.8 * ir) + 1);
                        blue = (int)((11.8 * ir));
                        paletaF[ir] = Color.FromArgb(red, green, blue);
                    }

                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {

                            //colorT = (int)(20 * Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 3)) + Math.Log(i)) % 15;
                            colorT = (int)((((600 + i - 2) * (600 + i - 2)) / (int)Math.PI) + ((500 + j - 2) / 6)) % 15;
                            c = paletaF[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
                    break;

                case "Cesped":

                    Color[] paletaC = new Color[16];

                    for (int ir = 0; ir <= 15; ir++)
                    {
                        red = (int)((7.866 * ir));
                        green = (int)((3.4 * ir) + 151);
                        blue = (int)((2 * ir) + 9);
                        paletaC[ir] = Color.FromArgb(red, green, blue);
                    }

                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                           
                            //colorT = (int)(((j + cont3) / Math.Log(cont3) / 5) % 15);
                            colorT = (int)((((600 - i - 1) * (600 - i - 1)) / (int)Math.PI) + ((500 - j - 1) / 2)) % 15;

                            c = paletaC[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }

                    }
                    ptbPixel.Image = pixelVec;
                    break;




            }
        }

        private void btnAnim1_Click(object sender, EventArgs e)
        {
            ClaseCurvaV cv = new();
            cv.Xo = 3;
            cv.Yo = -1;
            cv.Rd = 2;
            cv.color0 = Color.Blue;
            cv.EncenderCurvaV(pixelVec);

            ClaseCurvaV cv3 = new();
            cv3.Xo = 6;
            cv3.Yo = -6;
            cv3.Rd = 1;
            cv3.color0 = Color.Blue;
            cv3.EncenderCurvaV2(pixelVec);

            ptbPixel.Image = pixelVec;

            Application.DoEvents();
            System.Threading.Thread.Sleep(2000);



            cv.Xo = 3;
            cv.Yo = -1;
            cv.Rd = 2;
            cv.color0 = Color.White;
            cv.EncenderCurvaV(pixelVec);

            ptbPixel.Image = pixelVec;


        }

        private void btnTiro_Click(object sender, EventArgs e)
        {

            ClaseVector cv = new();
            double t = -8;
            double dt = 0.001;

            double x = -8; //8
            do
            {
                cv.Xo = x;
                cv.Yo = -((x * x) + (10 * x) + 16) / 2.25;
                cv.color0 = Color.Red;
                cv.Encender(pixelVec);
                x += 0.001;

            } while (x <= -2);

            x = -2;
            do
            {
                cv.Xo = x;
                cv.Yo = -((x * x) - 4) / 1.33;
                cv.color0 = Color.Red;
                cv.Encender(pixelVec);
                x += 0.001;

            } while (x <= 2);

            x = 2;
            do
            {
                cv.Xo = x;
                //cv.Yo = -((x * x) - (8 * x) + 12) / ;
                cv.Yo = -((x - 2) * (x - 6)) / 2.33;
                cv.color0 = Color.Red;
                cv.Encender(pixelVec);
                x += 0.001;

            } while (x <= 6);
            ptbPixel.Image = pixelVec;


            //ANIMACION

            ClaseCircunferencia cc = new();
            cc.Rd = 0.25;
            double x0;
            x0 = -8;

            do
            {
                cc.Xo = x0;
            
                //cc.Yo = -((x0 + 6) * (x0 + 1)) / 1.1;
                cc.Yo = -((x0 * x0) + (10 * x0) + 16) / 2.25;
                cc.color0 = Color.Blue;
                cc.EncenderCirc(pixelVec);
                x0 += 0.5;

                ptbPixel.Image = pixelVec;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                cc.ApagarCirc(pixelVec);
            } while (x0 <= -2);


            x0 = -2;
            do
            {
                cc.Xo = x0;
                //cc.Yo = -((x0 + 1) * (x0 - 3)) / 1.1;
                cc.Yo = -((x0 * x0) - 4) / 1.33;
                cc.color0 = Color.Blue;
                cc.EncenderCirc(pixelVec);
                x0 += 0.5;

                ptbPixel.Image = pixelVec;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                cc.ApagarCirc(pixelVec);
            } while (x0 <= 2);


            x0 = 2;
            do
            {
                cc.Xo = x0;
                //cc.Yo = -((x0 - 3) * (x0 - 5));
                cc.Yo = -((x0 - 2) * (x0 - 6)) / 2.33;
                cc.color0 = Color.Blue;
                cc.EncenderCirc(pixelVec);
                x0 += 0.5;

                ptbPixel.Image = pixelVec;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                cc.ApagarCirc(pixelVec);
            } while (x0 <= 6);

        }

        private void btnDisparo_Click(object sender, EventArgs e)
        {
            ClaseSegmento seg = new();
            //PUNTO 1
            //seg.Xo = 1;
            //seg.Yo = 1;
            //seg.Xf = 8;
            //seg.Yf = 8.33;
            //seg.color0 = Color.Red;
            //seg.EncenderSeg(pixelVec);
            //ptbPixel.Image = pixelVec;
            ////PUNTO 2
            //seg.Xo = 8;
            //seg.Yo = 8.33;
            //seg.Xf = 10;
            //seg.Yf = 6.3;
            //seg.color0 = Color.Blue;
            //seg.EncenderSeg(pixelVec);
            //ptbPixel.Image = pixelVec;

           // PUNTO 1
            seg.Xo = 1;
            seg.Yo = 1;
            seg.Xf = -6.2;
            seg.Yf = 8.33;
            seg.color0 = Color.Red;
            seg.EncenderSeg(pixelVec);
            ptbPixel.Image = pixelVec;
            //PUNTO 2
            seg.Xo = -6.2;
            seg.Yo = 8.33;
            seg.Xf = -10;
            seg.Yf = 4.64;
            seg.color0 = Color.Blue;
            seg.EncenderSeg(pixelVec);
            ptbPixel.Image = pixelVec;
        }

        private void btnCurvasNi_Click(object sender, EventArgs e)
        {
            ClaseVector cv = new();

          
            double x = -8;
            double dx = 0.0002;
            do
            {
                cv.Xo = x;
                cv.Yo = 3 * Math.Pow(Math.E,-4 * x);
                cv.color0 = Color.Green;
                cv.Encender(pixelVec);
                x += dx;

                cv.Xo = x;
                cv.Yo = 6 * Math.Pow(Math.E, -4 * x);
                cv.color0 = Color.Green;
                cv.Encender(pixelVec);
                x += dx;

                cv.Xo = x;
                cv.Yo = 8 * Math.Pow(Math.E, -4 * x);
                cv.color0 = Color.Red;
                cv.Encender(pixelVec);
                x += dx;

                cv.Xo = x;
                cv.Yo = 9 * Math.Pow(Math.E, -4 * x);
                cv.color0 = Color.Green;
                cv.Encender(pixelVec);
                x += dx;

                cv.Xo = x;
                cv.Yo = -3 * Math.Pow(Math.E, -4 * x);
                cv.color0 = Color.Red;
                cv.Encender(pixelVec);
                x += dx;

                cv.Xo = x;
                cv.Yo = -4 * Math.Pow(Math.E, -4 * x);
                cv.color0 = Color.Green;
                cv.Encender(pixelVec);
                x += dx;

                cv.Xo = x;
                cv.Yo = -7 * Math.Pow(Math.E, -4 * x);
                cv.color0 = Color.Green;
                cv.Encender(pixelVec);
                x += dx;

            } while (x <= 8);
            ptbPixel.Image = pixelVec;

        }

        private void btnPracticaPP2_Click(object sender, EventArgs e)
        {
            //Animacion letra
            ClaseSegmento cs = new();
            cs.Xo = 1;
            cs.Yo = 1;
            cs.Xf = 1;
            cs.Yf = 5;
            cs.color0 = Color.Red;
            cs.EncenderSeg(pixelVec);

            cs.Xo = 1;
            cs.Yo = 1;
            cs.Xf = -3;
            cs.Yf = 5;
            cs.color0 = Color.Red;
            cs.EncenderSeg(pixelVec);

            ptbPixel.Image = pixelVec;

            //Animación

            ClaseCircunferencia cc = new();
            cc.Rd = 0.25;
            double x0 = 1; // punto de inicio
            double y0 = 1;

            //do
            //{
            //    cc.Xo = x0;
            //    cc.Yo = y0;
            //    cc.color0 = Color.Green;
            //    cc.EncenderCirc(pixelVec);
            //    x0 -= 0.5;
            //    y0 -= 0.5;
            //    ptbPixel.Image = pixelVec;
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(100);
            //    cc.ApagarCirc(pixelVec);
            //} while (y0 <= -3);


            ///Crear dos curvas y en medio relizar una animacion
            ///



            ClaseVector cv = new();
            double t = -4;


            do
            {
                cv.Xo = t;
                cv.Yo = ((t + 6) * (t - 5)) / 12;
                cv.color0 = Color.Red;

                cv.Encender(pixelVec);

                t = t + 0.001;

            } while (t <= 4);

            ptbPixel.Image = pixelVec;

            ClaseVector cv2 = new();
            double t2 = -4;

            do
            {
                cv2.Xo = t2;
                cv2.Yo = ((t2 + 6) * (t2 - 5)) / 12 + 4;
                cv2.color0 = Color.Red;

                cv2.Encender(pixelVec);

                t2 = t2 + 0.001;

            } while (t2 <= 4);

            ptbPixel.Image = pixelVec;


            //Animacion

            //ClaseCircunferencia cc = new();
            cc.Rd = 0.1;
            //double x0 = -4; // punto de inicio
            //double y0 = 1;

            do
            {
                cc.Xo = x0;
                cc.Yo = (((x0 + 6) * (x0 - 5)) / 12) + 2;
                cc.color0 = Color.Green;
                cc.EncenderCirc(pixelVec);
                x0 += 0.5;
                ptbPixel.Image = pixelVec;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
                //cc.ApagarCirc(pixelVec);
            } while (x0 <= 4);






        }

        private async void Pract2_Click(object sender, EventArgs e)
        {
            ////Animar una curva

            //double t = 0;
            //double dt = 0.001;


            //ClaseCircunferencia cc = new();
            //ClaseVector cv = new();

            //double Rd = 2;
            //double PosX = cc.Xo;
            //double PosY = cc.Yo;
            //do
            //{
            //    //cc.Xo = 1 + Rd * Math.Sin(2 * t);
            //    //cc.Yo = 1 + Rd * Math.Cos(3 * t);

            //    cc.Xo = 1 + Rd * Math.Cos(4 * t) * Math.Cos(t);
            //    cc.Yo = 1 + Rd * Math.Cos(4 * t) * Math.Sin(t);
            //    cc.color0 = Color.Green;
            //    cc.Encender(pixelVec);
            //    t = t + dt;

            //} while (t <= 2 * Math.PI);

            //ptbPixel.Image = pixelVec;


            //ClaseCircunferencia cc1 = new();
            //cc1.Rd = 0.10;
            //double x0 = -4; // punto de inicio
            ////double y0 = 1;

            //do
            //{
            //    //cc1.Xo = 1 + Rd * Math.Sin(2 * x0); 
            //    //cc1.Yo = 1 + Rd * Math.Cos(3 * x0);

            //    cc1.Xo = 1 + Rd * Math.Cos(4 * x0) * Math.Cos(x0);
            //    cc1.Yo = 1 + Rd * Math.Cos(4 * x0) * Math.Sin(x0);
            //    cc1.color0 = Color.Green;
            //    cc1.EncenderCirc(pixelVec);
            //    x0 += 0.5;
            //    ptbPixel.Image = pixelVec;
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(500);
            //    cc1.color0 = Color.White;
            //    cc1.ApagarCirc(pixelVec);



            //} while (x0 <= 4);

            //// Reloj

            //ClaseCircunferencia cc = new();
            //cc.Rd = 2;
            //cc.Xo = 2;
            //cc.Yo = 2;
            //cc.color0 = Color.Blue;
            //cc.EncenderCirc(pixelVec);
            //ptbPixel.Image = pixelVec;

            ////Segmento a girar
            //ClaseSegmento cs = new();
            //cs.Xo = 2;
            //cs.Yo = 2;

            //double t = 0;
            //double dt = 0.1;

            //do
            //{
            //    //cv.Xo = Xo + Rd * Math.Cos(t);
            //    //cv.Yo = Yo + Rd * Math.Sin(t);

            //    cs.Xf = cs.Xo + (cc.Rd - 0.05) * Math.Sin(t);
            //    cs.Yf = cs.Yo + (cc.Rd - 0.05) * Math.Cos(t);


            //    cs.color0 = Color.Red;
            //    cs.EncenderSeg(pixelVec);

            //    ptbPixel.Image = pixelVec;

            //    //Application.DoEvents();
            //    //System.Threading.Thread.Sleep(100);
            //    ptbPixel.Refresh();
            //    await Task.Delay(50);

            //    cs.ApagarSeg(pixelVec);
            //    ptbPixel.Image = pixelVec;
            //    //t -= dt; // va borrando de poco a poco  el circulo
            //    t = t + dt;
            //} while (t <= 2 * Math.PI);



            //Animar un segmento
            ClaseSegmento cs = new();

            cs.Xo = 1;
            cs.Yo = 1;
            cs.Xf = -7;
            cs.Yf = -7;
            //cs.color0 = Color.Brown;
            //cs.EncenderSeg(pixelVec);
            //ptbPixel.Image = pixelVec;

            ClaseVector cv = new();
            double t = 0, dt = 0.1;
            do
            {
                cs.Xo = cs.Xo + (cs.Xf - cs.Xo) * t;
                cs.Yo = cs.Yo + (cs.Yf - cs.Yo) * t;
                cs.color0 = Color.Red;
                cs.EncenderSeg(pixelVec);
                //t += dt;
                ptbPixel.Image = pixelVec;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
                cs.ApagarSeg(pixelVec);
                ptbPixel.Image = pixelVec;
                t += dt;
            }
            while (t <= 2);

            ////////////////
            ///
            ////Animar una curva

            //double t = 0;
            //double dt = 0.001;


            //ClaseCircunferencia cc = new();
            //ClaseVector cv = new();

            //double Rd = 2;
            //double PosX = cc.Xo;
            //double PosY = cc.Yo;
            //do
            //{
            //    cc.Xo = 1 + Rd * Math.Sin(2 * t);
            //    cc.Yo = 1 + Rd * Math.Cos(3 * t);

            //    //cc.Xo = 1 + Rd * Math.Cos(4 * t) * Math.Cos(t);
            //    //cc.Yo = 1 + Rd * Math.Cos(4 * t) * Math.Sin(t);
            //    cc.color0 = Color.Green;
            //    cc.Encender(pixelVec);
            //    t = t + dt;

            //} while (t <= 2 * Math.PI);

            //ptbPixel.Image = pixelVec;


        }

        private void Pract3PP_2_Click(object sender, EventArgs e)
        {
            ClaseCircunferencia cc = new();
            cc.Rd = 0.2;
            double x0 = 1;
            //do
            //{
            //    cc.Xo = x0;
            //    cc.Yo = x0;
            //    cc.color0 = Color.Green;
            //    cc.EncenderCirc(pixelVec);
            //    x0 += 0.1;
            //    ptbPixel.Image = pixelVec;

            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(100);
            //    //cc.ApagarCirc(pixelVec);

            //} while (x0 <= 3);

            double x1 = -1;
            do
            {
                cc.Xo = x1;
                cc.Yo = (((-0.168) * Math.Pow(x1, 2)) + ((2.10) * x1) + (2.27));
                cc.color0 = Color.Green;
                cc.EncenderCirc(pixelVec);
                x1 += 0.1;
                ptbPixel.Image = pixelVec;

                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
                cc.ApagarCirc(pixelVec);

            } while (x1 <= 10);



        }

        private void btnPP2_Click(object sender, EventArgs e)
        {
            ClaseSegmento seg = new();
          

            // PUNTO 1
            seg.Xo = -1;
            seg.Yo = 0;
            seg.Xf = -2;
            seg.Yf = -8.33;
            seg.color0 = Color.Blue;
            seg.EncenderSeg(pixelVec);
            ptbPixel.Image = pixelVec;
            //PUNTO 2
            seg.Xo = -2;
            seg.Yo = -8.33;
            seg.Xf = -4.20;
            seg.Yf = 10;
            seg.color0 = Color.Blue;
            seg.EncenderSeg(pixelVec);
            ptbPixel.Image = pixelVec;




            //ClaseCircunferencia cc = new();
            //cc.Rd = 0.15;
            //double x0, dx;

            //x0 = -1;
            //dx = 0.5;
            //do
            //{
            //    cc.Xo = x0;

            //    //cc.Yo = -((x0 + 6) * (x0 + 1)) / 1.1;
            //    cc.Yo = (2.776 * x0 + 2.776);
            //    cc.color0 = Color.Blue;
            //    cc.EncenderCirc(pixelVec);
            //    x0 += dx;

            //    ptbPixel.Image = pixelVec;
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(500);

            //    //cc.ApagarCirc(pixelVec);
            //} while (x0 <= 2);

            //x0 = 2;

            //do
            //{
            //    cc.Xo = x0;

            //    //cc.Yo = -((x0 + 6) * (x0 + 1)) / 1.1;
            //    cc.Yo = -2.776 * x0 + 13.882;
            //    cc.color0 = Color.Blue;
            //    cc.EncenderCirc(pixelVec);
            //    x0 += dx;

            //    ptbPixel.Image = pixelVec;
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(500);

            //    //cc.ApagarCirc(pixelVec);
            //} while (x0 <= 9);



            ClaseCircunferencia cc = new();
            cc.Rd = 0.15;
            double x0, dx;

            x0 = -4.20;
            dx = 0.5;
            do
            {
                cc.Xo = x0;

                //cc.Yo = -((x0 + 6) * (x0 + 1)) / 1.1;
                //cc.Yo = (8.33 * (x0) + 8.33);
                cc.Yo = (-8.33 * (x0) + 24.99);
                cc.color0 = Color.Blue;
                cc.EncenderCirc(pixelVec);
                x0 += dx;

                ptbPixel.Image = pixelVec;
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);

                //cc.ApagarCirc(pixelVec);
            } while (x0 <= -2);

            //x0 = 2;

            //do
            //{
            //    cc.Xo = x0;

            //    //cc.Yo = -((x0 + 6) * (x0 + 1)) / 1.1;
            //    cc.Yo = -2.776 * x0 + 13.882;
            //    cc.color0 = Color.Blue;
            //    cc.EncenderCirc(pixelVec);
            //    x0 += dx;

            //    ptbPixel.Image = pixelVec;
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(500);

            //    //cc.ApagarCirc(pixelVec);
            //} while (x0 <= 9);

        }

        //Tercer parcial
        private void btn3d_1_Click(object sender, EventArgs e)
        {
            ClaseVector3D cv3d = new();
            double t;
            t = 0;
            do
            {
                cv3d.Xo = (t / 3) - 2;
                cv3d.Yo = 1 + (3 * Math.Sin(t));//t / 2;
                cv3d.Zo = 2 + (3 * Math.Cos(t)); 
                cv3d.color0 = Color.Black;
                cv3d.Encender3D(pixelVec);
                t = t + 0.001;
            } while (t <= 15);
            ptbPixel.Image = pixelVec;
        }

        private void btnEjes3D_Click(object sender, EventArgs e)
        {
            ClaseSegmento csX = new ClaseSegmento();
            csX.color0 = Color.Black;
            csX.Xo = 0;
            csX.Yo = 0;
            csX.Xf = 10;
            csX.Yf = 0;
            csX.EncenderSeg(pixelVec);

            ClaseSegmento csZ = new ClaseSegmento();
            csZ.color0 = Color.Black;
            csZ.Xo = 0;
            csZ.Yo = 0;
            csZ.Xf = 0;
            csZ.Yf = 8.33;
            csZ.EncenderSeg(pixelVec);

            ClaseSegmento csY = new ClaseSegmento();
            csY.color0 = Color.Black;
            csY.Xo = 0;
            csY.Yo = 0;
            csY.Xf = 10;
            csY.Yf = 8.33;
            csY.EncenderSeg(pixelVec);

            ptbPixel.Image = pixelVec;
        }

        private void btn3D_2_Click(object sender, EventArgs e)
        {
            ClaseVector3D cv3d = new();
            double t, dt, h, dh, Rd;
            t = 0;
            h = 0;
            dt = 0.1;
            dh = 0.2;
            Rd = 2;
            do
            {
                do
                {
                    cv3d.Xo = -5 + 2 * Math.Cos(t); //los 1 dan la posicion a la superficie
                    cv3d.Yo = 1 + 3 * Math.Sin(t);
                    cv3d.Zo = 3 + (h / 3);
                    cv3d.color0 = Color.Blue;
                    cv3d.Encender3D(pixelVec);
                    h = h + dh;

                } while (h <= 9);
                t = t + dt;
                h = 0;
            } while (t <= 6.3);
            ptbPixel.Image = pixelVec;


            double t1 = 0;
            double h1 = 0;
            dt = 0.1;
            dh = 0.2;

            do
            {
                do
                {
                    cv3d.Xo = 5 + Rd * Math.Cos(t1) * Math.Cos(h1);
                    cv3d.Yo = 5 +  Rd * Math.Cos(t1) * Math.Sin(h1);
                    cv3d.Zo = 1 + Rd * Math.Sin(t1);
                    cv3d.color0 = Color.Red;
                    cv3d.Encender3D(pixelVec);
                    h1 = h1 + dh;

                } while (h1 <= 6.3);
                t1 = t1 + dt;
                h1 = 0;
            } while (t1 <= 6.3);
            ptbPixel.Image = pixelVec;


            double t2 = 0;
            double h2 = 0;
            dt = 0.04;
            dh = 0.07;
            //
            do
            {
                h2 = 0;
                do
                {
                    cv3d.Xo = -4 + 1 * (2.4 + Math.Cos(t2)) * Math.Cos(h2);
                    cv3d.Yo = -4 + 1 * (2.4 + Math.Cos(t2)) * Math.Sin(h2);
                    cv3d.Zo = -1 + 1 * Math.Sin(t2);
                    cv3d.color0 = Color.Green;
                    cv3d.Encender3D(pixelVec);
                    h2 = h2 + dh;

                } while (h2 <= 2 *Math.PI);
                t2 = t2 + dt;
               
            } while (t2 <= 2 * Math.PI);
            ptbPixel.Image = pixelVec;

        }

        private void btnPlano3D_Click(object sender, EventArgs e)
        {
            //ClaseSegmento csZ = new ClaseSegmento();
            //csZ.color0 = Color.Black;
            //csZ.Xo = 0;
            //csZ.Yo = 0;
            //csZ.Xf = 0;
            //csZ.Yf = 8.33;
            //csZ.EncenderSeg(pixelVec);
            ClaseSegmento cs = new();
            cs.color0 = Color.Blue;
            cs.Xo = -10;
            cs.Yo = -6.13;
            cs.Xf = 10;
            cs.Yf = -6.13;
            cs.EncenderSeg(pixelVec);

            cs.Xo = -10;
            cs.Yo = -6.63;
            cs.Xf = 10;
            cs.Yf = -6.63;
            cs.EncenderSeg(pixelVec);

            cs.Xo = -10;
            cs.Yo = -7.33;
            cs.Xf = 10;
            cs.Yf = -7.33;
            cs.EncenderSeg(pixelVec);

            ///
            cs.Xo = 0.5;
            cs.Yo = -6.13;
            cs.Xf = 2;
            cs.Yf = -8.33;
            cs.EncenderSeg(pixelVec);

            cs.Xo = 1.5;
            cs.Yo = -6.13;
            cs.Xf = 5;
            cs.Yf = -8.33;
            cs.EncenderSeg(pixelVec);

            cs.Xo = 3;
            cs.Yo = -6.13;
            cs.Xf = 9;
            cs.Yf = -8.33;
            cs.EncenderSeg(pixelVec);

            cs.Xo = 5;
            cs.Yo = -6.13;
            cs.Xf = 10;
            cs.Yf = -7.33;
            cs.EncenderSeg(pixelVec);

            //

            cs.Xo = -0.5;
            cs.Yo = -6.13;
            cs.Xf = -2;
            cs.Yf = -8.33;
            cs.EncenderSeg(pixelVec);

            cs.Xo = -1.5;
            cs.Yo = -6.13;
            cs.Xf = -5;
            cs.Yf = -8.33;
            cs.EncenderSeg(pixelVec);

            cs.Xo = -3;
            cs.Yo = -6.13;
            cs.Xf = -9;
            cs.Yf = -8.33;
            cs.EncenderSeg(pixelVec);

            cs.Xo = -5;
            cs.Yo = -6.13;
            cs.Xf = -10;
            cs.Yf = -7.33;
            cs.EncenderSeg(pixelVec);

            ptbPixel.Image = pixelVec;



        }

        private void btnOnda_1_Click(object sender, EventArgs e)
        {
            ClaseOnda co = new ClaseOnda();
            // d =  Distancia del punto(x, y)
            co.w = 1.5; 
            co.v = 9.3;   
            co.m = 1;    
            co.t = 0;

            co.GrafOnda(pixelVec);
            ptbPixel.Image = pixelVec;

            //double tp = 0;
            //double dtp = 0.1;
            //do
            //{
            //    co.t = tp;
            //    co.GrafOnda(pixelVec);
            //    ptbPixel.Image = pixelVec;
            //    System.Windows.Forms.Application.DoEvents();
            //    tp += dtp;
            //} while (tp <= 7);

            
        }

       
        private void btnInterf_1_Click(object sender, EventArgs e)
        {
            ClaseOnda co = new ClaseOnda();
            co.w = 1.5;  //Inversamente propocional a la longitud de onda
            co.v = 9.3;
            co.m = 1;
            co.t = 1;
            co.Interferencia2(pixelVec);
            ptbPixel.Image = pixelVec;

            //Animación
            //double tp = 0;
            //double dtp = 0.05; // velocidad de la animacion
            //do
            //{
            //    co.t = tp;
            //    co.Interferencia2(pixelVec);
            //    ptbPixel.Image = pixelVec;
            //    System.Windows.Forms.Application.DoEvents(); //Procesa mensajes pendientes
            //    tp += dtp;
            //} while (tp <= 2);
        }

        private void btnGraf3D1_Click(object sender, EventArgs e)
        {
            ClaseOnda co = new ClaseOnda();
            co.w = 2;  //Inversamente propocional a la longitud de onda
            co.v = 9.3;
            co.m = 0.4;
            co.t = 0; //Ojo cambia mucho este parametro 

            co.GrafOnda3D(pixelVec);
            ptbPixel.Image = pixelVec;

            //Animación
            //double tp = 0.5;
            //double dtp = 0.01; //Velocidad 
            //do
            //{
            //    co.t = tp;
            //    co.GrafOnda3D(pixelVec);
            //    ptbPixel.Image = pixelVec;
            //    tp += dtp;
            //    System.Windows.Forms.Application.DoEvents();
            //    co.ApagarGrafOnda1(pixelVec);
            //    ptbPixel.Image = pixelVec;


            //    //tp += dtp;
            //} while (tp <= 30);

            ////
        }
       

        private void btnGraf3d2_Click(object sender, EventArgs e)
        {
            ClaseOnda co = new();
            co.w = 2;
            co.v = 9.3;
            co.m = 0.4;
            co.t = 0;


            //co.GrafOnda3D2(pixelVec);
            //ptbPixel.Image = pixelVec;

            //Animación
            double tp = 0.5;
            double dtp = 0.01; //Velocidad
            do
            {
                co.t = tp;
                co.GrafOnda3D2(pixelVec);
                tp += dtp;
                System.Windows.Forms.Application.DoEvents();
                co.ApagarGrafOnda3D2(pixelVec);
                ptbPixel.Image = pixelVec;
            } while (tp <= 30);

        }

     
        private void btnO1_Click(object sender, EventArgs e)
        {

            ClaseOnda co = new ClaseOnda();
            co.w = 1.5;
            co.v = 9.3;
            co.m = 1;
            co.t = 0;

            co.GrafOnda(pixelVec);
            ptbPixel.Image = pixelVec;

           
            double[, ,] datosMatriz = co.ObtenerDatosMatriz(pixelVec);

            // Asignar la matriz al DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;

            for (int i = 0; i < 60; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < 50; j++)
                {
                    dataGridView1.Rows.Add(datosMatriz[i, j, 0], datosMatriz[i, j, 1], datosMatriz[i, j, 2]);
                }

                dataGridView1.Rows.Add(row);
            }


        }

        private void btn3dInf_Click(object sender, EventArgs e)
        {
            ClaseOnda co = new ClaseOnda();
            co.w = 2;  //Inversamente propocional a la longitud de onda
            co.v = 9.3;
            co.m = 0.4;
            co.t = 0; //Ojo cambia mucho este parametro 

            co.GrafOnda3Infor(pixelVec);
            ptbPixel.Image = pixelVec;

            //ClaseOnda co = new ClaseOnda();
            double[,,] datosMatriz = co.GrafOnda3Infor(pixelVec);

            // Asignar la matriz al DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;

            for (int i = 0; i < 60; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < 50; j++)
                {
                    dataGridView1.Rows.Add(datosMatriz[i, j, 0], datosMatriz[i, j, 1], datosMatriz[i, j, 2]);
                }

                dataGridView1.Rows.Add(row);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseCuerda cuer = new();
            cuer.t = 3.37;
            cuer.Grafico(pixelVec);
            ptbPixel.Image = pixelVec;
        }

        private void AnimFourier_Click(object sender, EventArgs e)
        {
            ClaseCuerda cuer = new();

            double tp, dtp;
            tp = 0.5;
            dtp = 0.007; //Velocidad
            //cuer.t = 3.37;
            do
            {
                cuer.t = tp;
                cuer.Grafico(pixelVec);
                ptbPixel.Image = pixelVec;
                tp += dtp;
                System.Windows.Forms.Application.DoEvents();
                cuer.ApagGrafico(pixelVec);
                ptbPixel.Image = pixelVec;
            } while (tp <= 30);

        }

        // Función diferencial
        static double RungeKutta(double t, double y, double k, double M)
        {
            return k * y * (M - y);
        }

        private void btnRungeKut_Click(object sender, EventArgs e)
        {

            // Parámetros y condiciones iniciales
            double k = 0.001;
            double M = 503; //Población 
            double h = 1.0;

            double t0 = 0;
            double y0 = 1;
            //double tf = 10;

            //tiempo final(tf) = número de interaciones 
            int tf = 30;

   
            double y = y0;
            double t = t0;

            double[,] resultados = new double[tf + 1, 2];  

            resultados[0, 0] = t;  
            resultados[0, 1] = y;

            //Bucle de datos
            int i = 0;
            //for (int i = 0; i < tf; i++)
            do
            {
                //Cálculos del Runge - Kutta
                double k1 = h * RungeKutta(t, y, k, M);
                double k2 = h * RungeKutta(t + h / 2, y + k1 / 2, k, M);
                double k3 = h * RungeKutta(t + h / 2, y + k2 / 2, k, M);
                double k4 = h * RungeKutta(t + h, y + k3, k, M);

                y += (1.0 / 6.0) * (k1 + 2 * k2 + 2 * k3 + k4);
                //y = M / (1 + (M - k / k) * Math.Pow(Math.E, -M * k * t));
                t += h;

                resultados[i, 0] = t;
                resultados[i, 1] = y;
                i++;
            } while (i < tf);

            dgvRunge1.Columns.Add("Tiempo", "Tiempo");
            dgvRunge1.Columns.Add("Enfermos", "Enfermos");

            //Mostrar datos de la matriz 
            for (int j = 0; j <= tf; j++)
            {
                dgvRunge1.Rows.Add(resultados[j, 0], resultados[j, 1]);
            }
        }

        private void btnGrafRunge_Click(object sender, EventArgs e)
        {
            double k = 0.001;
            double M = 503; //Población 
            double h = 0.01;//1.0;
            double t0 = 0;
            double y0 = 1;
            int tf = 30;
            double y = y0;
            double t = t0;

            ///
         
            double dt = 0.001;

            ClaseVector cv = new();

            
            do
            {
                cv.Xo = t;
                double k1 = h * RungeKutta(t, y, k, M);
                double k2 = h * RungeKutta(t + h / 2, y + k1 / 2, k, M);
                double k3 = h * RungeKutta(t + h / 2, y + k2 / 2, k, M);
                double k4 = h * RungeKutta(t + h, y + k3, k, M);
                y += (1.0 / 6.0) * (k1 + 2 * k2 + 2 * k3 + k4);

                cv.Yo = y;
                cv.color0 = Color.Red;
                cv.Encender(pixelVec);

                t += h;
               
            } while (t < tf);
        
            ptbPixel.Image = pixelVec;


        }

        private void btnPracPP3_Click(object sender, EventArgs e)
        {
            //ClaseCuerda cc = new();
            //cc.GrafPracZ(pixelVec);
            //ptbPixel.Image = pixelVec;

            //Animation
            //double tp = 0.5; //saltos de iteracion
            //double dtp = 0.005; //velocidad
            //do
            //{
            //    cc.t = tp;
            //    cc.GrafPracZ(pixelVec);
            //    ptbPixel.Image = pixelVec;
            //    tp += dtp;
            //    System.Windows.Forms.Application.DoEvents();
            //    cc.ApagGrafPracZ(pixelVec);
            //    ptbPixel.Image = pixelVec;
            //} while (tp <= 30);

            ///Interferencia 11
            ClaseOnda co = new ClaseOnda();
            co.w = 1.5;  //Inversamente propocional a la longitud de onda
            co.v = 9.3;
            co.m = 1;
            co.t = 1.2;
            //co.PractPP3(pixelVec);
            //ptbPixel.Image = pixelVec;

            //Animación
            double tp = 0;
            double dtp = 0.05; // velocidad de la animacion
            do
            {
                co.t = tp;
                co.PractPP3(pixelVec);
                ptbPixel.Image = pixelVec;
                System.Windows.Forms.Application.DoEvents(); //Procesa mensajes pendientes
                tp += dtp;
            } while (tp <= 2);


        }

        private void btnModAn_Click(object sender, EventArgs e)
        {

            // Parámetros y condiciones iniciales
            double k = 0.001;
            double M = 503; //Población 
            double h = 1.0;

            double t0 = 0;
            double y0 = 1;
            //double tf = 10;

            //tiempo final(tf) = número de interaciones 
            int tf = 30;


            double y = y0;
            double t = t0;

            double[,] resultados = new double[tf + 1, 2];

            resultados[0, 0] = t;
            resultados[0, 1] = y;

            //Bucle de datos
            int i = 0;
            //for (int i = 0; i < tf; i++)
            do
            {
                y = M / (1 + (M - k / k) * Math.Pow(Math.E, -M * k * t));
                t += h;

                resultados[i, 0] = t;
                resultados[i, 1] = y;
                i++;
            } while (i < tf);

            dgvAnalitico.Columns.Add("Tiempo", "Tiempo");
            dgvAnalitico.Columns.Add("Enfermos", "Enfermos");

            //Mostrar datos de la matriz 
            for (int j = 0; j <= tf; j++)
            {
                dgvAnalitico.Rows.Add(resultados[j, 0], resultados[j, 1]);
            }

        }

        private void btnGrafAn_Click(object sender, EventArgs e)
        {
            double k = 0.001;
            double M = 503; //Población 
            double h = 0.01;//1.0;
            double t0 = 0;
            double y0 = 1;
            int tf = 30;
            double y = y0;
            double t = t0;

            ///

            double dt = 0.001;

            ClaseVector cv = new();


            do
            {
                cv.Xo = t;
                //double k1 = h * RungeKutta(t, y, k, M);
                //double k2 = h * RungeKutta(t + h / 2, y + k1 / 2, k, M);
                //double k3 = h * RungeKutta(t + h / 2, y + k2 / 2, k, M);
                //double k4 = h * RungeKutta(t + h, y + k3, k, M);
                //y += (1.0 / 6.0) * (k1 + 2 * k2 + 2 * k3 + k4);
                y = M / (1 + (M - k / k) * Math.Pow(Math.E, -M * k * t));

                cv.Yo = y;
                cv.color0 = Color.Blue;
                cv.Encender(pixelVec);

                t += h;

            } while (t < tf);

            ptbPixel.Image = pixelVec;

        }

        private void PracExPP1_Click(object sender, EventArgs e)
        {
            ClaseSegmento cs = new();
            cs.Xo = 0;
            cs.Yo = 2;
            cs.Xf = 3;
            cs.Yf = 2;
            cs.color0 = Color.Red;
            cs.EncenderSeg(pixelVec);

            cs.Xo = 0;
            cs.Yo = 2;
            cs.Xf = 1.5;
            cs.Yf = 5;
            cs.color0 = Color.Red;
            cs.EncenderSeg(pixelVec);

            cs.Xo = 3;
            cs.Yo = 2;
            cs.Xf = 1.5;
            cs.Yf = 5;
            cs.color0 = Color.Red;
            cs.EncenderSeg(pixelVec);
            ptbPixel.Image = pixelVec;

            ClaseCircunferencia cc = new();
            cc.Rd = 0.2;
            double x0 = 1.5;
            do
            {
                cc.Xo = x0;
                cc.Yo = (2 * x0 + 2); // de a b
                //cc.Yo = 2; //a c
                //cc.Yo = 5 * x0 - 5;//b c
                //(2.776 * x0 + 2.776);
                cc.color0 = Color.Green;
                cc.EncenderCirc(pixelVec);
                x0 += 0.1;
                ptbPixel.Image = pixelVec;

                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
                //cc.ApagarCirc(pixelVec);

            } while (x0 <= 3);
        }

        private void btn_P_PP2_Click(object sender, EventArgs e)
        {
            ClaseSegmento cs = new();
            cs.Xo = 0;
            cs.Yo = 0;
            cs.Xf = 3;
            cs.Yf = 3;
            cs.color0 = Color.Green;
            cs.EncenderSeg(pixelVec);
            ptbPixel.Image = pixelVec; 

            ClaseVector cv = new();
            double t = 3;
            double dt = 0.001;
            do
            {
                cv.Xo = t;
                cv.Yo = (-(0.38) * Math.Pow(t, 2)) + ((3.5) * t) - (4.12);
                cv.color0 = Color.Blue;
                cv.Encender(pixelVec);
                
                t = t + dt;
            } while (t <= 7);

            ptbPixel.Image = pixelVec;

            // Animacion
            ClaseCircunferencia cc = new();
            cc.Rd =  0.1;
            double xo = 0;
            do
            {
                cc.Xo = xo;
                //cc.Yo = (-(0.38) * Math.Pow(xo, 2)) + ((3.5) * xo) - (4.12);
                cc.Yo = xo;
                cc.color0 = Color.Red;
                cc.EncenderCirc(pixelVec);
                xo = xo + 0.1;
                ptbPixel.Image = pixelVec;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
                cc.ApagarCirc(pixelVec);

            } while (xo <= 3);

            



        }
    }
}
