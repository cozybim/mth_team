using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDelegate
{
    public class Information
    {
        #region Props
        private string _message;

        public string Message { get => _message; set => _message = value; }
        #endregion

        // Constructor
        public Information() { }


        // Định nghĩa delegate
        internal delegate void ShowInfo(string info);

        internal void ShowByMessageBox(string info)
        {
            MessageBox.Show(info);
        }

        internal void ShowByForm(string info)
        {
            FrmMess myForm = new FrmMess();
            myForm.LblMess.Text = info;
            myForm.ShowDialog();
        }

        // Method
        public void run()
        {
            ShowInfo inf = null;

            inf += ShowByMessageBox;
            inf += ShowByForm;
            inf += ShowByForm;
            inf += ShowByMessageBox;
            inf += ShowByForm;

            //inf("Hello Tekla");
            //if (inf != null)
            //{
            //    inf.Invoke("Hello Tekla");
            //}

            inf?.Invoke("Hello Tekla");

        }

        internal delegate double TinhToan(double a, double b);

        public void Tong()
        {
            TinhToan tong = (double x, double y) =>
            {
                return x + y;
            };

            double total = tong(5, 10);
            ShowInfo inf = null;
            inf += ShowByForm;
            inf?.Invoke(total.ToString());
        }

    }
}
