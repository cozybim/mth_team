
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using g2d = MyLibs.Geometry._2d;
using g3d = MyLibs.Geometry._3d;
using MyLibs.Geometry;
using MyLibs.utils;

namespace Props
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVector_Click(object sender, EventArgs e)
        {
            Vector v = new Vector();
            v.X = 10;
            v.Y = 20;

            MessageBox.Show(v.Nhan2x().ToString());
            MessageBox.Show(v.NhanX(5.0).ToString());
        }

        private void BtnPoint2d_Click(object sender, EventArgs e)
        {
            g2d.Point p2d = new g2d.Point();
            p2d.X = 0;
            p2d.Y = 0;

            g2d.Point newPo = p2d.Translate(5, 7);

            MessageBox.Show(string.Format(
                "Điểm gốc có tọa độ x:{0}, y: {1} dịch chuyển đến vị trí mới có tọa độ x:{2}, y: {3}",
                p2d.X.ToString(),
                p2d.Y.ToString(),
                newPo.X.ToString(),
                newPo.Y.ToString()
            ));


        }

        private void BtnTach_Click(object sender, EventArgs e)
        {
            string a = "100 200 300";
            /*ool check = false;*/
            string[] res = StringHelpers.getNumberVvalues(a, out bool check);
            if (!check)
            {
                MessageBox.Show("Cần nhập số");
            } else
            {
                MessageBox.Show("Đã đúng. Tiếp tục");
                // ..... Xử lý
            }
            
        }
    }
}
