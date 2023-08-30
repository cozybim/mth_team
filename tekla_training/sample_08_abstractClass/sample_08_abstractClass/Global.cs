using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_08_abstractClass
{
    public enum Axis
    {
        X,
        Y,
        Z
    }

    public static class Global
    {
        

        public static List<PropertiesCategory> AllCategories = new List<PropertiesCategory>();

        public static string Xuly(Axis axis)
        {
            if (axis == Axis.X)
            {
                return "Đúng";
            } else
            {
                return "Sai";
            }

        }
    }
}