using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ОИ_Практика1
{
    public partial class Histogram : Form
    {
        public Histogram(Bitmap image)
        {
            InitializeComponent();               

            chart1.Series.Clear();
            chart1.Palette = ChartColorPalette.Berry;

            Series series1 = new Series("image1");
            series1 = CalculateHistogram(image, series1);
            chart1.Series.Add(series1);
        }

        // Вычисление гистограммы изображения
        static Series CalculateHistogram(Bitmap image, Series series)
        {
            for (int i = 1; i < 256; i++)
            {
                int count = 0;
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        Color pixel = image.GetPixel(x, y);
                        int grayValue = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                        if (grayValue == i)
                        {
                            count++;
                        }
                    }
                }
                series.Points.AddXY(i, count);
            }

            return series;
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            
        }
        

    }
}
