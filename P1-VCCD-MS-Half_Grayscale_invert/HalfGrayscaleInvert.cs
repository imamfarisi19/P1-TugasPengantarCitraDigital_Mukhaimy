using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_VCCD_MS_Half_Grayscale_invert
{
   public partial class HalfGrayscaleInvert : Form
   {
      public HalfGrayscaleInvert()
      {
         InitializeComponent();
      }
      Bitmap newBitmap;
      Image file;
      Boolean opened = false;
      private void button1_Click(object sender, EventArgs e)
      {
         DialogResult dr = openFileDialog1.ShowDialog();

         if (dr == DialogResult.OK)
         {
            file = Image.FromFile(openFileDialog1.FileName);
            newBitmap = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = file;
            opened = true;
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         if (opened == true)
         {
            for (int x = 0; x < newBitmap.Width; x++)
            {
               for (int y = 0; y < newBitmap.Height; y++)
               {
                  if (x <= (newBitmap.Width / 2))
                  {
                     //change to Grayscale color
                     Color originalColor = newBitmap.GetPixel(x, y);
                     int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));
                     Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                     newBitmap.SetPixel(x, y, newColor);
                  }
                  else if (x >= (newBitmap.Width / 2))
                  {
                     //change to invert color
                     Color pixel = newBitmap.GetPixel(x, y);
                     int red = pixel.R;
                     int green = pixel.G;
                     int blue = pixel.B;
                     newBitmap.SetPixel(x, y, Color.FromArgb(255 - red, 255 - green, 255 - blue));
                  }
               }
            }
            pictureBox2.Image = newBitmap;
            newBitmap.Save("C:\\Users\\USER\\Downloads\\Hasil\\Hasil Half Grayscale and Invert.png");
         }
         else
         {
            MessageBox.Show("Please! upload an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

        private void HalfGrayscaleInvert_Load(object sender, EventArgs e)
        {

        }
    }
}
