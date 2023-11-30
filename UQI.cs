using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОИ_Практика1
{
	public class UQI
	{
		public static double CalculateUQI(Bitmap image1, Bitmap image2)
		{
			return (4 * Sigma(image1, image2) * XY(image1) * XY(image2)) / ((Sigma(image1) + Sigma(image2)) * (Math.Pow(XY(image1), 2) + Math.Pow(XY(image2), 2)));
		}

		public static double XY(Bitmap image)
		{
			double result = 0.0;
			for (int x = 0; x < image.Width; x++)
			{
				for (int y = 0; y < image.Height; y++)
				{
					Color pixel = image.GetPixel(x, y);
					result += (pixel.R + pixel.G + pixel.B) / 3.0;
				}
			}
			result /= (image.Width * image.Height);
			return result;
		}

		public static double Sigma(Bitmap image)
		{
			double sigmaResult = 0.0;
			double X = XY(image);
			for (int x = 0; x < image.Width; x++)
			{
				for (int y = 0; y < image.Height; y++)
				{
					Color pixel = image.GetPixel(x, y);

					sigmaResult += Math.Pow(((pixel.R + pixel.G + pixel.B) / 3.0) - X, 2);
				}
			}

			sigmaResult /= (image.Width * image.Height);
			return sigmaResult;
		}

		public static double Sigma(Bitmap image1, Bitmap image2)
		{
			double sigmaResult = 0.0;
			double X = XY(image1);
			double Y = XY(image2);
			for (int x = 0; x < image1.Width; x++)
			{
				for (int y = 0; y < image1.Height; y++)
				{
					Color pixel1 = image1.GetPixel(x, y);
					Color pixel2 = image2.GetPixel(x, y);

					sigmaResult += ((pixel1.R + pixel1.G + pixel1.B) / 3.0 - X) * ((pixel2.R + pixel2.G + pixel2.B) / 3.0 - X);
				}
			}

			sigmaResult /= (image1.Width * image1.Height);
			return sigmaResult;
		}

	}
}
