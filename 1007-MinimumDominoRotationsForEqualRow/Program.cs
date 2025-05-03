namespace _1007_MinimumDominoRotationsForEqualRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinDominoRotationsSolution minDominoRotationsSolution = new MinDominoRotationsSolution();
            //int[] tops = { 2, 1, 2, 4, 2, 2 };
            //int[] bottoms = { 5, 2, 6, 2, 3, 2 };
            //int result = minDominoRotationsSolution.MinDominoRotations(tops, bottoms);
            //Console.WriteLine($"Case 1: " + result); // Output: 2

            ////Test case 2
            //int[] tops2 = { 3, 5, 1, 2, 3 };
            //int[] bottoms2 = { 3, 6, 3, 3, 4 };
            //int result2 = minDominoRotationsSolution.MinDominoRotations(tops2, bottoms2);
            //Console.WriteLine($"Case 2: " + result2); // Output: -1

            ////Test case 3
            //int[] tops3 = { 1, 1, 1, 1, 1, 1, 1, 1 };
            //int[] bottoms3 = { 1, 1, 1, 1, 1, 1, 1, 1 };
            //int result3 = minDominoRotationsSolution.MinDominoRotations(tops3, bottoms3);
            //Console.WriteLine($"Case 3: " + result3); // Output: 0

            //Test case 4
            int[] tops4 = { 1, 2, 1, 1, 1, 2, 2, 2 };
            int[] bottoms4 = { 2, 1, 2, 2, 2, 2, 2, 2 };
            int result4 = minDominoRotationsSolution.MinDominoRotations(tops4, bottoms4);
            Console.WriteLine($"Case 4: " + result4); // Output: 1    

            ////Test case 5
            //int[] tops5 = { 1, 2, 3, 4, 6 };
            //int[] bottoms5 = { 6, 6, 6, 6, 5 };
            //int result5 = minDominoRotationsSolution.MinDominoRotations(tops5, bottoms5);
            //Console.WriteLine($"Case 5: " + result5); // Output: 1
        }
    }
}
