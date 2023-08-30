using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MLU01_Library
{
    public class PointCollection : Point2d
    {
        public Point2d _Point2d1 = new Point2d();
        public Point2d _Point2d2 = new Point2d();
        public Point2d _Point2d3 = new Point2d();
        public Point2d _Point2d4 = new Point2d();

        public double GetMaxPointX()
        {
            double _Point1X = _Point2d1.X;
            double _Point2X = _Point2d2.X;
            double _Point3X = _Point2d3.X;
            double _Point4X = _Point2d4.X;

            List<double> _ListPointX = new List<double>();
            _ListPointX.Add(_Point1X);
            _ListPointX.Add(_Point2X);
            _ListPointX.Add(_Point3X);
            _ListPointX.Add(_Point4X);

            double _MaxX = _ListPointX[0];

            for (int i = 1; i < _ListPointX.Count; i++)
            {
                if (_MaxX < _ListPointX[i])
                {
                    _MaxX = _ListPointX[i];
                }
            }

            return _MaxX;
        }
        public double GetMinPointX()
        {
            double _Point1X = _Point2d1.X;
            double _Point2X = _Point2d2.X;
            double _Point3X = _Point2d3.X;
            double _Point4X = _Point2d4.X;

            List<double> _ListPointX = new List<double>();
            _ListPointX.Add(_Point1X);
            _ListPointX.Add(_Point2X);
            _ListPointX.Add(_Point3X);
            _ListPointX.Add(_Point4X);

            double _MinX = _ListPointX[0];

            for (int i = 1; i < _ListPointX.Count; i++)
            {
                if (_MinX > _ListPointX[i])
                {
                    _MinX = _ListPointX[i];
                }
            }

            return _MinX;
        }

        public double GetMaxPointY()
        {
            double _Point1Y = _Point2d1.Y;
            double _Point2Y = _Point2d2.Y;
            double _Point3Y = _Point2d3.Y;
            double _Point4Y = _Point2d4.Y;

            List<double> _ListPointY = new List<double>();
            _ListPointY.Add(_Point1Y);
            _ListPointY.Add(_Point2Y);
            _ListPointY.Add(_Point3Y);
            _ListPointY.Add(_Point4Y);

            double _MaxY = _ListPointY[0];

            for (int i = 1; i < _ListPointY.Count; i++)
            {
                if (_MaxY < _ListPointY[i])
                {
                    _MaxY = _ListPointY[i];
                }
            }
            return _MaxY;
        }

        public double GetMinPointY()
        {
            double _Point1Y = _Point2d1.Y;
            double _Point2Y = _Point2d2.Y;
            double _Point3Y = _Point2d3.Y;
            double _Point4Y = _Point2d4.Y;

            List<double> _ListPointY = new List<double>();
            _ListPointY.Add(_Point1Y);
            _ListPointY.Add(_Point2Y);
            _ListPointY.Add(_Point3Y);
            _ListPointY.Add(_Point4Y);

            double _MinY = _ListPointY[0];

            for (int i = 1; i < _ListPointY.Count; i++)
            {
                if (_MinY > _ListPointY[i])
                {
                    _MinY = _ListPointY[i];
                }
            }
            return _MinY;
        }

        public List<Point2d> SortPointX()
        {
            List<Point2d> _Result = new List<Point2d>();

            List<Point2d> _Point2D = new List<Point2d>();
            _Point2D.Add(_Point2d2);
            _Point2D.Add(_Point2d1);
            _Point2D.Add(_Point2d4);
            _Point2D.Add(_Point2d3);

            Dictionary<Point2d, double> _Dictionary = new Dictionary<Point2d, double>();
            for (int i = 0; i < _Point2D.Count; i++)
            {
                _Dictionary.Add(_Point2D[i], _Point2D[i].X);
            }
            foreach (KeyValuePair<Point2d, double> _key in _Dictionary)
            {
                _Result.Add(_key.Key);
            }

            return _Result;
        }
    }
}
