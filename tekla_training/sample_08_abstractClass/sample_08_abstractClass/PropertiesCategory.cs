using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_08_abstractClass
{
    public class PropertiesCategory
    {
        #region Thuộc tính
        private int _id;
        private string _name;
        private int _father;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Father { get => _father; set => _father = value; }
        #endregion

        public PropertiesCategory(int id, string name, int father)
        {
            this._id = id;
            this._name = name;
            this._father = father;
        }
    }
}
