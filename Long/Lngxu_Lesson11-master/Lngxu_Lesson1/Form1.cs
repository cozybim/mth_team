using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LngxuLibrary;
using LngxuLibrary.Point;
using lpoint = LngxuLibrary.Point;


namespace Lngxu_Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_RecProfile_Click(object sender, EventArgs e)
        {
            LngxuLibrary.RectangeProfile profile = new LngxuLibrary.RectangeProfile();
            profile.width = 200;
            profile.height = 600;
            MessageBox.Show($"RectangeProfile của bạn là: {profile.GetProfile()}");

        }

        private void FindMaxPointX_Click(object sender, EventArgs e)
        {
            #region khai báo danh sách điểm 
            Point2d p1 = new Point2d(10, 20);
            Point2d p2 = new Point2d(50, 20);
            Point2d p3 = new Point2d(90, 20);
            Point2d p4 = new Point2d(100, 100);
            Point2d p5 = new Point2d(-90, -100);
            Point2d p6 = new Point2d(1000, 0);
            #endregion
            
            List<Point2d> listpoint = new List<Point2d> { p1, p2, p3, p4, p5, p6 };
           
            string xmax = PointCollection.FindMax(listpoint);

            string xmin = PointCollection.FindMin(listpoint);

            string ymax = PointCollection.FindMax(listpoint, "y");

            string ymin = PointCollection.FindMin(listpoint, "y");

            MessageBox.Show($"{xmax}\n{xmin}\n{ymax}\n{ymin}");

            var sortX = PointCollection.Sort(listpoint);

            var thongbao1 = PointCollection.ShowLog(sortX);
            MessageBox.Show(string.Join("\n", thongbao1));

            var sortY = PointCollection.Sort(listpoint, "y");
            var thongbao2 = PointCollection.ShowLog(sortY, "y");
            MessageBox.Show(string.Join("\n", thongbao2));
        }

    }
}
