using System;
using System.Collections.Generic;
using System.Drawing;

namespace ОИ_Практика1
{
    public class SearchCircles
    {
        public static Bitmap DetectCricle(Bitmap image)
        {
            image = ConvertToGrayscale(image);
            Circle[] circles = HoughCircleDetection(image, 150, 300, 100);  
            //Circle[] circles = HoughCircleDetection(image, 20, 50, 110);
            Graphics gr = Graphics.FromImage(image);
            
            foreach (Circle circle in circles)
            {
                gr.DrawEllipse(Pens.Red, circle.Center.X - circle.Radius, circle.Center.Y - circle.Radius, circle.Radius * 2, circle.Radius * 2);
            }
            
            return image;
        }
        
        static Circle[] HoughCircleDetection(Bitmap image, int minRadius, int maxRadius, int threshold)
        {
            int width = image.Width;
            int height = image.Height;
            int[,,] accumulator = new int[width, height, Math.Min(width, height) / 2];

            List<Circle> circles = new List<Circle>();

            // Перебор каждого пикселя изображения
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Проверка, является ли пиксель частью окружности
                   if ((pixel.R < 80))
                    {
                        // Для каждой возможной окружности с заданным радиусом
                        for (int radius = minRadius; radius <= maxRadius; radius++)
                        {
                            for (double theta = 0; theta < 2 * Math.PI; theta += 0.01)
                            {
                                int centerX = (int)(x - radius * Math.Cos(theta));
                                int centerY = (int)(y - radius * Math.Sin(theta));

                                if (centerX >= 0 && centerX < width && centerY >= 0 && centerY < height)
                                {
                                    // Увеличение значения аккумулятора
                                    accumulator[centerX, centerY, radius]++;
                                }
                            }
                        }
                    }
                }
            }


            // Фильтрация окружностей с наибольшими значениями аккумуляторов
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    for (int radius = minRadius; radius < maxRadius; radius++)
                    {
                        if (accumulator[x, y, radius] > threshold)
                        {
                            circles.Add(new Circle(new Point(x, y), radius));
                        }
                    }
                }
            }

            return circles.ToArray();
        }


        public struct Circle
        {
            public Point Center { get; }
            public int Radius { get; }

            public Circle(Point center, int radius)
            {
                Center = center;
                Radius = radius;
            }
        }
        
        private static Bitmap ConvertToGrayscale(Bitmap inputImage)
        {
            Bitmap grayImage = new Bitmap(inputImage.Width, inputImage.Height);

            for (int x = 0; x < inputImage.Width; x++)
            {
                for (int y = 0; y < inputImage.Height; y++)
                {
                    Color pixel = inputImage.GetPixel(x, y);
                    int grayValue = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    grayImage.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }

            return grayImage;
        }
    }
}