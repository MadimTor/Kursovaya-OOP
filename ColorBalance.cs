using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class ColorBalance : OBR
    {
        //цветовой баланс R
        public void ColorBalance_R(int poz, int lenght)
        {
            int R;
            int G;
            int B;

            int N = (100 / lenght) * poz; //кол-во процентов
            for (int i = 0; i < _source.Height; i++)
                for (int j = 0; j < _source.Width; j++)
                {
                    R = (int)(((_sourceMatrix[i,j] & 0x00FF0000) >> 16) + N * 128 / 100);
                    G = (int)((_sourceMatrix[i, j] & 0x0000FF00) >> 8);
                    B = (int)(_sourceMatrix[i, j] & 0x000000FF);

                    //контролируем переполнение переменных
                    if (R < 0) R = 0;
                    if (R > 255) R = 255;

                    _sourceMatrix[i, j] = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                } 
        }

        //цветовой баланс G
        public void ColorBalance_G(int poz, int lenght)
        {
            int R;
            int G;
            int B;

            int N = (100 / lenght) * poz; //кол-во процентов
            for (int i = 0; i < _source.Height; i++)
                for (int j = 0; j < _source.Width; j++)
                {
                    R = (int)((_sourceMatrix[i, j] & 0x00FF0000) >> 16);
                    G = (int)(((_sourceMatrix[i, j] & 0x0000FF00) >> 8) + N * 128 / 100);
                    B = (int)(_sourceMatrix[i, j] & 0x000000FF);

                    //контролируем переполнение переменных
                    if (G < 0) G = 0;
                    if (G > 255) G = 255;

                    _sourceMatrix[i, j] = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                }

        }

        //цветовой баланс B
        public void ColorBalance_B(int poz, int lenght)
        {
            int R;
            int G;
            int B;

            int N = (100 / lenght) * poz; //кол-во процентов
            for (int i = 0; i < _source.Height; i++)
                for (int j = 0; j < _source.Width; j++)
                {
                    R = (int)((_sourceMatrix[i, j] & 0x00FF0000) >> 16);
                    G = (int)((_sourceMatrix[i, j] & 0x0000FF00) >> 8);
                    B = (int)((_sourceMatrix[i, j] & 0x000000FF) + N * 128 / 100);

                    //контролируем переполнение переменных
                    if (B < 0) B = 0;
                    if (B > 255) B = 255;

                    _sourceMatrix[i, j] = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                }
        }

    }
}
