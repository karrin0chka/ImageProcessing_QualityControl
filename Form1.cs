using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОИ_Практика1
{
    public partial class Form1 : Form
    {
        Bitmap image1, image2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //создаем диалог для открытия файла
            OpenFileDialog dailog = new OpenFileDialog();
            dailog.Filter = "Image files | *.png; *.jpg; *bmp | All Files (*.*) | *.*";
            if (dailog.ShowDialog() == DialogResult.OK)
            {
                image1 = new Bitmap(dailog.FileName);
                pictureBox1.Image = image1;
                pictureBox1.Refresh();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            label1.Text = "";
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dailog = new OpenFileDialog();
            dailog.Filter = "Image files | *.png; *.jpg; *bmp | All Files (*.*) | *.*";
            if (dailog.ShowDialog() == DialogResult.OK)
            {
                image2 = new Bitmap(dailog.FileName);
                pictureBox2.Image = image2;
                pictureBox2.Refresh();
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            label1.Text = "";
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            MSE mse0 = new MSE();
            double mse = MSE.CalculateMSE(image1, image2);
            label1.Text = "MSE: " + mse;
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            UQI mse0 = new UQI();
            double uqi = UQI.CalculateUQI(image1, image2);
            label1.Text = "UQI: " + uqi;
        }

    }
}
