namespace _3341_FindMinimumTimeReachLastRoomI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinTimeToReachSolution minTimeToReachSolution = new MinTimeToReachSolution();
            int[][] moveTime = new int[][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 1, 0, 3 },
                new int[] { 2, 3, 0 }
            };

            int result = minTimeToReachSolution.MinTimeToReach(moveTime);
            Console.WriteLine(result); // Expected output: 5

            // Test case with no path
            int[][] moveTime2 = new int[][]
            {
                new int[] { 0, 4},
                new int[] { 4, 4 }
            };

            int result2 = minTimeToReachSolution.MinTimeToReach(moveTime2);
            Console.WriteLine(result2); // Expected output: 6
        }
    }
}
