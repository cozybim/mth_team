using MyLibs.Geometry.Point2d;
using System;
using System.Collections.Generic;


namespace MyLibs.PointCollection
{
    public class PointCollection
    {
        public List<Point2d> Data = new List<Point2d>();

        public void AddPoint(double X, double Y)
        {
            Data.Add(new Point2d(X, Y));
        }

        public void AddPoint(Point2d point)
        {
            Data.Add(point);
        }

        public double FindMaxX()
        {
            double maxX = Data[0]._x;
            
            foreach (var point in Data)
            {
                if (point._x >= maxX)
                {
                    maxX = point._x;
                }
                else if (point._x < maxX)
                {
                    continue;
                }
            }
            return maxX;
        }
        
        public double FindMinX()
        {
            double minX = Data[0]._x;
            foreach (var point in Data)
            {
                if (point._x <= minX)
                {
                    minX = point._x;
                }
                else if (point._x > minX)
                {
                    continue;
                }
            }
            return minX;
        }

        public double FindMaxY()
        {
            double maxY = Data[0]._y;

            foreach (var point in Data)
            {
                if (point._y >= maxY)
                {
                    maxY = point._y;
                }
                else if (point._y < maxY)
                {
                    continue;
                }
            }
            return maxY;
        }

        public double FindMinY()
        {
            double minY = Data[0]._y;
            foreach (var point in Data)
            {
                if (point._y <= minY)
                {
                    minY = point._y;
                }
                else if (point._y > minY)
                {
                    continue;
                }
            }
            return minY;
        }

        public void SortX()
        {
            Data.Sort((p1, p2) => p1._x.CompareTo(p2._x));
        }

        public void SortY()
        {
            Data.Sort((p1, p2) => p1._y.CompareTo(p2._y));
        }
    }
}
