using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace ОИ_Практика1
{
    public partial class Form1 : Form
    {
        public Bitmap image1, image2;
        public FourierTransform ft = new FourierTransform();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //создаем диалог для открытия файла
            OpenFileDialog dailog = new OpenFileDialog();
            dailog.Filter = "Image files | *.png; *.jpg; *.jpeg; *bmp; *.jfif | All Files (*.*) | *.*";
            if (dailog.ShowDialog() == DialogResult.OK)
            {
                image1 = new Bitmap(dailog.FileName);
                image2 = new Bitmap(dailog.FileName);
                pictureBox1.Image = image1;
                pictureBox2.Image = image2;
                pictureBox1.Refresh();
                pictureBox2.Refresh();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            label1.Text = "";
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dailog = new OpenFileDialog();
            dailog.Filter = "Image files | *.png; *.jpg; *.jpeg; *bmp; *.jfif | All Files (*.*) | *.*";
            if (dailog.ShowDialog() == DialogResult.OK)
            {
                image2 = new Bitmap(dailog.FileName);
                pictureBox2.Image = image2;
                pictureBox2.Refresh();
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            label1.Text = "";

            if (image1.Height != image2.Height)
            {
                image2 = new Bitmap(image2.GetThumbnailImage(image1.Width, image1.Height, null, IntPtr.Zero));
            }
        }

        private void mSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSE mse0 = new MSE();
            double mse = MSE.CalculateMSE(image1, image2);
            label1.Text = "MSE: " + Math.Round(mse, 6);
        }

        private void uQIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UQI mse0 = new UQI();
            double uqi = UQI.CalculateUQI(image1, image2);
            label1.Text = "UQI: " + Math.Round(uqi, 6);
        }

        private void uQIBlocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UQIblocks mse0 = new UQIblocks();
            double uqiBlocks = UQIblocks.CalculateUQIblocks(image1, image2);
            label1.Text = "UQI blocks: " + Math.Round(uqiBlocks, 6);
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            //chartNoise.Series.Clear();
            image2 = GaussianNoise.ApplyGaussianNoise(image2, 0, 20);
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

        private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = GaussianFilter.AddGaussianFilter(image2, 3, 0.5);
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

        private void методСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = SobelMethod.AddSobelMethod(image2);
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

        private void поискОкружностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = SearchCircles.DetectCricle(image2);
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

        private void гистограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(image2);
            histogram.ShowDialog();
        }

        private void прямоеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {           
            image2 = ft.FFT(image2);            
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

        private void фильтрНизкихЧастотToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            image2 = ft.ButterworthLowPassFilter();
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

        private void фильтрВысокихЧастотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = ft.ButterworthHighPassFilter();
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

        private void обратноеПреобразованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = ft.IFT();
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

        private void усреднениеСАльфасдвигомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image2 = AlphaTrunc.AlphaTruncF(image2, 3);
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

       
    }
}
