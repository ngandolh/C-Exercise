using System.Diagnostics;

namespace _162_FindPeakElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            FindPeakElementSolution findPeakElementSolution = new FindPeakElementSolution();
            int[] nums = { 1, 2, 3, 1 };
            stopwatch.Start();
            int result = findPeakElementSolution.FindPeakElement2(nums);
            stopwatch.Stop();
            System.Console.WriteLine(result);
            System.Console.WriteLine("Time elapsed: {0:0.000}ms", stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Restart();
            Console.WriteLine("==========================================================");
            int[] nums2 = { 1, 2, 1, 3, 5, 6, 4 };
            int result2 = findPeakElementSolution.FindPeakElement2(nums2);
            stopwatch.Stop();
            System.Console.WriteLine(result2);
            System.Console.WriteLine("Time elapsed: {0:0.000}ms", stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
