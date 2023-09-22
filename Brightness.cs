﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ОИ_Практика1
{
    class Brightness: Filters
    {
        protected int k = 50;
        public Brightness() { }
        public Brightness(int k)
        {
            this.k = k;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourseColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(
                Clamp(sourseColor.R + k, 0, 255),
                Clamp(sourseColor.G + k, 0, 255),
                Clamp(sourseColor.B + k, 0, 255));
            return resultColor;
        }
    }
}
