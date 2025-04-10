namespace _867_TransposeMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransposeSolution transposeSolution = new TransposeSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            int[][] transposedMatrix = transposeSolution.Transpose(matrix);
            Console.WriteLine("Case 1: ");
            foreach (var row in transposedMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            Console.WriteLine("==========================");

            int[][] matrix2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            };
            int[][] transposedMatrix2 = transposeSolution.Transpose(matrix2);
            Console.WriteLine("Case 2: ");
            //foreach (var row in transposedMatrix2)
            //{
            //    Console.WriteLine(string.Join(" ", row));
            //}
        }
    }
}
