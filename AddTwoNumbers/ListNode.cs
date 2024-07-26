using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNodeExample
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        static ListNode TwoListNode(ListNode l1, ListNode l2, int carry)
        {
            // Base case: If both input linked lists are null and there is no carry, return null
            if (l1 == null && l2 == null && carry == 0)
                return null;

            // Calculate the total sum of current digits along with the carry
            int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;

            // Calculate the new carry for the next iteration
            carry = total / 10;

            // Create a new node with the value of the total modulo 10 and recursively call the function for the next digits
            ListNode result = TwoListNode(l1.next, l2.next, carry);
            return new ListNode(total % 10, result);
        }

        //public static void Main(string[] args)
        //{
        //    ListNode listNode1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        //    ListNode listNode2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        //    ListNode listNode = TwoListNode(listNode1, listNode2, 0);
        //    while (true)
        //    {
        //        Console.WriteLine(listNode.val);
        //        if (listNode.next == null) break;
        //        listNode = listNode.next;
        //    }
        //    Console.ReadLine();
        //}
    }
}
