using System.Drawing;

namespace Test_2
{

    class processingSource
    {
        protected Bitmap _source;
        protected uint[,] _sourceMatrix;


        public processingSource()
        {
            _source = null;
            _sourceMatrix = null;
        }

        public void SetSource(Bitmap src)
        {
            _source = new Bitmap(src);
            _sourceMatrix = new uint[_source.Height, _source.Width];
            for (int y = 0; y < _source.Height; y++)
                for (int x = 0; x < _source.Width; x++)
                    _sourceMatrix[y, x] = (uint)_source.GetPixel(x, y).ToArgb();
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
