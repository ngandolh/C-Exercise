using System.Text.RegularExpressions;

namespace RegularExpressionMatching
{

    //Example 1:

    //Input: s = "aa", p = "a"
    //Output: false
    //Explanation: "a" does not match the entire string "aa".
    //Example 2:

    //Input: s = "aa", p = "a*"
    //Output: true
    //Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
    //Example 3:

    //Input: s = "ab", p = ".*"
    //Output: true
    //Explanation: ".*" means "zero or more (*) of any character (.)".
    public class RegexMatcher
    {
        //Cách 1
        public bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;
            bool[,] dp = new bool[m + 1, n + 1];

            // dp[0,0] represents matching empty string with empty pattern
            dp[0, 0] = true;

            // Initialize dp array for patterns like a*, a*b*, a*b*c* etc
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 2];
                }
            }

            // Fill the dp array
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        // Zero occurrence of the character before '*'
                        dp[i, j] = dp[i, j - 2];

                        // One or more occurrence of the character before '*'
                        if (p[j - 2] == s[i - 1] || p[j - 2] == '.')
                        {
                            dp[i, j] = dp[i, j] || dp[i - 1, j];
                        }
                    }
                }
            }

            return dp[m, n];
        }

        //Cách 2
        public bool IsMatch2(string s, string p)
        {
            if (p == String.Empty)
                return s == String.Empty;

            bool match = s != String.Empty && (s[0] == p[0] || p[0] == '.');

            if (p.Length >= 2 && p[1] == '*')
                return IsMatch2(s, p.Substring(2)) || match && IsMatch2(s.Substring(1), p);

            return match && IsMatch2(s.Substring(1), p.Substring(1));
        }

        //Cách 3
        Dictionary<(int sIndex, int pIndex), bool> dp;
        public bool IsMatch3(string s, string p)
        {
            dp = new();
            return FindMatch(s, p, 0, 0);
        }
        private bool FindMatch(string s, string p, int sIndex, int pIndex)
        {
            if (sIndex >= s.Length && pIndex >= p.Length)
            {
                return true;
            }
            if (pIndex >= p.Length)
            {
                return false;
            }
            if (dp.ContainsKey((sIndex, pIndex)))
            {
                return dp[(sIndex, pIndex)];
            }
            bool result = false;
            bool isMatch = (sIndex < s.Length && (s[sIndex] == p[pIndex] || p[pIndex] == '.'));
            if (pIndex + 1 < p.Length && p[pIndex + 1] == '*')
            {
                result = (isMatch && FindMatch(s, p, sIndex + 1, pIndex)) || FindMatch(s, p, sIndex, pIndex + 2);
            }
            else if (isMatch)
            {
                result = FindMatch(s, p, sIndex + 1, pIndex + 1);
            }
            dp[(sIndex, pIndex)] = result;
            return result;
        }

        class Program
        {
            static void Main(string[] args)
            {
                var matcher = new RegexMatcher();
                bool result = matcher.IsMatch("mississippi", "mis*is*p*.");
                Console.WriteLine($"Match result: {result}");
            }
        }
    }
}
