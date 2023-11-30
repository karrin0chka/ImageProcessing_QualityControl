using System;
using System.Drawing;

namespace ОИ_Практика1
{
    public static class SobelMethod
    {
        /*  Он использует свертку для выделения изменений интенсивности пикселей в изображении, что позволяет обнаруживать границы объектов */
        public static Bitmap AddSobelMethod(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;

            // маска оператора, применяется для получения составляющих градиента
            int[,] sobelX = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] sobelY = { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    // перебор окрестности пикселя
                    float[] RGBx = new float[3] { 0f, 0f, 0f };
                    float[] RGBy = new float[3] { 0f, 0f, 0f };

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color color = image.GetPixel(x + j, y + i);
                            RGBx[0] += color.R * sobelX[j + 1, i + 1];
                            RGBx[1] += color.G * sobelX[j + 1, i + 1];
                            RGBx[2] += color.B * sobelX[j + 1, i + 1];

                            RGBy[0] += color.R * sobelY[j + 1, i + 1];
                            RGBy[1] += color.G * sobelY[j + 1, i + 1];
                            RGBy[2] += color.B * sobelY[j + 1, i + 1];
                        }
                    }
                    Color newPixel =  Color.FromArgb(
                    Clamp((int)Math.Sqrt(RGBx[0] * RGBx[0] + RGBy[0] * RGBy[0]), 0, 255),
                    Clamp((int)Math.Sqrt(RGBx[1] * RGBx[1] + RGBy[1] * RGBy[1]), 0, 255),
                    Clamp((int)Math.Sqrt(RGBx[2] * RGBx[2] + RGBy[2] * RGBy[2]), 0, 255));

                    image.SetPixel(x - 1, y - 1, newPixel);                    
                }                    
            }
            return image;
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
    }
}
