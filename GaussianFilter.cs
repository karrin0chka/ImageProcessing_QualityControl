using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОИ_Практика1
{
    public static class GaussianFilter
    {
        public static Bitmap AddGaussianFilter(Bitmap image, int kernelSize, double sigma)
        {
            int radius = kernelSize / 2;

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    float red = 0, green = 0, blue = 0, weightSum = 0;

                    for (int i = -radius; i <= radius; i++)
                    {
                        for (int j = -radius; j <= radius; j++)
                        {
                            int newX = x + i;
                            int newY = y + j;

                            if (newX >= 0 && newX < image.Width && newY >= 0 && newY < image.Height)
                            {
                                Color pixel = image.GetPixel(newX, newY);
                                float weight = GaussianFunction(i, j, sigma);
                                red += pixel.R * weight;
                                green += pixel.G * weight;
                                blue += pixel.B * weight;
                                weightSum += weight;
                            }
                        }
                    }

                    red /= weightSum;
                    green /= weightSum;
                    blue /= weightSum;

                    image.SetPixel(x, y, Color.FromArgb((int)red, (int)green, (int)blue));
                }
            }

            return image;
        }

        static float GaussianFunction(int x, int y, double sigma)
        {
            return (float)(Math.Exp(-(x * x + y * y) / (2 * sigma * sigma)) / (2 * Math.PI * sigma * sigma));
        }

    }
}
