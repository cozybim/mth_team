using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibs.utils
{
    public static class StringHelpers
    {

        public static string[] getNumberVvalues(string input, out bool isNumber)
        {
            string[] tach = input.Split(' ');
            // Kiểm tra các thành phần đảm bảo là số
            bool check = true;
            foreach (string s in tach)
            {
                try
                {
                    Convert.ToDouble(s);
                }
                catch
                {
                    check = false;
                    break;
                }
                
            }
            isNumber = check;
            return tach;
        }

    }
}
