using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_VCCD_MS_MakeRandomBoxOfColor
{
   public partial class MakeRandomBoxOfColor : Form
   {
      public MakeRandomBoxOfColor()
      {
         InitializeComponent();
      }

        private void Form1_Load(object sender, EventArgs e)
        {
         int width = 500, height = 100;

         //bitmap
         Bitmap bmp = new Bitmap(width,height);

         //random number
         Random rand = new Random();

         //create random pixels
         for (int y = 0; y < height; y++)
         {
            for (int x = 0; x < width; x++)
            {
               //generate and set ARGB value 
               if (x <= 100)
               {
                  int a = textBox1.Text;
                  int r = 255;
                  int g = 0;
                  int b = 0;
                  bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
               }
               else if (x <= 200)
               {
                  int a = 250;
                  int r = 0;
                  int g = 255;
                  int b = 0;
                  bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
               }
               else if (x <= 300)
               {
                  int a = 250;
                  int r = 0;
                  int g = 0;
                  int b = 255;
                  bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
               }
               else if (x <= 400)
               {
                  int a = 250;
                  int r = 0;
                  int g = 234;
                  int b = 255;
                  bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
               }
               else if (x <= 500)
               {
                  int a = 250;
                  int r = 145;
                  int g = 0;
                  int b = 255;
                  bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
               }
            }
         }

         //load bmp in picturebox1
         pictureBox1.Image = bmp;

         //save (write) random pixel image
         bmp.Save("C:\\Users\\USER\\Downloads\\Hasil\\RandomImageOfColor.png");         
        }

      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }

      private void label20_Click(object sender, EventArgs e)
      {

      }

      private void label19_Click(object sender, EventArgs e)
      {

      }

      private void label18_Click(object sender, EventArgs e)
      {

      }

      private void label17_Click(object sender, EventArgs e)
      {

      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
         {
            e.Handled = true;
         }

         // only allow one decimal point
         if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
         {
            e.Handled = true;
         }
      }
   }
}
