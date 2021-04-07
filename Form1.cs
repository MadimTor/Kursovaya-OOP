using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net;

namespace Test_2
{
    public partial class Form1 : Form
    {
        OBR obr = new OBR();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            openFileDialog1.Title = "Выберите файл изображения";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {
                obr.Sourse = (Bitmap)Image.FromFile(@openFileDialog1.FileName);// в соурс не заходит ничего
                pictureBox1.Image = Image.FromFile(@openFileDialog1.FileName);
                
            }

        }
    }
}
