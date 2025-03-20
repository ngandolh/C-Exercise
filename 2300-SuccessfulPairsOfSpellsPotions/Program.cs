namespace _2300_SuccessfulPairsOfSpellsPotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuccessfulPairsSolution successfulPairsSolution = new SuccessfulPairsSolution();
            int[] spells = new int[] { 5, 1, 3 };
            int[] potions = new int[] { 1, 2, 3, 4, 5 };
            long success = 7;
            int[] result = successfulPairsSolution.SuccessfulPairs(spells, potions, success);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Second test case");
            int[] spells2 = new int[] { 3, 1, 2 };
            int[] potions2 = new int[] { 8, 5, 8 };
            long success2 = 16;
            int[] result2 = successfulPairsSolution.SuccessfulPairs(spells2, potions2, success2);
            foreach (int i in result2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Third test case");
            int[] spells3 = new int[] { 20, 26, 38, 23, 23, 20, 14, 30 };
            int[] potions3 = new int[] { 24, 1, 7, 26, 19, 17, 7 };
            long success3 = 510;
            int[] result3 = successfulPairsSolution.SuccessfulPairs(spells3, potions3, success3);
            foreach (int i in result3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
