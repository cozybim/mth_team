using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LngxuLibrary.Point
{
    public class PointCollection
    {
        //khai báo biến data là 1 danh sách chứa point2d
        List<Point2d> _data = new List<Point2d>();

        //phương thức gét set
        public List<Point2d> Data { get => _data; set => _data = value; }

        public static string FindMax(List<Point2d> danhsachpoint2d, string aXis = "X")
        {

            if (danhsachpoint2d.Count > 0)
            {
                if (aXis == "X" || aXis == "x")
                {
                    //LẤY  tạm 1 ĐIỂM ĐỂ SO SÁNH
                    double xMax = danhsachpoint2d[0].X;
                    foreach (Point2d item in danhsachpoint2d)
                    {
                        if (item.X >= xMax)
                        {
                            xMax = item.X;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    return $"Tọa độ X lớn nhất trong danh sách điểm là {xMax}";
                }
                else if (aXis == "Y" || aXis == "y")
                {

                    //LẤY  tạm 1 ĐIỂM ĐỂ SO SÁNH
                    double yMax = danhsachpoint2d[0].Y;
                    foreach (Point2d item in danhsachpoint2d)
                    {
                        if (item.Y >= yMax)
                        {
                            yMax = item.Y;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    return $"Tọa độ Y lớn nhất trong danh sách điểm là {yMax}";
                }
                else
                {
                    return $"trục {aXis} không được định nghĩa";
                }

            }
            else
            {
                return $"Danh sách rỗng";
            }
        }

        public static string FindMin(List<Point2d> danhsachpoint2d, string aXis = "X")
        {
            if (danhsachpoint2d.Count > 0)
            {
                if (aXis == "X" || aXis == "x")
                {
                    //LẤY  tạm 1 ĐIỂM ĐỂ SO SÁNH
                    double xMin = danhsachpoint2d[0].X;
                    foreach (Point2d item in danhsachpoint2d)
                    {
                        if (item.X <= xMin)
                        {
                            xMin = item.X;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    return $"Tọa độ X nhỏ nhất trong danh sách điểm là {xMin}";
                }
                else if (aXis == "Y" || aXis == "y")
                {
                    double yMin = danhsachpoint2d[0].Y;
                    foreach (Point2d item in danhsachpoint2d)
                    {
                        if (item.Y <= yMin)
                        {
                            yMin = item.Y;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    return $"Tọa độ Y nhỏ nhất trong danh sách điểm là {yMin}";
                }
                else
                {
                    return $"trục {aXis} không được định nghĩa";
                }

            }
            else
            {
                return $"Danh sách rỗng";
            }
        }

        public static List<Point2d> Sort(List<Point2d> list, string aXis = "X")
        {
            if (list.Count > 0)
            {
                if (aXis == "X" || aXis == "x")
                {
                    List<Point2d> result = list.OrderBy(a => a.X).ToList();

                    return result;
                }
                else if (aXis == "Y" || aXis == "y")
                {
                    List<Point2d> result = list.OrderBy(a => a.Y).ToList();

                    return result;

                }
                else { return null; }
            }
            else { return null ; }
              
        }

        public static List<string>  ShowLog(List<Point2d> list, string aXis = "X")
        {
            List<string> result = new List<string>();
            if (aXis == "x" || aXis == "X" || aXis == "y" || aXis == "Y")
            {
                result.Add($"Danh sách các điểm được sắp xếp theo thứ tự tăng dần theo trục {aXis} tăng dần là ");
            }
            else { return null; }

            foreach (Point2d item in list)
            {
                var x = item.X;
                var y = item.Y;
                result.Add($"x:= {x}, y={y}"+"\n");
                
            }



            return result;

        }
    }
}
