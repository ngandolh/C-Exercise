using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _392_IsSubsequence
{
    internal class IsSubsequenceSolution
    {
        public bool IsSubsequence(string s, string t)
        {
            int sIndex = 0, tIndex = 0;
            while (sIndex < s.Length && tIndex < t.Length)
            {
                Console.WriteLine("sIndex: " + sIndex + " tIndex: " + tIndex);
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }

            return sIndex == s.Length;
        }
    }
}
