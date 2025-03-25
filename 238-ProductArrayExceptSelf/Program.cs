namespace _238_ProductArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductExceptSelfSolution productExceptSelfSolution = new ProductExceptSelfSolution();
            int[] nums = new int[] { 1, 2, 3, 4 };
            int[] result = productExceptSelfSolution.ProductExceptSelf(nums);
            foreach (int i in result)
            {
                System.Console.WriteLine(i);
            }

            Console.WriteLine("================================================================");
        }
    }
}
