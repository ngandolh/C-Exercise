namespace _1128_NumberEquivalentDominoPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumEquivDominoPairsSolution numEquivDominoPairsSolution = new NumEquivDominoPairsSolution();
            int[][] dominoes = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 1 },
                new int[] { 3, 4 },
                new int[] { 5, 6 }
            };
            int result = numEquivDominoPairsSolution.NumEquivDominoPairs(dominoes);
            Console.WriteLine($"Case 1: " + result); // Output: 1
        }
    }
}
