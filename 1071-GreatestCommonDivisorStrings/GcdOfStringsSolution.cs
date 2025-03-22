using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1071_GreatestCommonDivisorStrings
{
    internal class GcdOfStringsSolution
    {
        public string GcdOfStrings2(string str1, string str2)
        {
            int i = 0, j = 0;
            while (i < str1.Length && j < str2.Length)
            {
                if (str1[i] != str2[j])
                {
                    return "";
                }
                i++;
                j++;
            }
            return i == str1.Length ? str1 : str2;
        }

        public string GcdOfStrings(string str1, string str2)
        {
            if ((str1 + str2) != (str2 + str1)) return "";
            return str1.Substring(0, GCD(str1.Length, str2.Length));
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
