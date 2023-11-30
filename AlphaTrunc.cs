using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОИ_Практика1
{
    public static class AlphaTrunc
    {
        // Фильтр, основанный на вычислении усеченного среднего
        public static Bitmap AlphaTruncF(Bitmap image, double alpha = 0)
        {
            int width = image.Width;    
            int height = image.Height;
            int[] R = new int[9];
            int[] G = new int[9];
            int[] B = new int[9];
            

            for (int x = 1; x < width - 2; x++)
            {
                for (int y = 1; y < height - 2; y++)
                {
                    int count = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            R[count] = image.GetPixel(x + i, y + j).R;
                            G[count] = image.GetPixel(x + i, y + j).G;
                            B[count++] = image.GetPixel(x + i, y + j).B;
                        }
                    }

                    Array.Sort(R);
                    Array.Sort(B);
                    Array.Sort(G);

                    int Rc = 0, Gc = 0, Bc = 0;
                    int newCount = 0;

                    for (int i = 0; i < count; i++)
                    {
                        if (i >= alpha / 2 && i <= count - alpha / 2)
                        {
                            Rc += R[i];
                            Gc += G[i];
                            Bc += B[i];
                            newCount++;
                        }

                    }

                    image.SetPixel(x, y, Color.FromArgb(Rc / newCount, Gc / newCount, Bc / newCount));   
                }
            }
            return image;
        }
    }
}
