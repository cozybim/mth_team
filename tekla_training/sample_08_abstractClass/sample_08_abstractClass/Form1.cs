using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_08_abstractClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Global.AllCategories.Add(new PropertiesCategory(1, "KC Phần dưới", 0));
            Global.AllCategories.Add(new PropertiesCategory(2, "KC Phần trên", 0));
            Global.AllCategories.Add(new PropertiesCategory(3, "Trụ", 1));
            Global.AllCategories.Add(new PropertiesCategory(4, "Bệ trụ", 3));
            Global.AllCategories.Add(new PropertiesCategory(5, "Thân trụ", 3));
            Global.AllCategories.Add(new PropertiesCategory(6, "Xà Mũ", 3));
            Global.AllCategories.Add(new PropertiesCategory(7, "Dầm", 2));
            Global.AllCategories.Add(new PropertiesCategory(8, "Bản mặt cầu", 2));
            Global.AllCategories.Add(new PropertiesCategory(9, "Lan can", 2));
            Global.AllCategories.Add(new PropertiesCategory(10, "Cột đèn", 9));
            Global.AllCategories.Add(new PropertiesCategory(11, "Bóng đèn", 10));

            // Chèn các node vào tree View
            TrvCau.Nodes.Clear();

            TreeNode node = TrvCau.Nodes.Add("Cầu");
            List<PropertiesCategory> baseLevel = Global.AllCategories.FindAll((value) => value.Father == 0);
            CategoryNode.RenderNode(Global.AllCategories, baseLevel, node);


        }
    }
}
