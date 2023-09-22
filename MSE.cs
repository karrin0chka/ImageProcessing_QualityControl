using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОИ_Практика1
{
    public class MSE 
    {
        // среднеквадратическая ошибка
        public static double CalculateMSE(Bitmap image1, Bitmap image2)
        {
            {
                if (image1.Size != image2.Size)
                {
                    throw new ArgumentException("Изображения должны иметь одинаковый размер.");
                }

                double mse = 0.0;
                for (int x = 0; x < image1.Width; x++)
                {
                    for (int y = 0; y < image1.Height; y++)
                    {
                        Color pixel1 = image1.GetPixel(x, y);
                        Color pixel2 = image2.GetPixel(x, y);

                        double deltaR = pixel1.R - pixel2.R;
                        double deltaG = pixel1.G - pixel2.G;
                        double deltaB = pixel1.B - pixel2.B;

                        mse += (deltaR * deltaR + deltaG * deltaG + deltaB * deltaB) / 3.0;
                    }
                }

                mse /= (image1.Width * image1.Height);

                return mse;
            }
        }
    }
}
    
