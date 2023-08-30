using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangular
{
    public class Profile
    {
        #region Properties
        private double _Width, _Height;

        public double Width { get => _Width; set => _Width = value; }
        public double Height { get => _Height; set => _Height = value; }

        #endregion
        public void WriteLineWidthHeight(double _Width, double _Height)
        {
            if (_Width != 0 && _Height !=0)
            {
                //
            }
        }
    }


}
