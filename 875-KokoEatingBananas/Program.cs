namespace _875_KokoEatingBananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinEatingSpeedSolution minEatingSpeedSolution = new MinEatingSpeedSolution();
            int[] piles = new int[] { 3, 6, 7, 11 };
            int h = 8;
            int result = minEatingSpeedSolution.MinEatingSpeed(piles, h);
            System.Console.WriteLine(result);

            Console.WriteLine("=====================================");

            int[] piles2 = new int[] { 30, 11, 23, 4, 20 };
            int h2 = 5;
            int result2 = minEatingSpeedSolution.MinEatingSpeed(piles2, h2);
            System.Console.WriteLine(result2);

            Console.WriteLine("=====================================");

            int[] piles3 = new int[] { 30, 11, 23, 4, 20 };
            int h3 = 6;
            int result3 = minEatingSpeedSolution.MinEatingSpeed(piles3, h3);
            System.Console.WriteLine(result3);
        }
    }
}
