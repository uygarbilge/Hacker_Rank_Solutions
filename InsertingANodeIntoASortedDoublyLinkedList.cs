using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class InsertingANodeIntoASortedDoublyLinkedList
    {

        public static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode llist, int data)
        {
            DoublyLinkedListNode iteratorNode;

            //if data is less than or equal to the head data, create a new header node and return it
            if( llist.data >= data )
            {
                iteratorNode = new DoublyLinkedListNode(data);
                iteratorNode.next = llist;
                llist.prev = iteratorNode;
                return iteratorNode;
            }


            //new node data is greater than head node data
            iteratorNode = llist;

            while( true )
            {
                if(iteratorNode.next != null)
                {
                    if (iteratorNode.data <= data && iteratorNode.next.data >= data)
                    {
                        //create a new node
                        DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);

                        //arrange bindings
                        newNode.next = iteratorNode.next;
                        iteratorNode.next.prev = newNode;

                        iteratorNode.next = newNode;
                        newNode.prev = iteratorNode;  
                        break;
                    }
                }
                //the end of list, this means the node to be inserted will be inserted to the end (tail)
                else{

                    DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);
                    //arrange bindings
                    iteratorNode.next = newNode;
                    newNode.prev = iteratorNode;  
                    break;
                }

                iteratorNode = iteratorNode.next; 

            }



            return llist;
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

            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            doublyLinkedList.InsertNode(8);
            doublyLinkedList.InsertNode(9);
            doublyLinkedList.InsertNode(10);
            doublyLinkedList.InsertNode(11);


            int data = 12;

            DoublyLinkedListNode node = sortedInsert(doublyLinkedList.head, data);


            PrintDoublyLinkedList(node, " ");


        }
    }
}
