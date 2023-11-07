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
    public partial class Form1 : Form
    {
        Bitmap pixelVec = new Bitmap(600, 500); //Demencion de la ventana

        public Form1()
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

                    pixelVec.SetPixel(i, j, Color.FromArgb((int)(-0.118 * i + 178), (int)(-0.071 * i + 170), (int)(0.32 * i + 49)));
                }
            }
            ptbPixel.Image = pixelVec;
        }

        
    }
}
