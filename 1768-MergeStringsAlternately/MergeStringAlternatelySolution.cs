using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1768_MergeStringsAlternately
{
    public class MergeStringAlternatelySolution
    {
        public string MergeAlternately(string word1, string word2)
        {
            char[] chars1 = word1.ToCharArray();
            char[] chars2 = word2.ToCharArray();
            char[] mapChar = new char[chars1.Length + chars2.Length];
            int length = chars1.Length + chars2.Length;

            for (int i = 0; i < chars1.Length; i++)
            {
                mapChar[i * 2] = chars1[i];
            }

            for (int i = 0; i < chars2.Length; i++)
            {
                mapChar[i * 2 + 1] = chars2[i];
            }

            return new string(mapChar);
        }

        public string MergeAlternately2(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            int j = 0;
            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                    i++;
                }
                if (j < word2.Length)
                {
                    sb.Append(word2[j]);
                    j++;
                }
            }
            return sb.ToString();
        }

        //public string MergeAlternately(string word1, string word2)
        //{
        //    int a = word1.Length;
        //    int b = word2.Length;
        //    int minno = Math.Min(a, b);
        //    string answer = "";

        //    for (int i = 0; i < minno; i++)
        //    {
        //        answer = answer + word1[i] + word2[i];
        //    }

        //    if (a > b)
        //    {
        //        string endstring = word1.Substring(minno);
        //        answer = answer + endstring;
        //    }
        //    else if (b > a)
        //    {
        //        string endstring = word2.Substring(minno);
        //        answer = answer + endstring;
        //    }

        //    return answer;
        //}
    }
}
