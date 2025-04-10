namespace _1207_UniqueNumberOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniqueOccurrencesSolution uniqueOccurrencesSolution = new UniqueOccurrencesSolution();
            int[] arr = { 1, 2, 2, 1, 1, 3 };
            bool result = uniqueOccurrencesSolution.UniqueOccurrences(arr);
            Console.WriteLine(result); // Output: true

            int[] arr2 = { 1, 2 };
            bool result2 = uniqueOccurrencesSolution.UniqueOccurrences(arr2);
            Console.WriteLine(result2); // Output: false

            int[] arr3 = {-3, 0, 1, -3, 1, 1,1 , -3, 10, 0 };
            bool result3 = uniqueOccurrencesSolution.UniqueOccurrences(arr3);
            Console.WriteLine(result3); // Output: true

        }
    }
}
