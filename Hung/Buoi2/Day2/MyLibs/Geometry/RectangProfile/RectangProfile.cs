using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibs.Geometry.RectangProfile
{
    public class RectangProfile
    {
        public double _width, _height;
        
        public double W { get => _width; set => _width = value; }
        public double H { get => _height; set => _height = value; }

        public static string PrintProfile(double W, double H, out string profile)
        {
            profile = $"{W}x{H}";
            return profile;
        }
    }
}
