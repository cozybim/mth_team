using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LngxuLibrary
{
    public class RectangeProfile
    // khai bao static de khi dung khong phai khai bao
    {
        private double _x;

        public double width { get => _x; set => _x = value; }
        private double _y;
        public double height { get => _y; set => _y = value; }

        public  string GetProfile()
        {
                return $"{width}*{height}";
        }
    }
    
}
