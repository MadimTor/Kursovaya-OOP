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

    class OBR
    {
        protected Bitmap _source;
        protected UInt32[,] _sourceMatrix;

        public OBR()
        {
            _source = null;
            _sourceMatrix = null;
        }

        public void SetSource(Bitmap src)
        {
            _source = new Bitmap(src);
            _sourceMatrix = new UInt32[_source.Height, _source.Width];
            for (int y = 0; y < _source.Height; y++)
                for (int x = 0; x < _source.Width; x++)
                    _sourceMatrix[y, x] = (UInt32)(_source.GetPixel(x, y).ToArgb());
        }

        public Bitmap GetSource()
        {
            for (int y = 0; y < _source.Height; y++)
                for (int x = 0; x < _source.Width; x++)
                    _source.SetPixel(x, y, Color.FromArgb((int)_sourceMatrix[y, x]));
            return _source;
        }

        
    }
}
