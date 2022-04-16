using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class QueueUsingTwoStacks

    {

      
        public void Run()
        {

            Queue<int> queue = new Queue<int>();

            int q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                List<int> values = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                int command = values[0];


                if (command == 1) //Enqueue
                {

                    int value = values[1];

                    queue.Enqueue(value);

                }
                else if(command == 2)  //dequeue
                {
                    queue.Dequeue();
                    
                }
                else if(command == 3)  //print the front element
                {
                    Console.WriteLine(queue.Peek());
                }


            }
        }

        //public static void ProcessCommand( int commandType, int value)
        //{
        //    if(commandType == 1)
        //    {

        //    }
        //    else if(commandType == 2)
        //    {

        //    }
        //    else if(commandType == 3)
        //    {

        //    }
        //}
    
    
    }
}
