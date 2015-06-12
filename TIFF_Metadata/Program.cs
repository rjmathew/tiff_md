using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TIFF_Metadata
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap img;
            img = new Bitmap(@"c:\users\rajesh\downloads\marbles.tif", true);
            int height = img.Size.Height;
            int width = img.Size.Width;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelColor = img.GetPixel(50, 50);
                    int r = pixelColor.R;
                    int g = pixelColor.G;
                    int b = pixelColor.B;
                }
                
            }
            Console.WriteLine("done");
        }
    }
}
