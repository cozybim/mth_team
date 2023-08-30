using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_09_abstract
{
    public class Rectangle: Shape
    {
        #region thuộc tính
        private double _height, _width;

        public double Height { get => _height; set => _height = value; }
        public double Width { get => _width; set => _width = value; }

        #endregion

        #region Bộ khởi tạo
        public Rectangle() { }

        public Rectangle(string name)
        {
            base.Name = name;
        }

        public Rectangle(string name, Point2d po)
        {
            base.Name = name;
            base.InsertPoint = po;
        }

        public Rectangle(string name, Point2d po, double height, double width)
        {
            base.Name = name;
            base.InsertPoint = po;
            this._height = height;
            this._width = width;
        }
        #endregion

        public override double Area()
        {
            return this._height + this._width;
        }

        public override double Perimeter()
        {
            return 2.0 * (this._height + this._width);
        }


    }
}
