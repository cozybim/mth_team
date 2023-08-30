using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_09_abstract
{
    public abstract class Shape
    {
        #region Properties
        private string _name;
        private Point2d _insertPoint;

        public string Name { get => _name; set => _name = value; }
        public Point2d InsertPoint { get => _insertPoint; set => _insertPoint = value; }
        #endregion

        #region Methods

        // Cách khai báo phương thức trừu tượng
        public abstract double Area();

        public abstract double Perimeter();


        // Các khai báo phương thức ảo

        public virtual void Move(double deltaX, double deltaY)
        {
            this._insertPoint.X += deltaX;
            this._insertPoint.Y += deltaY;
        }


        #endregion

    }
}
