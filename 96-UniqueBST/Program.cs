namespace _96_UniqueBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniqueBSTSolution uniqueBSTSolution = new UniqueBSTSolution();
            int case1 = 3;
            int result = uniqueBSTSolution.NumTrees(case1);
            System.Console.WriteLine(result);

            Console.WriteLine("=========================================");

            int case2 = 1;
            int result2 = uniqueBSTSolution.NumTrees(case2);
            System.Console.WriteLine(result2);

            Console.WriteLine("=========================================");

            int case3 = 19;
            int result3 = uniqueBSTSolution.NumTrees(case3);
            System.Console.WriteLine(result3);

        }
    }
}
