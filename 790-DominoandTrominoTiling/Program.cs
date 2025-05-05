namespace _790_DominoandTrominoTiling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumTilingsSolution numTilingsSolution = new NumTilingsSolution();
            int n = 3; // Example input
            int result = numTilingsSolution.NumTilings(n);
            Console.WriteLine($"Number of ways to tile a 2x{n} board: {result}"); // Output the result: 5
        }
    }
}
