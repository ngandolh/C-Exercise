namespace _2095_DeleteMiddleNodeLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteMiddleSolution deleteMiddleSolution = new DeleteMiddleSolution();
            //ListNode head = new ListNode(1, 
            //                new ListNode(3, 
            //                new ListNode(4, 
            //                new ListNode(7, 
            //                new ListNode(1, 
            //                new ListNode(2, 
            //                new ListNode(6)))))));
            //ListNode result = deleteMiddleSolution.DeleteMiddle(head);
            //deleteMiddleSolution.PrintNodes(result);

            ListNode head2 = new ListNode(1,
                            new ListNode(2,
                            new ListNode(3,
                            new ListNode(4))));
            ListNode result2 = deleteMiddleSolution.DeleteMiddle(head2);
            deleteMiddleSolution.PrintNodes(result2);
        }
    }
}
