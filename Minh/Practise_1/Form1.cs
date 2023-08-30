using MLU01_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MLU01 = MLU01_Library;

namespace Practise_1
{
    public partial class Form1 : Form
    {
       private PointCollection _PointCollection = new PointCollection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MLU01.Rectangular _mlu01Library = new MLU01.Rectangular();

            //kiểm tra thông tin người dùng nhập vào phải là double
            bool _ResultCheckWidth = _mlu01Library._CheckTypeOfInputIsDouble(Txt_Width.Text);
            if (!_ResultCheckWidth)
            {
                MessageBox.Show("The input of width must be double");
            }
            bool _ResultCheckHeight = _mlu01Library._CheckTypeOfInputIsDouble(Txt_Height.Text);
            if (!_ResultCheckHeight)
            {
                MessageBox.Show("The input of height must be double");
            }
            if (_ResultCheckWidth && _ResultCheckHeight)
            {
                _mlu01Library.Width = Convert.ToDouble(Txt_Width.Text);
                _mlu01Library.Height = Convert.ToDouble(Txt_Height.Text);

                if (_mlu01Library.Width < _mlu01Library.Height)
                {
                    Ckb_Width.Text = "Height";
                    Ckb_Height.Text = "Width";
                }
                else
                {
                    Ckb_Width.Text = "Width";
                    Ckb_Height.Text = "Height";
                }
                MessageBox.Show(_mlu01Library._WriteLineRectangular());

            }
        }

        private void Btn_XMax_Click(object sender, EventArgs e)
        {
            _PointCollection._Point2d1.X = 5;
            _PointCollection._Point2d1.Y = 10;

            _PointCollection._Point2d2.X = 3;
            _PointCollection._Point2d2.Y = 6;

            _PointCollection._Point2d3.X = 9;
            _PointCollection._Point2d3.Y = 7;

            _PointCollection._Point2d4.X = 4;
            _PointCollection._Point2d4.Y = 8;

            double _MaxX = _PointCollection.GetMaxPointX();
            double _MinX = _PointCollection.GetMinPointX();
            double _MaxY = _PointCollection.GetMaxPointY();
            double _MinY = _PointCollection.GetMinPointY();

            MessageBox.Show(string.Format(" Max/ Min X are {0}/ {1} \n Max/ Min Y are {2}/ {3}", _MaxX, _MinX, _MaxY, _MinY));

            List<Point2d> _Point2D = new List<Point2d>();
            _Point2D.Add(_PointCollection._Point2d1);
            _Point2D.Add(_PointCollection._Point2d2);
            _Point2D.Add(_PointCollection._Point2d3);
            _Point2D.Add(_PointCollection._Point2d4);

            Dictionary<Point2d, double> _Dictionary = new Dictionary<Point2d, double>();
            for (int i = 0; i < _Point2D.Count; i++)
            {
                _Dictionary.Add(_Point2D[i], _Point2D[i].X);
            }
            List<double> _Values = new List<double>();
            foreach (KeyValuePair<Point2d, double> _key in _Dictionary)
            {
                _Values.Add(_key.Value);
            }

            List<double> _NewValues = new List<double>();
            _NewValues.Add(_PointCollection.GetMinPointX());

        }
    }
}
