using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibs.Geometry._3d
{
    public class Point: Vector
    {
        private double _z;

        public double Z { get => _z; set => _z = value; }
    }
}
