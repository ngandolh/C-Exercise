using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1657_DetermineTwoStringsAreClose
{
    internal class CloseStringsSolution
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            Dictionary<char, int> countWord1 = new Dictionary<char, int>();
            Dictionary<char, int> countWord2 = new Dictionary<char, int>();

            foreach (char c in word1)
            {
                if (countWord1.ContainsKey(c))
                {
                    countWord1[c]++;
                }
                else
                {
                    countWord1[c] = 1;
                }
            }

            foreach (char c in word2)
            {
                if (countWord2.ContainsKey(c))
                {
                    countWord2[c]++;
                }
                else
                {
                    countWord2[c] = 1;
                }
            }

            if (!countWord1.Keys.OrderBy(c => c).SequenceEqual(countWord2.Keys.OrderBy(c => c)))
            {
                return false;
            }

            if (!countWord2.Values.OrderBy(v => v).SequenceEqual(countWord2.Values.OrderBy(v => v)))
            {
                return false;
            }

            return true;
        }
    }
}
