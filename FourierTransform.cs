using System;
using System.Diagnostics;
using System.Drawing;

namespace ОИ_Практика1
{
    public class FourierTransform
    {
        Complex[,] result;
        Bitmap resultImage;
        int width, height;

        public Bitmap FFT(Bitmap image)
        {
            width = image.Width;
            height = image.Height;

            result = new Complex[width, height];
            resultImage = new Bitmap(width, height);

            for (int k = 0; k < width; k++)
            {
                for (int l = 0; l < height; l++)
                {
                    Complex summa = new Complex(0, 0);
                
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            Color pixelColor = image.GetPixel(x, y);
                            double grayValue = 0.2989 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B;

                            double koeff = 2 * Math.PI * ((k * y) / (double)height + (l * x) / (double)width);
                            Complex e = new Complex(Math.Cos(koeff), -Math.Sin(koeff));

                            summa += grayValue * e;
                        }
                    }
                    result[k, l] = summa;                 
                    Debug.WriteLine(result[k, l].Real + " " + result[k, l].Imaginary);

                }
            }

            Debug.WriteLine("--------------------------");

            result = Centering(result);

            return DrawingImage(result, 0.2);     
        }

        public Bitmap IFT()
        {
            Complex[,] resultArray = new Complex[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Complex summa = new Complex(0, 0);

                    for (int k = 0; k < width; k++)
                    {
                        for (int l = 0; l < height; l++)
                        {
                            double koeff = 2 * Math.PI * ((k * y) / (double)height + (l * x) / (double)width);
                            Complex e = new Complex(Math.Cos(koeff), Math.Sin(koeff));
                            summa += result[k, l] * e;
                        }
                    }
                    resultArray[x, y] = summa / width / height;
                    int value = Clamp(Complex.ToValue(resultArray[x, y]), 0, 255);
                    Debug.WriteLine(resultArray[x, y].Real + " " + resultArray[x, y].Imaginary + " " + value);

                }
            }
       
            return DrawingImage(resultArray, 5);
        }

        public Bitmap ButterworthLowPassFilter()
        {
            // Низкочастотный фильтр Баттерворта
            double d0 = 10;
            int n = 1;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double d = Math.Sqrt(Math.Pow(x - width / 2, 2) + Math.Pow(y - height / 2, 2));
                    result[x, y] = 1 / (1 + Math.Pow(d / d0, 2 * n)) * result[x, y];
                }
            }

            return DrawingImage(result, 0.2);
        }
        public Bitmap ButterworthHighPassFilter()
        {
            // Высокочастотный фильтр Баттерворта
            double d0 = 3;
            int n = 1;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double d = Math.Sqrt(Math.Pow(x - width / 2, 2) + Math.Pow(y - height / 2, 2));
                    result[x, y] = (1 - 1 / (1 + Math.Pow(d / d0, 2 * n))) * result[x, y];
                }
            }

            return DrawingImage(result, 0.2);
        }
        public Bitmap DrawingImage(Complex[,] result, double k = 1) 
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int value = Clamp(Complex.ToValue(k * result[x, y]), 0, 255);
                    resultImage.SetPixel(x, y, Color.FromArgb(value, value, value));
                }
            }
            return resultImage;
        }
        public Complex[,] Centering(Complex[,] X)
        {
            int w = 2 * width;
            int h = 2 * height;
            Complex[,] X_n = new Complex[w, h];
            
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    if (x < width && y < height)
                    {
                        X_n[x, y] = X[x, y];
                    }
                    else if (x >= width && y < height)
                    {
                        X_n[x, y] = X[x % width, y];
                    }
                    else if (x < width && y >= height)
                    {
                        X_n[x, y] = X[x, y % height];
                    }
                    else if (x >= width && y >= height)
                    {
                        X_n[x, y] = X[x % width, y % height];
                    }
                }
            }
            
            Complex[,] result = new Complex[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    result[x, y] = X_n[width / 2 + x, height / 2 + y];
                }
            }         
            return result;
        }
        public static int Clamp(double value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return (int)value;
        }
        public struct Complex
        {
            public double Real;
            public double Imaginary;
            public Complex(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }
            public static int ToInt(Complex a)
            {         
                double r = Math.Sqrt(a.Real * a.Real + a.Imaginary * a.Imaginary);
                double cos = a.Real / r;
                double sin = a.Imaginary / r;
                return (int)(r * (cos + sin));
            }
            public static int ToValue(Complex a)
            {
                return (int)Math.Sqrt(a.Real * a.Real + a.Imaginary * a.Imaginary);
            }
            public static Complex FromPolarCoordinates(double magnitude, double angle)
            {
                return new Complex(magnitude * Math.Cos(angle), magnitude * Math.Sin(angle));
            }
            public static Complex operator +(Complex a, Complex b)
            {
                return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
            }
            public static Complex operator *(double a, Complex b)
            {
                return new Complex(a * b.Real, a * b.Imaginary);
            }
            public static Complex operator *(Complex a, Complex b)
            {
                return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
            }
            public static Complex operator /(Complex a, double b)
            {
                return new Complex(a.Real / b, a.Imaginary / b);
            }

        }

         
    }
}

