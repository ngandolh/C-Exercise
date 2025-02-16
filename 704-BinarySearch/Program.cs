using System.Diagnostics;

namespace _704_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            BinarySearchSolution binarySearchSolution = new BinarySearchSolution();

            //int[] case1 = {-1, 0, 3, 5, 9, 12};
            //int target = 9;
            //int result = binarySearchSolution.Search(case1, target);
            //stopwatch.Stop();

            //Console.WriteLine("Result: ", string.Join(" ", result));
            stopwatch.Reset();
            stopwatch.Start();
            int[] case2 = { -1, 0, 3, 5, 9, 12 };
            int target2 = 2;
            int result2 = binarySearchSolution.Search(case2, target2);
            stopwatch.Stop();
            Console.WriteLine("Result: " + result2);
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds);

            Stopwatch stopwatch3 = new Stopwatch();
            BinarySearchBestCaseSolution binarySearchBestCaseSolution = new BinarySearchBestCaseSolution();
            stopwatch3.Start();
            int result3 = binarySearchBestCaseSolution.Search(case2, target2);
            stopwatch3.Stop();
            Console.WriteLine("Result: " + result3);
            Console.WriteLine("Time: " + stopwatch3.ElapsedMilliseconds);
        }
    }
}
