using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibs.Geometry._2d
{
    public class Point : Vector
    {

        public Point Translate(double deltaX, double deltaY) 
        {
            Point res = new Point();
            // x gốc + delta x
            res.X = base.X + deltaX;
            res.Y = base.Y + deltaY;

            // y gốc + delte y

            return res;

        }


    }
}
