using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    public class Circle
    {
        // Thuộc tính
        private double _r;

        public double R {
            get => _r;
            set { 
                //_r = value;
                SetRadius(value);
            }
        }

        // Sự kiện

        // Định nghĩa delegate tương ứng cho event
        public delegate void RadiusHandler();
        // Định nghĩa event
        public event RadiusHandler OnChangeRadius;

        // Định nghĩa phương thức để kích hoạt event
        internal void SetRadius(double bankinh)
        {
            if (this._r != bankinh)
            {
                this._r = bankinh;
                OnChangeRadius?.Invoke();
            }    
        }

        // Bộ khởi tạo
        public Circle() { }

        public Circle(double r) 
        {
            this._r = r;
        }

    }
}
