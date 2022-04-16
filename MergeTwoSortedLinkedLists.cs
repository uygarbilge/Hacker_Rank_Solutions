using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MergeTwoSortedLinkedLists
    {

       public  static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
         
            SinglyLinkedList mergedList = new SinglyLinkedList();

            SinglyLinkedListNode iteratorNode1 = head1;
            SinglyLinkedListNode iteratorNode2 = head2;


            while (true)
            {
                if (iteratorNode1 != null && iteratorNode2 != null)
                {
                    if (iteratorNode1.data < iteratorNode2.data)
                    {
                        mergedList.InsertNode(iteratorNode1.data);
                        iteratorNode1 = iteratorNode1.next;
                    }
                     
                    else if (iteratorNode1.data >= iteratorNode2.data)
                    {
                        mergedList.InsertNode(iteratorNode2.data);
                        iteratorNode2 = iteratorNode2.next;
                    }
                }
                else if (iteratorNode1 == null && iteratorNode2 != null)
                {
                    while (iteratorNode2 != null)
                    {
                        mergedList.InsertNode(iteratorNode2.data);
                        iteratorNode2 = iteratorNode2.next;
                    }

                }
                else if (iteratorNode1 != null && iteratorNode2 == null)
                {
                    while (iteratorNode1 != null)
                    {
                        mergedList.InsertNode(iteratorNode1.data);
                        iteratorNode1 = iteratorNode1.next;
                    }
                }
                else if (iteratorNode1 == null && iteratorNode2 == null)
                {
                    break;
                }
            }
             
            return mergedList.head;

        }

        public static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
                }
            }
        }


        public void Run()
        {

     

            SinglyLinkedList list1 = new SinglyLinkedList();
            list1.InsertNode(2);
            list1.InsertNode(3);
            list1.InsertNode(5);

            SinglyLinkedList list2 = new SinglyLinkedList();
            list2.InsertNode(1);
            list2.InsertNode(2);
            list2.InsertNode(3);
            list2.InsertNode(4);



            SinglyLinkedListNode result = mergeLists(list2.head, list1.head);

             PrintSinglyLinkedList(result , " ");

        }

    }




}

