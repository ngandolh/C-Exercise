namespace _1920_BuildArrayfromPermutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildArraySolution buildArraySolution = new BuildArraySolution();
            int[] nums = { 0, 2, 1, 5, 3, 4 };
            int[] result = buildArraySolution.BuildArray(nums);
            Console.WriteLine($"Case 1" + string.Join(", ", result)); //Expected: 0, 1, 2, 4, 5, 3
        }
    }
}
