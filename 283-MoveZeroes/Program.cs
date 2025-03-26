namespace _283_MoveZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoveZeroesSolution moveZeroesSolution = new MoveZeroesSolution();
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            Console.WriteLine("Before: " + string.Join(", ", nums));
            moveZeroesSolution.MoveZeroes2(nums);
            Console.WriteLine("After: " + string.Join(", ", nums));
        }
    }
}
