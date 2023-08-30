using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibs.Geometry
{
    public class Vector
    {
        #region Properties
        private double _x;
        public double X { get => _x; set => _x = value; }

        private double _y;
        public double Y { get => _y; set => _y = value; }

        #endregion

        #region Methods


        public double Nhan2x()
        {
            double res = 0;
            // ... Các xử lý
            res = 2.0 * this._x;
            
            return res;
        }


        public double NhanX(double n)
        {
            double res = 0;
            res = n * this._x;

            return res;
        }




        #endregion

    }
}
