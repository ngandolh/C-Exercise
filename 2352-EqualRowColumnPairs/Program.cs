namespace _2352_EqualRowColumnPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqualPairsSolution equalPairsSolution = new EqualPairsSolution();
            int[][] grid = new int[][]
            {
                new int[] { 3, 2, 1 },
                new int[] { 1, 7, 6 },
                new int[] { 2, 7, 7 }
            };
            int result = equalPairsSolution.EqualPairs(grid);
            Console.WriteLine(result); // Expected output: 2
        }
    }
}
