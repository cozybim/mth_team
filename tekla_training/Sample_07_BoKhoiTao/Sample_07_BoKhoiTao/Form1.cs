using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_07_BoKhoiTao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            Point point = new Point();
            point.Name = "point";
            point.X = 0;
            point.Y = 0;

            Point p1 = new Point(5, 5);
            p1.Name = "p1";

            Point p2 = new Point("p2", 5, 5);

            Point p3 = new Point("p3");
            // .... Tính toán
            p3.X = 0;
            p3.Y = 0;

            Point p4 = new Point();
            MessageBox.Show(string.Format("x: {0} - y: {1}", p4.X, p4.Y));
        }

        private void BtnDisstanceTo_Click(object sender, EventArgs e)
        {
            //Point p = new Point(0, 0);
            //string kq = p.DistanceTo(new Point(10, 0)).ToString();
            //MessageBox.Show(kq);

            Point p1 = new Point(0,0);
            Point p2 = new Point(120,0);

            string kq1 = utils.Distance(p1.X, p1.Y, p2.X, p2.Y).ToString();
            MessageBox.Show(kq1);
        }
    }
}
