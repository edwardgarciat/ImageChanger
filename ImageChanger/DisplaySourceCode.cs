using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageChanger
{
    public partial class DisplaySourceCode : Form
    {
        public DisplaySourceCode()
        {
            InitializeComponent();
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDocument = new OpenFileDialog();
            if (openDocument.ShowDialog() == DialogResult.OK)
            {
                 originalImage.Image = new Bitmap(openDocument.FileName);
            }
        }

        private void lightGrayButton_Click(object sender, EventArgs e)
        {
            Bitmap copyBitmap = new Bitmap((Bitmap)originalImage.Image);
            modifyImage(copyBitmap);
            lighGrayDisplay.Image = copyBitmap;
        }

        public bool modifyImage(Bitmap change)
        {
            for (int i = 0; i < change.Width; i++)
            {
                for (int j = 0; j < change.Height; j++)
                {
                        Color changeColor = change.GetPixel(i, j); // Get pixel value
                        
                        int red = changeColor.R;
                        int green = changeColor.G;
                        int blue = changeColor.B;

                        int lightGray = (byte)(.299 * red + .587 * green + .114 * blue);
                        red = lightGray;
                        green = lightGray;
                        blue = lightGray;

                    change.SetPixel(i, j, Color.FromArgb(red, green, blue)); // Set lighGray image pixel
                }

            }
            return true;
        }

    }
}
