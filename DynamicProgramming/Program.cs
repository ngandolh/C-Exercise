namespace DynamicProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClimbingStairsSolution climbingStairsSolution = new ClimbingStairsSolution();
            int n1 = 1;
            int n2 = 2;
            int n3 = 4;

            climbingStairsSolution.ClimbingStairs(n1);
            Console.WriteLine("Result for n1: " + climbingStairsSolution.ClimbingStairs(n1));

            climbingStairsSolution.ClimbingStairs(n2);
            Console.WriteLine("Result for n2: " + climbingStairsSolution.ClimbingStairs(n2));

            climbingStairsSolution.ClimbingStairs(n3);
            Console.WriteLine("Result for n3: " + climbingStairsSolution.ClimbingStairs(n3));
        }
    }
}
