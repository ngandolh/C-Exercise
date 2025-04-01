using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2130_MaximumTwinSumLinkedList
{
    internal class PairSumSolution
    {
        public int PairSum(ListNode head)
        {
            if (head == null)
            {
                return 0;
            }

            //Change ListNode to array
            List<int> values = new List<int>();
            ListNode temp = head;
            while (temp != null)
            {
                values.Add(temp.val);
                temp = temp.next;
            }

            //n is even
            int n = CountNodes(head);
            int twinNumber = (n / 2) - 1;
            int result = 0;
            for(int i = 0; i < n/2; i++)
            {
                int totalTwin = values[i] + values[n - 1 - i];
                result = Math.Max(result, totalTwin);
            }

            return result;

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
