using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Subtract
    {
        public ListNode subtract(ListNode A)
        {
            ListNode current = A;
            ListNode slow = A;
            ListNode fast = slow.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

            }
            ListNode temp = reverseList(slow.next);
            ListNode secondHalf = temp;
            while (current != null && secondHalf != null)
            {
                current.val = secondHalf.val - current.val;
                current = current.next;
                secondHalf = secondHalf.next;
            }
            reverseList(temp);


            return A;

        }

        private static ListNode reverseList(ListNode slow)
        {
            ListNode previous = null;
            ListNode current = slow;
            ListNode temp;
            while (current != null)
            {
                temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }
            slow = previous;
            return slow;
        }
    }
}
