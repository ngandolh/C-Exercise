namespace _1399_CountLargestGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountLargestGroupSolution countLargestGroupSolution = new CountLargestGroupSolution();
            int n1 = 13;
            int result1 = countLargestGroupSolution.CountLargestGroup(n1);
            Console.WriteLine($"Case 1: ");
            Console.WriteLine($"Input: {n1}, Output: {result1}");
        }
    }
}
