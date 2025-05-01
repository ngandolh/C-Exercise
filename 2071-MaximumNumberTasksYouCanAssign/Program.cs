namespace _2071_MaximumNumberTasksYouCanAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxTaskAssignSolution maxTaskAssignSolution = new MaxTaskAssignSolution();
            int[] tasks = { 3, 1, 5, 4 };
            int[] workers = { 2, 2, 3, 4 };
            int pills = 1;
            int strength = 1;
            int result = maxTaskAssignSolution.MaxTaskAssign(tasks, workers, pills, strength);
            Console.WriteLine(result); // Output: 3

            // Test case 2
            int[] tasks2 = { 5, 4, 3, 2, 1 };
            int[] workers2 = { 1, 2, 3, 4, 5 };
            int pills2 = 0;
            int strength2 = 0;
            int result2 = maxTaskAssignSolution.MaxTaskAssign(tasks2, workers2, pills2, strength2);
            Console.WriteLine(result2); // Output: 5

            // Test case 3
            int[] tasks3 = { 3, 2, 1 };
            int[] workers3 = { 0, 3, 3 };
            int pills3 = 1;
            int strength3 = 1;
            int result3 = maxTaskAssignSolution.MaxTaskAssign(tasks3, workers3, pills3, strength3);
            Console.WriteLine(result3); // Output: 3
        }
    }
}
