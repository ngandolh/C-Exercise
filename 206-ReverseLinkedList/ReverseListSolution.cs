using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206_ReverseLinkedList
{
    internal class ReverseListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode pre = null;
            ListNode current = head;
            while (current != null)
            {
                ListNode next = current.next;
                current.next = pre;
                pre = current;
                current = next;
            }

            return pre;
        }

        //public ListNode ReverseList(ListNode head)
        //{
        //    ListNode prev = null;
        //    ListNode current = head;

        //    while (current != null)
        //    {
        //        ListNode next = current.next; // Lưu lại node tiếp theo
        //        current.next = prev; // Đảo chiều liên kết
        //        prev = current; // Di chuyển prev lên current
        //        current = next; // Di chuyển current lên next
        //    }
        //    return prev; // prev sẽ là node đầu tiên sau khi đảo ngược
        //}
    }
}
