using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EqualStacks 
    {
       

        public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
        {

            StackStates states = new StackStates();
            states.SetStackStates(h1, h2, h3);  

            while(true)
            {
                //if any of the stacks are empty, return 0
                if(states.AnyStackIsEmpty())    
                    return 0;


                if (states.AllAreEqual())
                    return states.Stack1Sum; //return any of 3 as all are same

                //find the stack with max sum and pop 1 from it
                if( states.Stack1Sum > states.Stack2Sum && states.Stack1Sum >= states.Stack3Sum ||
                    states.Stack1Sum >= states.Stack2Sum && states.Stack1Sum > states.Stack3Sum)
                {
                    h1.RemoveAt(0);

                }
                else if (states.Stack2Sum > states.Stack1Sum && states.Stack2Sum >= states.Stack3Sum ||
                         states.Stack2Sum >= states.Stack1Sum && states.Stack2Sum > states.Stack3Sum)
                {
                    h2.RemoveAt(0);

                }
                else if (states.Stack3Sum > states.Stack1Sum && states.Stack3Sum >= states.Stack2Sum ||
                         states.Stack3Sum >= states.Stack1Sum && states.Stack3Sum > states.Stack2Sum)
                {
                    h3.RemoveAt(0);

                }

                //refresh stack sums
                states.SetStackStates(h1, h2, h3); 
            } 
             
        }
 

    

        public void Run()
        {
            List<int> h1 = new List<int>() { 3, 2, 1, 1, 1};
            List<int> h2 = new List<int>() { 4, 3 , 2 };
            List<int> h3 = new List<int>() { 1, 1, 4, 1 };

            int result = equalStacks(h1, h2, h3);   

            Console.WriteLine(result);
        }
    }

     public  class StackStates
    {
        public int Stack1Sum;
        public int Stack2Sum;
        public int Stack3Sum;

        public int Stack1Size;
        public int Stack2Size;
        public int Stack3Size;

        public void SetStackStates( List<int> h1, List<int> h2, List<int> h3)
        {
            Stack1Sum = 0;

            for(int i = 0; i < h1.Count; i++)
                Stack1Sum += h1[i];

            Stack1Size = h1.Count;

            ////////////////
            Stack2Sum = 0;

            for (int i = 0; i < h2.Count; i++)
                Stack2Sum += h2[i];

            Stack2Size = h2.Count;
            /////////////////////
            Stack3Sum = 0;

            for (int i = 0; i < h3.Count; i++)
                Stack3Sum += h3[i];

            Stack3Size = h3.Count;

        }

        public bool AllAreEqual()
        {
            if(Stack1Sum == Stack2Sum && Stack2Sum == Stack3Sum)
                return true;

            return false;
        }

        public bool AnyStackIsEmpty()
        {
            if(Stack1Sum == 0 || 
                Stack2Sum == 0 ||
                Stack3Sum == 0)
                return true;

            return false;   
        }

     

    }
}
