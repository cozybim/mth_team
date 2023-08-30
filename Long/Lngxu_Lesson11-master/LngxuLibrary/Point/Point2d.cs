using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LngxuLibrary.Point
{
    public class Point2d
    {
        //khai báo các biến trường dữ liệu
        private double _x;
        private double _y;

        //các phương thức thuộc tính ( lệnh get và set của từng điểm X sẽ được gọi khi dùng lệnh )
        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }

        //phương thức khởi tạo không tham sô
        public Point2d() { }
        //khởi tạo có tham số truyền vào và 
        public Point2d(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}
