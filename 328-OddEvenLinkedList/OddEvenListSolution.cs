using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _328_OddEvenLinkedList
{
    internal class OddEvenListSolution
    {
        public ListNode OddEvenList(ListNode head)
        {
            //Odd - Even number of nodes
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenHead = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                Console.WriteLine("Odd.next = even.next: ");
                PrintList(odd);

                odd = odd.next;
                Console.WriteLine("Odd = odd.next: ");
                PrintList(odd);

                even.next = odd.next;
                Console.WriteLine("Even.next = odd.next: ");
                PrintList(even);

                even = even.next;
                Console.WriteLine("Even = event.next: ");
                PrintList(even);

                Console.WriteLine();
            }
            Console.WriteLine("Even head: ");
            PrintList(evenHead);

            odd.next = evenHead; //connect odd to even head

            return head;
        }

        public void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }

            Console.WriteLine();
        }
    }
}
