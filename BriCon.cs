using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class BrightnessContrast : OBR
    {

        //якрость
        public void Brightness(int value, int max)
        {
            int R;
            int G;
            int B;
            int N = (100 / max) * value;
            for (int i = 0; i < _source.Height; i++)
                for (int j = 0; j < _source.Width; j++)
                {
                    R = (int)(((_sourceMatrix[i,j] & 0x00FF0000) >> 16) + N * 128 / 100);
                    G = (int)(((_sourceMatrix[i, j] & 0x0000FF00) >> 8) + N * 128 / 100);
                    B = (int)((_sourceMatrix[i, j] & 0x000000FF) + N * 128 / 100);

                    if (R < 0) R = 0;
                    if (R > 255) R = 255;
                    if (G < 0) G = 0;
                    if (G > 255) G = 255;
                    if (B < 0) B = 0;
                    if (B > 255) B = 255;

                    _sourceMatrix[i, j] = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                }
        }

        //контрастность
        public void Contrast(int value, int max)
        {
            int R;
            int G;
            int B;
            int N = (100 / max) * value;
            for (int i = 0; i < _source.Height; i++)
                for (int j = 0; j < _source.Width; j++)
                {
                    if (N >= 0)
                    {
                        if (N == 100) N = 99;
                        R = (int)((((_sourceMatrix[i, j] & 0x00FF0000) >> 16) * 100 - 128 * N) / (100 - N));
                        G = (int)((((_sourceMatrix[i, j] & 0x0000FF00) >> 8) * 100 - 128 * N) / (100 - N));
                        B = (int)(((_sourceMatrix[i, j] & 0x000000FF) * 100 - 128 * N) / (100 - N));
                    }
                    else
                    {
                        R = (int)((((_sourceMatrix[i, j] & 0x00FF0000) >> 16) * (100 - (-N)) + 128 * (-N)) / 100);
                        G = (int)((((_sourceMatrix[i, j] & 0x0000FF00) >> 8) * (100 - (-N)) + 128 * (-N)) / 100);
                        B = (int)(((_sourceMatrix[i, j] & 0x000000FF) * (100 - (-N)) + 128 * (-N)) / 100);
                    }

                    if (R < 0) R = 0;
                    if (R > 255) R = 255;
                    if (G < 0) G = 0;
                    if (G > 255) G = 255;
                    if (B < 0) B = 0;
                    if (B > 255) B = 255;

                    _sourceMatrix[i, j] = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                }
        }

    }
}
