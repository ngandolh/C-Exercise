namespace _1732_FindTheHighestAltitude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LargestAltitudeSolution largestAltitudeSolution = new LargestAltitudeSolution();
            int[] gain = new int[] { -5, 1, 5, 0, -7 }; //Expected output: 1
            int result = largestAltitudeSolution.LargestAltitude2(gain);
            Console.WriteLine(
                $"The highest altitude is {result}");

            Console.WriteLine("========================================");

            int[] gain2 = new int[] { -4, -3, -2, -1, 4, 3, 2 }; //Expected output: 0
            int result2 = largestAltitudeSolution.LargestAltitude2(gain2);
            Console.WriteLine(
                $"The highest altitude is {result2}");

            Console.WriteLine("========================================");

            int[] gain3 = new int[] { 44, 32, -9, 52, 23, -50, 50, 33, -84, 47, -14, 84, 36, 
                -62, 37, 81, -36, -85, -39, 67, -63, 64, -47, 95, 91, -40, 65, 67, 92, -28, 97, 100, 81 }; //Expected output: 781
            int result3 = largestAltitudeSolution.LargestAltitude2(gain3);
            Console.WriteLine(
                $"The highest altitude is {result3}");
        }
    }
}
