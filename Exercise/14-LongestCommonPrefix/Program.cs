using _14_LongestCommonPrefix;
using Microsoft.VisualBasic;
using System.ComponentModel;
namespace _14_LongestCommonPrefix
{
    //    Write a function to find the longest common prefix string amongst an array of strings.
    //If there is no common prefix, return an empty string "".

    //Example 1:

    //Input: strs = ["flower", "flow", "flight"]
    //Output: "fl"
    //Example 2:

    //Input: strs = ["dog", "racecar", "car"]
    //Output: ""
    //Explanation: There is no common prefix among the input strings.
    public class Compare
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 1) return "";

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    Console.WriteLine("Prefix: " + prefix);
                    if (prefix.Length == 0)
                        return "";
                }
            }
            return prefix;
        }
    }
}


public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("14. Longest Common Prefix");
        string[] strs = { "flower", "flow", "flight" };
        var result = Compare.LongestCommonPrefix(strs);
        Console.WriteLine("Result: " + result);

        string[] strs2 = { "dog", "racecar", "car" };
        var result2 = Compare.LongestCommonPrefix(strs2);
        Console.WriteLine("Result: " + result2);

        //Case 3: string[] has 1 element
        string[] strs3 = { "a" };
        var result3 = Compare.LongestCommonPrefix(strs3);
        Console.WriteLine("Result: " + result3);

        string[] strs4 = { "dog", "racecar", "car" };
        var result4 = Compare.LongestCommonPrefix(strs4);
        Console.WriteLine("Result: " + result4);
    }
}
