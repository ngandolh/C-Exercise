using System.Diagnostics;

namespace _912_SortAnArray
{

    // Example 1:

    //Input: nums = [5, 2, 3, 1]
    //Output: [1, 2, 3, 5]
    //Explanation: After sorting the array, the positions of some numbers are not changed(for example, 2 and 3), while the positions of other numbers are changed(for example, 1 and 5).
    //Example 2:

    //Input: nums = [5, 1, 1, 2, 0, 0]
    //Output: [0, 0, 1, 1, 2, 5]
    //Explanation: Note that the values of nums are not necessairly unique.
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] nums = { 5, 4, 3, 2, 1 };
            //var solution = new SortArraySolution();
            //solution.SortArray(nums);
            //Console.WriteLine("Result: " + string.Join(", ", nums));

            //var selectionSortSolution = new SelectionSortSolution();    
            //selectionSortSolution.SortArray(nums);
            //Console.WriteLine("Result: " + string.Join(", ", nums));

            //int[] case1 = { 5, 2, 3, 1 };
            //var selectionSortSolution1 = new SelectionSortSolution();
            //selectionSortSolution1.SortArray(case1);
            //Console.WriteLine("Result: " + string.Join(", ", case1));

            //int[] case2 = { 5, 1, 1, 2, 0, 0 };
            //var insertSortSolution = new InsertSortSolution();
            //insertSortSolution.SortArray(case2);
            //Console.WriteLine("Result: " + string.Join(", ", case2));

            //int[] arrayInsert = { 86, 13, 60, 73, 52, 40 };
            //var insertSortSolution1 = new InsertSortSolution();
            //insertSortSolution1.SortArray(arrayInsert);
            //Console.WriteLine("Result: " + string.Join(", ", arrayInsert));

            //int[] array = {73, 57, 49, 99, 133, 20, 1, 34 };
            //MergeSortSolution.MergeSort(array, 0, array.Length - 1);
            //Console.WriteLine("Result: " + string.Join(", ", array));

            //Expected: 14, 38, 39, 40, 42, 52, 67, 71, 96
            //Result: 14, 38, 39, 40, 42, 52, 67, 71, 96
            //Best case - Average: O(nlogn) - Worst case: O(n^2)
            //int[] array = {52, 96, 67, 71, 42, 38, 39, 40, 14 };
            //QuickSortSolution.QuickSort(array, 0, array.Length - 1);
            //stopwatch.Stop();
            //Console.WriteLine("Result: " + string.Join(", ", array));
            // Best Case (Mảng đã sắp xếp)
            int[] bestCaseArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Stopwatch bestCaseStopwatch = new Stopwatch();
            bestCaseStopwatch.Start();
            QuickSortSolution.QuickSort(bestCaseArray, 0, bestCaseArray.Length - 1);
            bestCaseStopwatch.Stop();

            Console.WriteLine("Best Case Result: " + string.Join(", ", bestCaseArray));
            Console.WriteLine("Best Case Time: " + bestCaseStopwatch.ElapsedTicks + " ticks");

            // Worst Case (Mảng sắp xếp giảm dần)
            int[] worstCaseArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Stopwatch worstCaseStopwatch = new Stopwatch();
            worstCaseStopwatch.Start();
            for (int i = 0; i < 5; i++)
            {
                int[] warmupArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                QuickSortSolution.QuickSort(warmupArray, 0, warmupArray.Length - 1);
            }
            worstCaseStopwatch.Stop();

            Console.WriteLine("Worst Case Result: " + string.Join(", ", worstCaseArray));
            Console.WriteLine("Worst Case Time: " + worstCaseStopwatch.ElapsedTicks + " ticks");
        }
    }
}
