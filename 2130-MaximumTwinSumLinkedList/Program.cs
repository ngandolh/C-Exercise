namespace _2130_MaximumTwinSumLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PairSumSolution pairSumSolution = new PairSumSolution();
            ListNode head = new ListNode(4, new ListNode(2, new ListNode(2, new ListNode(3))));
            int result = pairSumSolution.PairSum(head);
            System.Console.WriteLine("Case 1: " + result);

            ListNode head2 = new ListNode(1, new ListNode(100000));
            int result2 = pairSumSolution.PairSum(head2);
            System.Console.WriteLine("Case 2: " + result2);
        }
    }
}
