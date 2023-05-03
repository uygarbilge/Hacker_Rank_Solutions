using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CycleDetection 
    {
        public static bool hasCycle(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode slow = head;
            SinglyLinkedListNode fast = head;
            
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (slow == fast)
                    return true;
            }
            return false; 
        }
         

        public void Run()
        {
             SinglyLinkedList singlyLinkedList = new SinglyLinkedList(); 
        }
    }
}
