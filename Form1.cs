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
        BrightnessContrast obr = new BrightnessContrast();
        Filters filt = new Filters();
        public static Bitmap image;
        public static string full_name_of_image = "\0";
        public static UInt32[,] pixel;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    full_name_of_image = open_dialog.FileName;
                    image = new Bitmap(open_dialog.FileName);
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                    obr.SetSource(image);
                }
                catch
                {
                    full_name_of_image = "\0";
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Brightness_bar_Scroll(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                obr.SetSource(image);
                obr.Brightness(Brightness_bar.Value, Brightness_bar.Maximum);
                pictureBox1.Image = obr.GetSource();
                
            }
        }

        private void Contrast_bar_Scroll(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    obr.SetSource(image);
                    obr.Contrast(Contrast_bar.Value, Contrast_bar.Maximum);
                    pictureBox1.Image = obr.GetSource();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            image = obr.GetSource();
            Brightness_bar.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            image = obr.GetSource();
            Contrast_bar.Value = 0;
        }

        private void button_filter_test_Click(object sender, EventArgs e)
        {
            filt.SetSource(image);
            filt.matrix_filtration(Filters.N2, Filters.blur);
            pictureBox1.Image = filt.GetSource();
        }

        private void Sharp_button_Click(object sender, EventArgs e)
        {
            filt.SetSource(image);
            filt.matrix_filtration(Filters.N1, Filters.sharpness);
            pictureBox1.Image = filt.GetSource();
        }
    }
}
