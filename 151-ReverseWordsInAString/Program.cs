using System.Diagnostics;

namespace _151_ReverseWordsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            ReverseWordsSolution reverseWordsSolution = new ReverseWordsSolution();
            string s = "the sky is blue";
            stopwatch.Start();
            string result = reverseWordsSolution.ReverseWords(s);
            stopwatch.Stop();
            Console.WriteLine(result);
            Console.WriteLine("Timeline: " + stopwatch.ElapsedTicks);

            Console.WriteLine("=================================================");
            //string s2 "  hello world  ";
            //string result2 = reverseWordsSolution.ReverseWords(s2);
            //Console.WriteLine(result2);
            //Console.WriteLine("=================================================");

            string s3 = "a good   example";
            stopwatch.Restart();
            string result3 = reverseWordsSolution.ReverseWords(s3);
            stopwatch.Stop();
            Console.WriteLine(result3);
            Console.WriteLine("Timeline: " + stopwatch.ElapsedTicks);
            Console.WriteLine("=================================================");
        }
    }
}
