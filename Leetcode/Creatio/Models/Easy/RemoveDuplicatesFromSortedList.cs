using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class RemoveDuplicatesFromSortedList
    {
        public Node DeleteDuplicates(Node head)
        {
            Node current = head;

            /* Pointer to store the next
            pointer of a node to be deleted*/
            Node next_next;

            /* do nothing if the list is empty */
            if (head == null)
                return head;

            /* Traverse list till the last node */
            while (current.next != null)
            {
                /*Compare current node with the next node */
                if (current.val == current.next.val)
                {
                    next_next = current.next.next;
                    current.next = null;
                    current.next = next_next;
                }
                else // advance if no deletion
                    current = current.next;
            }
            return head;
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node(int val = 0, Node next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
