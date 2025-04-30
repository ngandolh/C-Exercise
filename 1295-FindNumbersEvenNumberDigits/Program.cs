namespace _1295_FindNumbersEvenNumberDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindNumbersSolution findNumbersSolution = new FindNumbersSolution();
            int[] nums = { 12, 345, 2, 6, 7896 };
            int result = findNumbersSolution.FindNumbers(nums);
            Console.WriteLine($"The count of numbers with even number of digits is: {result}"); //Output: 2

            // Test case 2
            int[] nums2 = { 555, 901, 482, 1771 };
            int result2 = findNumbersSolution.FindNumbers(nums2);
            Console.WriteLine($"The count of numbers with even number of digits is: {result2}"); //Output: 1

            int[] nums3 = { 1, 2, 3, 4, 5 };
            int result3 = findNumbersSolution.FindNumbers(nums3);
            Console.WriteLine($"The count of numbers with even number of digits is: {result3}"); //Output: 0
        }
    }
}
