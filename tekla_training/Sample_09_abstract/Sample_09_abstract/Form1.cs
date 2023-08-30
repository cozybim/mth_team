using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyLibs;

namespace Sample_09_abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Chọn tập tin ...";
            od.Filter = "*.pdf|*.pdf";
            od.InitialDirectory = "C:\\working";
            if (od.ShowDialog() == DialogResult.OK)
            {
                TxtSelectedFile.Text = od.FileName;

                FileString fs = new FileString(od.FileName);
                TxtPath.Text = fs.Path;
                TxtFullName.Text = fs.FullName;
                TxtName.Text = fs.Name;
                TxtExtension.Text = fs.Extension;
            }

        }
    }
}
