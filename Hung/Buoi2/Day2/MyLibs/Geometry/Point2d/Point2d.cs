using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibs.Geometry.Point2d
{
    public class Point2d
    {
        public double _x { get; set; }
        public double _y { get; set; }

        public Point2d(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}
