using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОИ_Практика1
{
	public class UQIblocks
	{
		public static double CalculateUQIblocks(Bitmap image1, Bitmap image2)
		{
			int x = 0, y = 0, countUQI = 0;
			double sumUQI = 0.0;
			int i = 5, j = 5;
            while (x + i < image1.Width && y + j < image1.Height)
            {
				sumUQI += (4 * Sigma(image1, image2, x, y, i, j) * XY(image1, x, y, i, j) * XY(image2, x, y, i, j)) / ((Sigma(image1, x, y, i, j) + Sigma(image2, x, y, i, j)) * (Math.Pow(XY(image1, x, y, i, j), 2) + Math.Pow(XY(image2, x, y, i, j), 2)));
				x += i;
				y += j;
				countUQI++;
			}
            
			return sumUQI / countUQI;
		}

		public static double XY(Bitmap image, int X, int Y, int i, int j)
		{
			double result = 0.0;
			for (int x = X; x < X + i; x++)
			{
				for (int y = Y; y < Y + j; y++)
				{
					Color pixel = image.GetPixel(x, y);
					result += (pixel.R + pixel.G + pixel.B) / 3.0;
				}
			}
			result /= (i * j);
			return result;
		}

		public static double Sigma(Bitmap image, int X, int Y, int i, int j)
		{
			double sigmaResult = 0.0;
			double value = XY(image, X, Y, i, j);
			for (int x = X; x < X + i; x++)
			{
				for (int y = Y; y < Y + j; y++)
				{
					Color pixel = image.GetPixel(x, y);

					sigmaResult += Math.Pow(((pixel.R + pixel.G + pixel.B) / 3.0) - X, 2);
				}
			}

			sigmaResult /= (i * j);
			return sigmaResult;
		}

		public static double Sigma(Bitmap image1, Bitmap image2, int X, int Y, int i, int j)
		{
			double sigmaResult = 0.0;
			double valueX = XY(image1, X, Y, i, j);
			double valueY = XY(image2, X, Y, i, j);
			for (int x = X; x < X + i; x++)
			{
				for (int y = Y; y < Y + j; y++)
				{
					Color pixel1 = image1.GetPixel(x, y);
					Color pixel2 = image2.GetPixel(x, y);

					sigmaResult += ((pixel1.R + pixel1.G + pixel1.B) / 3.0 - X) * ((pixel2.R + pixel2.G + pixel2.B) / 3.0 - X);
				}
			}

			sigmaResult /= (i * j);
			return sigmaResult;
		}

	}
}
