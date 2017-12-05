
public ListNode deleteDuplicates(ListNode A) {
            
            ListNode cur = A;
            ListNode next = A.next;
            while(next != null)
            {
                if(cur.val == next.val)
                {
                    cur.next = next.next;
                    next = cur.next;
                }
                else
                {
                    cur = next;
                    next = next.next;
                }
            }
            
            return A;
            
            
    }
