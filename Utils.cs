using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPM
{
    public class Utils
    {
        public static int TransformParity(string var)
        {
            if (var == "None")
                return 0;
            else if (var == "Odd")
                return 1;
            else return 2;
        }

        public static int TransformStopBits(string var)
        {
            if (var == "None")
                return 0;
            else if (var == "One")
                return 1;
            else if (var == "Two")
                return 2;
            else return 3;
        }
    }
}
