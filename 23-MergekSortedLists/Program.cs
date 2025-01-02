﻿
namespace _23_MergekSortedLists
{
    internal class Solutions
    {
        static void Main(string[] args)
        {
            ListNode[] lists1 = new ListNode[]
            {
                CreateLinkedList(new int[] { 1, 4, 5 }),
                CreateLinkedList(new int[] { 1, 3, 4 }),
                CreateLinkedList(new int[] { 2, 6 })
            };

            ListNode merged1 = new Solutions().MergeKLists(lists1);
            PrintListNode(merged1 );
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            List<int> mergeList = new List<int>();

            foreach (ListNode l in lists)
            {
                var current = l;
                while (current != null)
                {
                    mergeList.Add(l.val);
                    current = current.next;
                }
            }

            mergeList.Sort();

            ListNode dummy = new ListNode(-1);
            ListNode currentNode = dummy;

            foreach (int item in mergeList)
            {
                currentNode.next = new ListNode(item);
                currentNode = currentNode.next;
            }

            return dummy.next;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode CreateLinkedList(int[] values)
        {
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            foreach (int value in values)
            {
                current.next = new ListNode(value);
                current = current.next;
            }

            return dummy.next;
        }

        //public static void PrintListNode(ListNode request)
        //{
        //    ListNode current = request;
        //    while (current != null)
        //    {
        //        Console.WriteLine(current.val);
        //        if (current.next != null)
        //        {
        //            Console.WriteLine("->");
        //            current = current.next;
        //        }
        //        Console.WriteLine();
        //    }
        //}
        public static void PrintListNode(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val); // Print the value of the node
                if (current.next != null)
                {
                    Console.Write("->"); // Print the arrow if there is a next node
                }
                current = current.next;
            }
            Console.WriteLine(); // Move to the next line after printing the list
        }
    }
}
