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
        ColorBalance colorbal = new ColorBalance();
        public static Bitmap image;
        public static string full_name_of_image = "\0";

        
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
                    this.Width = image.Width + groupBox1.Width + 100;
                    if (image.Height > groupBox1.Height)
                        this.Height = image.Height;
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Brightness_bar_Scroll(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                obr.SetSource(image);
                obr.Brightness(Brightness_bar.Value, Brightness_bar.Maximum);
                obr.Contrast(Contrast_bar.Value, Contrast_bar.Maximum);
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
                    obr.Brightness(Brightness_bar.Value, Brightness_bar.Maximum);
                    pictureBox1.Image = obr.GetSource();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    image = obr.GetSource();
                    Brightness_bar.Value = 0;
                    Contrast_bar.Value = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    image = obr.GetSource();
                    Contrast_bar.Value = 0;
                }
            }
        }

        private void button_filter_test_Click(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    filt.SetSource(image);
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {                        
                        filt.matrix_filtration(Filters.N2, Filters.blur);
                    }
                    pictureBox1.Image = filt.GetSource();
                }
            }
        }

        private void Sharp_button_Click(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    filt.SetSource(image);
                    filt.matrix_filtration(Filters.N1, Filters.sharpness);
                    pictureBox1.Image = filt.GetSource();
                }
            }
        }

        private void negative_button_Click(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    obr.SetSource(image);
                    obr.Negative();
                    pictureBox1.Image = obr.GetSource();
                    image = obr.GetSource();
                    
                }
            }
        }

        private void Apply_Filter_Click(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    image = filt.GetSource();
                }
            }
        }

        private void trackBar_R_Scroll(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    colorbal.SetSource(image);
                    colorbal.ColorBalance_R(trackBar_R.Value, trackBar_R.Maximum);
                    colorbal.ColorBalance_G(trackBar_G.Value, trackBar_G.Maximum);
                    colorbal.ColorBalance_B(trackBar_B.Value, trackBar_B.Maximum);
                    pictureBox1.Image = colorbal.GetSource();
                }
            }
        }

        private void trackBar_G_Scroll(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    colorbal.SetSource(image);
                    colorbal.ColorBalance_R(trackBar_R.Value, trackBar_R.Maximum);
                    colorbal.ColorBalance_G(trackBar_G.Value, trackBar_G.Maximum);
                    colorbal.ColorBalance_B(trackBar_B.Value, trackBar_B.Maximum);
                    pictureBox1.Image = colorbal.GetSource();
                }
            }
        }

        private void trackBar_B_Scroll(object sender, EventArgs e)
        {
            if (Form1.full_name_of_image != "\0")
            {
                if (Form1.full_name_of_image != "\0")
                {
                    colorbal.SetSource(image);
                    colorbal.ColorBalance_R(trackBar_R.Value, trackBar_R.Maximum);
                    colorbal.ColorBalance_G(trackBar_G.Value, trackBar_G.Maximum);
                    colorbal.ColorBalance_B(trackBar_B.Value, trackBar_B.Maximum);
                    pictureBox1.Image = colorbal.GetSource();
                }
            }
        }

        private void apply_RGB_Click(object sender, EventArgs e)
        {
            image = colorbal.GetSource();
            trackBar_R.Value = 0;
            trackBar_G.Value = 0;
            trackBar_B.Value = 0;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            image = new Bitmap(full_name_of_image);
            pictureBox1.Image = image;
        }
    }
}
