using System;
using System.Windows.Forms;
using MyProperties.Geometry;

namespace MyProperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVector_Click(object sender, EventArgs e)
        {
            Vector vector = new Vector();
            vector.X = 5;
            vector.Y = 10;

            MessageBox.Show(string.Format("Tọa độ của vector là x={0} và y={1}", vector.X, vector.Y));
        }

        private void BtnPoint2d_Click(object sender, EventArgs e)
        {
            Point2d point = new Point2d();
            point.X = 5;
            point.Y = 10;

            MessageBox.Show(string.Format("Tọa độ của điểm là x={0} và y={1}", point.X, point.Y));
        }

        private void BtnPoint3d_Click(object sender, EventArgs e)
        {
            Point3d po = new Point3d();
            po.X = 5;
            po.Y = 10;
            po.Z = 10;

            MessageBox.Show(string.Format("Tọ độ điểm x:{0}, y:{1}, z:{2}", po.X, po.Y, po.Z));
        }
    }
}
