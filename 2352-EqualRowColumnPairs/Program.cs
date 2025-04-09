namespace _2352_EqualRowColumnPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqualPairsSolution equalPairsSolution = new EqualPairsSolution();
            //int[][] grid = new int[][]
            //{
            //    new int[] { 3, 2, 1 },
            //    new int[] { 1, 7, 6 },
            //    new int[] { 2, 7, 7 }
            //};
            //int result = equalPairsSolution.EqualPairs(grid);
            //Console.WriteLine("Case 1: " + result); // Expected output: 1

            int[][] grid2 = new int[][]
            {
                new int[] {3, 1, 2, 2},
                new int[] {1, 4, 4, 5},
                new int[] {2, 4, 2, 2},
                new int[] {2, 4, 2, 2 }
            };
            int result2 = equalPairsSolution.EqualPairs(grid2);
            Console.WriteLine("Case 2: " + result2); // Expected output: 3
        }
    }
}
