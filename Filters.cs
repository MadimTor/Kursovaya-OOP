using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Test_2
{
    struct RGB
    {
        public float R;
        public float G;
        public float B;
    }


    class Filters : OBR
    {
        public void matrix_filtration(int N, double[,] matryx)
        {
            int i, j, k, m, gap = (int)(N / 2);
            int tmpH = _source.Height + 2 * gap, tmpW = _source.Width + 2 * gap;
            uint[,] tmppixel = new uint[tmpH, tmpW];
            uint[,] newpixel = new uint[_source.Height, _source.Width];
            //заполнение временного расширенного изображения
            //углы
            for (i = 0; i < gap; i++)
                for (j = 0; j < gap; j++)
                {
                    tmppixel[i, j] = _sourceMatrix[0, 0];
                    tmppixel[i, tmpW - 1 - j] = _sourceMatrix[0, _source.Width - 1];
                    tmppixel[tmpH - 1 - i, j] = _sourceMatrix[_source.Height - 1, 0];
                    tmppixel[tmpH - 1 - i, tmpW - 1 - j] = _sourceMatrix[_source.Height - 1, _source.Width - 1];
                }
            //крайние левая и правая стороны
            for (i = gap; i < tmpH - gap; i++)
                for (j = 0; j < gap; j++)
                {
                    tmppixel[i, j] = _sourceMatrix[i - gap, j];
                    tmppixel[i, tmpW - 1 - j] = _sourceMatrix[i - gap, _source.Width - 1 - j];
                }
            //крайние верхняя и нижняя стороны
            for (i = 0; i < gap; i++)
                for (j = gap; j < tmpW - gap; j++)
                {
                    tmppixel[i, j] = _sourceMatrix[i, j - gap];
                    tmppixel[tmpH - 1 - i, j] = _sourceMatrix[_source.Height - 1 - i, j - gap];
                }
            //центр
            for (i = 0; i < _source.Height; i++)
                for (j = 0; j < _source.Width; j++)
                    tmppixel[i + gap, j + gap] = _sourceMatrix[i, j];
            //применение ядра свертки
            RGB ColorOfPixel = new RGB();
            RGB ColorOfCell = new RGB();
            for (i = gap; i < tmpH - gap; i++)
                for (j = gap; j < tmpW - gap; j++)
                {
                    ColorOfPixel.R = 0;
                    ColorOfPixel.G = 0;
                    ColorOfPixel.B = 0;
                    for (k = 0; k < N; k++)
                        for (m = 0; m < N; m++)
                        {
                            ColorOfCell = CalculationOfColor(tmppixel[i - gap + k, j - gap + m], matryx[k, m]);
                            ColorOfPixel.R += ColorOfCell.R;
                            ColorOfPixel.G += ColorOfCell.G;
                            ColorOfPixel.B += ColorOfCell.B;
                        }
                    //контролируем переполнение переменных
                    if (ColorOfPixel.R < 0) ColorOfPixel.R = 0;
                    if (ColorOfPixel.R > 255) ColorOfPixel.R = 255;
                    if (ColorOfPixel.G < 0) ColorOfPixel.G = 0;
                    if (ColorOfPixel.G > 255) ColorOfPixel.G = 255;
                    if (ColorOfPixel.B < 0) ColorOfPixel.B = 0;
                    if (ColorOfPixel.B > 255) ColorOfPixel.B = 255;

                    newpixel[i - gap, j - gap] = Build(ColorOfPixel);
                }

            _sourceMatrix = newpixel;
        }



        public Bitmap MedianFiltering(int N)
        {
            List<uint> termsListR = new List<uint>();
            List<uint> termsListG = new List<uint>();
            List<uint> termsListB = new List<uint>();
            int mid = N * N / 2;
            //byte[,] image = new byte[_source.Width, _source.Height];
            //for (int i = 0; i < _source.Width; i++)
            //{
            //    for (int j = 0; j < _source.Height; j++)
            //    {
            //        var c = _source.GetPixel(i, j);
            //        byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
            //        image[i, j] = gray;
            //    }
            //}

            for (int i = 0; i <= _source.Width - N; i++)
                for (int j = 0; j <= _source.Height - N; j++)
                {
                    for (int x = i; x <= i + N -1; x++)
                        for (int y = j; y <= j + N-1; y++)
                        {
                            Color col = _source.GetPixel(x, y);
                            termsListR.Add(col.R);
                            termsListG.Add(col.G);
                            termsListB.Add(col.B);

                        }

                    uint[] termsR = termsListR.ToArray();
                    uint[] termsG = termsListG.ToArray();
                    uint[] termsB = termsListB.ToArray();
                    termsListR.Clear();
                    termsListG.Clear();
                    termsListB.Clear();
                    Array.Sort<uint>(termsR);
                    Array.Sort<uint>(termsG);
                    Array.Sort<uint>(termsB);
                    Array.Reverse(termsR);
                    Array.Reverse(termsG);
                    Array.Reverse(termsB);
                    uint colorR = termsR[mid];
                    uint colorG = termsG[mid];
                    uint colorB = termsB[mid];
                    _source.SetPixel(i + 1, j + 1, Color.FromArgb((int)colorR, (int)colorG, (int)colorB));
                }
            return _source;
        }

        //вычисление нового цвета
        public static RGB CalculationOfColor(uint pixel, double coefficient)
        {
            RGB Color = new RGB();
            Color.R = (float)(coefficient * ((pixel & 0x00FF0000) >> 16));
            Color.G = (float)(coefficient * ((pixel & 0x0000FF00) >> 8));
            Color.B = (float)(coefficient * (pixel & 0x000000FF));
            return Color;
        }

        //сборка каналов
        public static uint Build(RGB ColorOfPixel)
        {
            uint Color;
            Color = 0xFF000000 | ((uint)ColorOfPixel.R << 16) | ((uint)ColorOfPixel.G << 8) | ((UInt32)ColorOfPixel.B);
            return Color;
        }

        //повышение резкости
        public const int N1 = 3;
        public static double[,] sharpness = new double[N1, N1] {{-1, -1, -1},
                                                               {-1,  9, -1},
                                                               {-1, -1, -1}};

        public const int N2 = 5;
        public static double[,] blur = new double[N2, N2] {{0.000789, 0.006581, 0.013347, 0.006581, 0.000789},
                                                           {0.006581, 0.054901, 0.111345, 0.054901, 0.006581},
                                                           {0.013347, 0.111345, 0.225821, 0.111345, 0.013347},
                                                           {0.000789, 0.054901, 0.111345, 0.054901, 0.000789},
                                                           {0.000789, 0.006581, 0.013347, 0.006581, 0.000789}};


    }
}
