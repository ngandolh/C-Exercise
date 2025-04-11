namespace _2843_CountSymmetricIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountSymmetricIntegersSolution solution = new CountSymmetricIntegersSolution();
            int low = 1;
            int high = 1000;
            int result = solution.CountSymmetricIntegers(low, high);
            Console.WriteLine($"Count of symmetric integers between {low} and {high}: {result}"); //Expected output: 9

            // Test with other ranges
            int low2 = 1200;
            int high2 = 1230;
            int result2 = solution.CountSymmetricIntegers(low2, high2);
            Console.WriteLine($"Count of symmetric integers between {low2} and {high2}: {result2}"); //Expected output: 4   
        }
    }
}
