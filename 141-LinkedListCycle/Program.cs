namespace _141_LinkedListCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HasCycleSolution hasCycleSolution = new HasCycleSolution();
            ListNode head = new ListNode(3);
            head.next = new ListNode(2);
            head.next.next = new ListNode(0);
            head.next.next.next = new ListNode(-4);
            head.next.next.next.next = head.next;

            bool hasCycle = hasCycleSolution.HasCycle(head); //Expected output: true
            Console.WriteLine("Has cycle: " + hasCycle);

            ListNode head2 = new ListNode(1);
            head2.next = new ListNode(2);

            bool result2 = hasCycleSolution.HasCycle(head2); //Expected output: false
            Console.WriteLine("Has cycle: " + result2);
        }
    }
}
