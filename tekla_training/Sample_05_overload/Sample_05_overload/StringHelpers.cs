using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_05_overload
{
    public static class StringHelpers
    {

        public static string DaoNguoc(this string input)
        {
            char[] chars = input.ToCharArray();
            string reverse = string.Empty;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                reverse += chars[i];
            }
            return reverse;
        }

        public static string getLast(this string input, int n)
        {
            return input.Substring(input.Length - n);
        }

    }
}
