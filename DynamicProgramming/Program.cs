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

            //FibonacciNumberSolution fibonacciNumberSolution = new FibonacciNumberSolution();
            //int n4 = 0;
            //int n5 = 1;
            //int n6 = 2;
            //int n7 = 3;

            //fibonacciNumberSolution.FibonacciNumber(n4); //Output: 0
            //Console.WriteLine("Result for n4: " + fibonacciNumberSolution.FibonacciNumber(n4));
            //fibonacciNumberSolution.FibonacciNumber(n5); //Output: 1
            //Console.WriteLine("Result for n5: " + fibonacciNumberSolution.FibonacciNumber(n5));
            //fibonacciNumberSolution.FibonacciNumber(n6); //Output: 1
            //Console.WriteLine("Result for n6: " + fibonacciNumberSolution.FibonacciNumber(n6));
            //fibonacciNumberSolution.FibonacciNumber(n7); //Output: 2 
            //Console.WriteLine("Result for n7: " + fibonacciNumberSolution.FibonacciNumber(n7));

            HouseRobberSolution houseRobberSolution = new HouseRobberSolution();
            int[] nums1 = { 2, 7, 9, 3, 1 };
            int[] nums2 = { 1, 2, 3, 1 };
            int[] nums3 = { 2, 1, 1, 2 };
            int[] nums4 = { 1, 2, 3, 4, 5 };

            int result1 = houseRobberSolution.Rob(nums1);
            Console.WriteLine("Result for nums1: " + result1); //Output: 12
            //int result2 = houseRobberSolution.Rob(nums2);
            //Console.WriteLine("Result for nums2: " + result2); //Output: 4
            //int result3 = houseRobberSolution.Rob(nums3);
            //Console.WriteLine("Result for nums3: " + result3); //Output: 4
            //int result4 = houseRobberSolution.Rob(nums4);
            //Console.WriteLine("Result for nums4: " + result4); //Output: 9
        }
    }
}
