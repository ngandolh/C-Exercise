using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MergeTwoSortedLists
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            // Khởi tạo list1 = [1, 2, 4]
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);

            // Khởi tạo list2 = [1, 3, 4]
            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Nếu một trong hai danh sách là null, trả về danh sách còn lại
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            // Tạo một nút giả (dummy node) để giữ kết quả
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            // Lặp qua hai danh sách
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    // Thêm nút từ list1
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    // Thêm nút từ list2
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next; // Di chuyển con trỏ đến nút tiếp theo
            }

            // Nếu còn phần tử trong một danh sách, nối nó vào kết quả
            if (list1 != null)
            {
                current.next = list1;
            }
            if (list2 != null)
            {
                current.next = list2;
            }

            // Trả về danh sách đã hợp nhất (bỏ qua nút giả)
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

    }
}
