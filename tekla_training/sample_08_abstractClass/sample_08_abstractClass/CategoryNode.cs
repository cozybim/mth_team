using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_08_abstractClass
{
    internal class CategoryNode
    {
        public static void RenderNode(List<PropertiesCategory> all, List<PropertiesCategory> input, TreeNode fatherNode)
        {
            foreach (PropertiesCategory item in input)
            {
                TreeNode node = fatherNode.Nodes.Add(item.Name);
                List<PropertiesCategory> nextLevel = all.FindAll((e) => e.Father == item.Id);
                if (nextLevel.Count > 0)
                {
                    RenderNode(all, nextLevel, node);
                }
            }    
        }
    }
}
