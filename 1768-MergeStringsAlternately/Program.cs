using System.Diagnostics;

namespace _1768_MergeStringsAlternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MergeStringAlternatelySolution mergeStringAlternatelySolution = new MergeStringAlternatelySolution();
            string word1 = "abc";
            string word2 = "pqr";
            string result = mergeStringAlternatelySolution.MergeAlternately(word1, word2);
            stopwatch.Stop();
            System.Console.WriteLine(result);
            System.Console.WriteLine("Run: " + stopwatch.ElapsedTicks);

            stopwatch.Restart();
            string word3 = "ab";
            string word4 = "pqrs";
            string result2 = mergeStringAlternatelySolution.MergeAlternately2(word3, word4);
            stopwatch.Stop();
            System.Console.WriteLine(result2);
            System.Console.WriteLine("Run: " + stopwatch.ElapsedTicks);

            stopwatch.Restart();
            string word5 = "abcd";
            string word6 = "pq";
            string result3 = mergeStringAlternatelySolution.MergeAlternately2(word5, word6);
            stopwatch.Stop();
            System.Console.WriteLine(result3);
            System.Console.WriteLine("Run: " + stopwatch.ElapsedTicks);
        }
    }
}
