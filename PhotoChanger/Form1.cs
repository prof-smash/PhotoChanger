using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoChanger
{
    public partial class Form1 : Form
    {
        Bitmap bmp; // create a new bitmap to be used from anywhere in the program

        public Form1()
        {
            InitializeComponent();
        }

        //do this when the "Upload" button is pressed.
        private void ogImageUpload_Click(object sender, EventArgs e)
        {
            string imageLoc; // this will hold the filepath.

            try
            {
                OpenFileDialog dialog = new OpenFileDialog(); // open a new dialog box to select a photo
                dialog.Filter = "JPG files(*.jpg)|*.jpg| PNG files|*png| All Files(*.*)|*.*"; // the allowed file types

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLoc = dialog.FileName; // set imageLoc to filepath
                    bmp = new Bitmap(imageLoc); // set the bitmap from filepath location

                    ogImage.Image = Image.FromFile(imageLoc); // set the image in ogImage picture box to the image from the filepath.

                    int width = bmp.Width; // the width of the image
                    int height = bmp.Height; // the height of the image

                    Color p;

                    //Cycle through each pixel of the bmp, gathering color data and changing it to create a new bmp in grayscale
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            p = bmp.GetPixel(x, y); // get the pixel from coordinates X and Y, obtained from the for loops
                            int alpha = p.A; // get the alpha...
                            int red = p.R; // ...the red...
                            int green = p.G; // ...the green...
                            int blue = p.B; // ...and the blue...

                            int avg = (red + green + blue) / 3; // calculate a color average

                            bmp.SetPixel(x, y, Color.FromArgb(alpha, avg, avg, avg)); // set the pixel color
                        }
                    }

                    newImage.Image = bmp; // set the newImage Picture box to the new bmp.
                }
            }
            catch(Exception) //if something goes wrong, display an error message.
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //do this when the "Save New Image" button is pressed.
        private void saveImage_Click(object sender, EventArgs e)
        {
            try
            {
                string savePath = "C:\\Users\\" + Environment.UserName + "\\Pictures\\"; // create a path to the Pictures folder
                bmp.Save(savePath + "new grayscale image.jpg"); // save the file and give it a name
                MessageBox.Show("File saved to: " + savePath, "File saved!"); // display a message box saying the file was saved.
            }
            catch (Exception) // if something goes wrong, display a box saying there was an error.
            {
                MessageBox.Show("An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void label1_Click(object sender, EventArgs e)
        {

        }*/
    }
}
