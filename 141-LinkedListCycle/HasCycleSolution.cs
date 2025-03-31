using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141_LinkedListCycle
{
    internal class HasCycleSolution
    {
        public bool HasCycle(ListNode head)
        {
            //Cycle detection using Floyd's Tortoise and Hare algorithm
            if (head == null || head.next == null)
            {
                return false;
            }

            ListNode slow = head;
            ListNode fast = head;
            //Pos = -1 means no cycle
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;

            //Pos != -1 means there is a cycle
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
    }
}
