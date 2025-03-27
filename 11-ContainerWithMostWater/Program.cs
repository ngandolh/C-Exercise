namespace _11_ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxAreaSolution maxAreaSolution = new MaxAreaSolution();
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }; // Expected output: 49
            int maxArea = maxAreaSolution.MaxArea(height);
            Console.WriteLine($"Max Area: {maxArea}");

            height = new int[] { 1, 1 }; // Expected output: 1
            maxArea = maxAreaSolution.MaxArea(height);
            Console.WriteLine($"Max Area: {maxArea}");
        }
    }
}
