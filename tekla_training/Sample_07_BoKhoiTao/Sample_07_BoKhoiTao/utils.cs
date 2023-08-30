using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_07_BoKhoiTao
{
    public class utils
    {

        public static double Distance(double pFromX, double pFromY, double pToX, double pToY)
        {
            return Math.Sqrt(Math.Pow(pToX - pFromX, 2) + Math.Pow(pToY - pFromY, 2));
        }

    }
}
