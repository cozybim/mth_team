using System;
using System.Windows.Forms;
using MyLibs.Geometry.RectangProfile;
using MyLibs.PointCollection;

namespace Day2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        
        private void btnProfile_Click(object sender, EventArgs e)
        {
            double W = rand.Next(100,200);
            double H = rand.Next(100,200);
            
            RectangProfile.PrintProfile(W, H, out string profile);

            MessageBox.Show($"Width = {W}\nHeight = {H}\nProfile = (WxH) = {profile}");
        }

        private void btnMaxMinX_Click(object sender, EventArgs e)
        {
            PointCollection pointCollection = new PointCollection();
            pointCollection.AddPoint(9, 11);
            pointCollection.AddPoint(15, 18);
            pointCollection.AddPoint(22, 33);

            double maxX = pointCollection.FindMaxX();
            double minX = pointCollection.FindMinX();

            MessageBox.Show($"The maximum value of X: {maxX}\nThe minimum value of X: {minX}");
        }

        private void btnMaxMinY_Click(object sender, EventArgs e)
        {
            PointCollection pointCollection = new PointCollection();
            pointCollection.AddPoint(9, 11);
            pointCollection.AddPoint(15, 18);
            pointCollection.AddPoint(22, 33);

            double maxY = pointCollection.FindMaxY();
            double minY = pointCollection.FindMinY();

            MessageBox.Show($"The maximum value of Y: {maxY}\nThe minimum value of Y: {minY}");
        }

        private void btnSortX_Click(object sender, EventArgs e)
        {
            PointCollection pointCollection = new PointCollection();
            pointCollection.AddPoint(9, 11);
            pointCollection.AddPoint(15, 18);
            pointCollection.AddPoint(22, 33);

            pointCollection.SortX();

            foreach (var point in pointCollection.Data)
            {
                MessageBox.Show($"Point X: {point._x}, Y: {point._y}");
            }
        }

        private void btnSortY_Click(object sender, EventArgs e)
        {
            PointCollection pointCollection = new PointCollection();
            pointCollection.AddPoint(9, 11);
            pointCollection.AddPoint(15, 18);
            pointCollection.AddPoint(22, 33);

            pointCollection.SortY();

            foreach (var point in pointCollection.Data)
            {
                MessageBox.Show($"Point X: {point._x}, Y: {point._y}");
            }
        }
    }
}
