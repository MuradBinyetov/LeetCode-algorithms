using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class RemoveDuplicatesFromSortedList
    {

        public static ListNodeClass DeleteDuplicates(ListNodeClass head) // [1,1,2,3,3]
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var start = head;
            while (start.next != null)
            {
                if (start.val == start.next.val)
                {
                    start.next = start.next.next;
                }
                else
                {
                    start = start.next;
                }
            }

            return head;
        } 
    }


        

    public class ListNodeClass
    {
        public int val;
        public ListNodeClass next;
        public ListNodeClass(int val = 0, ListNodeClass next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
