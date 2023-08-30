using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_09_abstract
{
    public class Point2d
    {
        private double _x, _y;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
    }
}
