using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ОИ_Практика1
{
    public static class GaussianNoise
    {
        public static double[] array = new double[256];
        public static Bitmap ApplyGaussianNoise(Bitmap image, double mean, double std)
        {
            Bitmap resultImage = image;
            Random random = new Random();
            //chart1.Series.Clear();
            //chart1.Palette = ChartColorPalette.Berry;
            //Series series = new Series("ImageNoise");


            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel1 = image.GetPixel(x, y);

                    int R = AddNoise(pixel1, 'R', mean, std, random);
                    int G = AddNoise(pixel1, 'G', mean, std, random);
                    int B = AddNoise(pixel1, 'B', mean, std, random);

                    resultImage.SetPixel(x, y, Color.FromArgb(R, G, B));
                    /*
                    Color pixel2 = resultImage.GetPixel(x, y);

                    int grayValue1 = (int)(0.299 * pixel1.R + 0.587 * pixel1.G + 0.114 * pixel1.B);
                    int grayValue2 = (int)(0.299 * pixel2.R + 0.587 * pixel2.G + 0.114 * pixel2.B);
                    array[grayValue1]--;
                    array[grayValue2]++;
                    */
                }
            }
            /*
            for (int i = 0; i < 256; i++)
            {
             //   if (array[i] < 0) 
                    
             //       series.Points.AddXY(i, (int)Math.Abs(array[i - 1] - array[i + 1])/2);
             //   else
                    series.Points.AddXY(i, array[i]);
            }

            chart1.Series.Add(series);
            */
            return resultImage;
        }

        private static int AddNoise(Color pixel, char ch, double mean, double std, Random random)
        {
            double noise = random.NextDouble();
            double gaussianNoise = Math.Round(mean + (std * Math.Sqrt(-2 * Math.Log(noise)) * Math.Cos(2 * Math.PI * noise)));
            int value = 0;
            switch (ch)
            {
                case 'R': 
                    value = Convert.ToInt32(pixel.R + gaussianNoise);
                    break;
                case 'G':
                    value = Convert.ToInt32(pixel.G + gaussianNoise);
                    break;
                case 'B':
                    value = Convert.ToInt32(pixel.B + gaussianNoise);
                    break;
            }

            return Clamp(value, 0, 255);
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
