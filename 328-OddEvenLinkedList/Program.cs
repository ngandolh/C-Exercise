namespace _328_OddEvenLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OddEvenListSolution oddEvenListSolution = new OddEvenListSolution();
            ListNode head = new ListNode(2);
            head.next = new ListNode(1);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(5);
            head.next.next.next.next = new ListNode(6);
            head.next.next.next.next.next = new ListNode(4);
            head.next.next.next.next.next.next = new ListNode(7);

            ListNode result = oddEvenListSolution.OddEvenList(head);
            oddEvenListSolution.PrintList(result);

        }
    }
}
