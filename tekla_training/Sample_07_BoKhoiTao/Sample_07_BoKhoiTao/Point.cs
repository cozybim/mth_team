using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_07_BoKhoiTao
{
    public class Point
    {
        private string _name;
        private double _x;
        private double _y;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public string Name { get => _name; set => _name = value; }

        public Point()
        {
            this._x = 10;
            this._y = 10;
        }

        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public Point(string name, double x, double y)
        {
            this._name = name;
            this._x = x;
            this._y = y;
        }

        public Point(string name)
        {
            this._name = name;
        }

        public double DistanceTo(Point pTo)
        {
            return Math.Sqrt(Math.Pow(pTo.X - this._x, 2) + Math.Pow(pTo.Y - this._y, 2));
        }


    }
}
