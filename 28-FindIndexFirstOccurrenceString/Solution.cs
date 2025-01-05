using System.Diagnostics;
using System.Security.Cryptography;

namespace _28_FindIndexFirstOccurrenceString
{
    internal class Solution
    {
        //Example 1:
        //Input: haystack = "sadbutsad", needle = "sad"
        //Output: 0
        //Explanation: "sad" occurs at index 0 and 6.
        //The first occurrence is at index 0, so we return 0.

        //Example 2:
        //Input: haystack = "leetcode", needle = "leeto"
        //Output: -1
        //Explanation: "leeto" did not occur in "leetcode", so we return -1.
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string haystack1 = "sadbutsad";
            string needle1 = "sad";
            var result1 = new Solution().StrStr(haystack1, needle1);
            Console.WriteLine(result1);

            string haystack2 = "leetcode";
            string needle2 = "leeto";
            var result2 = new Solution().StrStr(haystack2, needle2);
            Console.WriteLine(result2);

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        public int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                int index = haystack.IndexOf(needle);
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}
