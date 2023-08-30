using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibs
{
    public class FileString
    {

        private string _data, _path, _fullName, _Name, _Extension;

        public string Data { get => _data; set => _data = value; }
        public string Path { get => _path; set => _path = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Extension { get => _Extension; set => _Extension = value; }

        public FileString(string selectedFile)
        {
            this.Data = selectedFile;
            ///..... Xử lý để có các thuộc tính khác
            int ind = this._data.LastIndexOf('\\');
            this._path = this._data.Substring(0, ind);
            this._fullName = this._data.Substring(ind + 1);
            int index = this._fullName.LastIndexOf('.');
            this._Name = this._fullName.Substring(0, index);
            this._Extension = this._fullName.Substring(index + 1);
        }

        //public string getPath(out string fullName)
        //{
        //    string res = string.Empty;
        //    int ind = this._data.LastIndexOf('\\');
        //    res = this._data.Substring(0, ind);

        //    fullName  = this._data.Substring(ind + 1);

        //    return res;
        //}

        //public string getName(out string ext)
        //{
        //    string res = string.Empty;
        //    this.getPath(out string fullName);
        //    int ind = fullName.LastIndexOf('.');
        //    res = fullName.Substring(0, ind);
        //    ext = fullName.Substring(ind + 1);

        //    return res;
        //}
    }
}
