using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Point
    {

        private double _x, _y;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }


        #region Method

        public void Move(double _deltaX)
        {
            this._x += _deltaX;
        }

        public void Move(double _deltaX, double _deltaY)
        {
            this._x += _deltaX;
            this._y += _deltaY;
        }

        public void Move(string _xStr, string _yStr)
        {
            this._x += Convert.ToDouble(_xStr);
            this._y += Convert.ToDouble(_yStr);
        }
        #endregion
    }
}
