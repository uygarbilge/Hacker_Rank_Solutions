using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReverseADoublyLinkedList
    {


        public static DoublyLinkedListNode reverse(DoublyLinkedListNode llist)
        {
            DoublyLinkedList reverseList = new DoublyLinkedList();

            //find tail of list, which will be the new head

            DoublyLinkedListNode newHead = llist; 

            while( newHead.next != null)
                newHead = newHead.next;

            reverseList.InsertNode(newHead.data);

            
            while(newHead.prev != null)
            {
                newHead = newHead.prev;
                reverseList.InsertNode(newHead.data);
            }
                 

            return reverseList.head;
        }



        public static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
                }
            }
        }

        public void Run()
        {
            DoublyLinkedList llist = new DoublyLinkedList();
            llist.InsertNode(1);
            llist.InsertNode(2);
            llist.InsertNode(3);
            llist.InsertNode(4);

            PrintDoublyLinkedList( reverse(llist.head), "");

        }


    }

    public class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }


    public class DoublyLinkedList
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }
}

