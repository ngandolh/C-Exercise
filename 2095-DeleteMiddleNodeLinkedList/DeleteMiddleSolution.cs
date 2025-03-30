using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace _2095_DeleteMiddleNodeLinkedList
{
    internal class DeleteMiddleSolution
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            //Case: ListNode still 1 node
            if (head == null || head.next == null) return null;

            int n = CountNodes(head);
            int middle = n /2;
         
            ListNode current = head;
            ListNode prev = null;

            int count = 0;
            Console.WriteLine("Middle: " + middle);

            if (middle == 0)
            {
                return head.next;
            }
            
            while(count < middle)
            {
                prev = current;
                Console.WriteLine("Prev: ");
                PrintNodes(prev);
                current = current.next;
                Console.WriteLine("Current: ");
                PrintNodes(current);
                count++;
            }

            prev.next = current.next;

            return head;
        }

        public int CountNodes(ListNode head)
        {
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            return count;
        }

        public void PrintNodes(ListNode head)
        {
            while(head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }
            Console.WriteLine(" ");
        }
    }
}
