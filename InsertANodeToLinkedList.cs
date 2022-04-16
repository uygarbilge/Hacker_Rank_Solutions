using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InsertANodeToLinkedList
    {

        public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
        {
            SinglyLinkedListNode result = llist;

            //find the node in the position
            int index = 0;
    
            while (index != position -1 )
            {
                result = result.next;
                index++;
            }

            //create a new node
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            //make the next node of originial node new node's next
            newNode.next = result.next;


            //make the next node of original node new node
            result.next = newNode;


            return llist;
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

            SinglyLinkedList llist = new SinglyLinkedList();

            
 
            llist.InsertNode(1);
            llist.InsertNode(2);
            llist.InsertNode(3);
            llist.InsertNode(4);
            llist.InsertNode(5);
            llist.InsertNode(6);


            int data = 7;

            int position = 5;

            SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

            Console.WriteLine("-------------");
            PrintSinglyLinkedList(llist_head, "");
 
        }


    }
}

