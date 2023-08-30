using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sample_05_overload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOverload_Click(object sender, EventArgs e)
        {
            MyLib.Point po = new MyLib.Point();
            po.X = 0;
            po.Y = 0;

            po.Move("12", "15");

            MessageBox.Show(string.Format("Tọa độ sau move: x-{0} y-{1}", po.X, po.Y));
        }

        private void BtnMoRong_Click(object sender, EventArgs e)
        {
            string ten = "Nguyễn Văn A";
            ten.DaoNguoc();
            ten.getLast(5);
        }
    }
}
