using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _151_ReverseWordsInAString
{
    internal class ReverseWordsSolution
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words); 
            return string.Join(" ", words);
        }
    }
}
