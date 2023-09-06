using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDelegate_Click(object sender, EventArgs e)
        {
            Information infor = new Information();

            infor.run();
        }

        private void BtnCalDelegate_Click(object sender, EventArgs e)
        {
            Information infor = new Information();

            infor.Tong();
        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            void ShowLog()
            {
                FrmMess myForm = new FrmMess();
                myForm.LblMess.Text = "R đã bị thay đổi";
                myForm.Show();
            }

            Circle cir = new Circle();
            cir.OnChangeRadius += ShowLog;
            cir.R = 5;
            //cir.OnChangeRadius -= ShowLog;
            cir.R = 10;


            MessageBox.Show("Đường tròn có bán kình " + cir.R);
        }


        private void Xuly (object o, EventArgs e)
        {
            MessageBox.Show("a");
        }

        private void BtnAddRow_Click(object sender, EventArgs e)
        {
            DgvFiles.Rows.Clear();
            for (int i = 0; i < 11; i++)
            {
                DgvFiles.Rows.Add();

                int index = DgvFiles.RowCount - 1;
                DgvFiles.Rows[index].Cells[0].Value = "R" + i;
                DgvFiles.Rows[index].Cells[1].Value = "Ten file" + i;
                DgvFiles.Rows[index].Cells[2].Value = "File path" + i;
            }    
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DgvFiles.Rows.Clear();
        }

        private void BtnSelection_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection sels = DgvFiles.SelectedRows;

            foreach (DataGridViewRow row in sels) 
            {
                // xử lý
                MessageBox.Show(row.Cells[0].Value.ToString());
            }
        }

        private void BtnDeleteMulti_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection sels = DgvFiles.SelectedRows;

            //for (int i = sels.Count -1; i >= 0; i--)
            //{
            //    DgvFiles.Rows.RemoveAt(sels[i].Index);
            //}    

            for (int i = 0; i < sels.Count; i++)
            {
                DgvFiles.Rows.RemoveAt(sels[i].Index);
            }
        }

        private void DgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            TxtId.Text = DgvFiles.Rows[rowIndex].Cells[0].Value.ToString();
            TxtName.Text = DgvFiles.Rows[rowIndex].Cells[1].Value.ToString();
            TxtPath.Text = DgvFiles.Rows[rowIndex].Cells[2].Value.ToString();

        }
    }
}
