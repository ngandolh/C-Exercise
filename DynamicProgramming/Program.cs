namespace DynamicProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClimbingStairsSolution climbingStairsSolution = new ClimbingStairsSolution();
            //int n1 = 1;
            //int n2 = 2;
            //int n3 = 4;

            //climbingStairsSolution.ClimbingStairs(n1);
            //Console.WriteLine("Result for n1: " + climbingStairsSolution.ClimbingStairs(n1));

            //climbingStairsSolution.ClimbingStairs(n2);
            //Console.WriteLine("Result for n2: " + climbingStairsSolution.ClimbingStairs(n2));

            //climbingStairsSolution.ClimbingStairs(n3);
            //Console.WriteLine("Result for n3: " + climbingStairsSolution.ClimbingStairs(n3));

            FibonacciNumberSolution fibonacciNumberSolution = new FibonacciNumberSolution();
            int n4 = 0;
            int n5 = 1;
            int n6 = 2;
            int n7 = 3;
            
            fibonacciNumberSolution.FibonacciNumber(n4); //Output: 0
            Console.WriteLine("Result for n4: " + fibonacciNumberSolution.FibonacciNumber(n4));
            fibonacciNumberSolution.FibonacciNumber(n5); //Output: 1
            Console.WriteLine("Result for n5: " + fibonacciNumberSolution.FibonacciNumber(n5));
            fibonacciNumberSolution.FibonacciNumber(n6); //Output: 1
            Console.WriteLine("Result for n6: " + fibonacciNumberSolution.FibonacciNumber(n6));
            fibonacciNumberSolution.FibonacciNumber(n7); //Output: 2
            Console.WriteLine("Result for n7: " + fibonacciNumberSolution.FibonacciNumber(n7));
        }
    }
}
