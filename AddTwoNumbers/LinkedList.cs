public class AddTwoNumbers
{
    //public static void Main(string[] args)
    //{
    //    LinkedList<int> list = new LinkedList<int>();
    //    list.AddLast(2);
    //    list.AddLast(4);
    //    list.AddLast(3);
    //    LinkedList<int> list2 = new LinkedList<int>();
    //    list2.AddLast(5);
    //    list2.AddLast(6);
    //    list2.AddLast(4);
    //    TwoList(list, list2);
    //}

    public static LinkedList<int> TwoList(LinkedList<int> list1, LinkedList<int> list2)
    {
        int temp = 0;
        bool def = false;
        LinkedListNode<int> node1 = list1.First;
        LinkedListNode<int> node2 = list2.First;
        LinkedList<int> result = new LinkedList<int>();
        Console.WriteLine($"Node 1: {node1.Value}");
        Console.WriteLine($"Node 2: {node2.Value}");
        while (node1 != null && node2 != null)
        {
            if (def == false)
            {
                temp = node1.Value + node2.Value;
            }
            else
            {
                temp = node1.Value + node2.Value + 1;
            }
            if (temp > 9)
            {
                def = true;
                temp = 0;
            }
            result.AddLast(temp);
            node1 = node1.Next;
            node2 = node2.Next;
        }
        return result;
    }
}