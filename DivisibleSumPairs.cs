using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DivisibleSumPairs
    {

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int [] array = ar.ToArray();
            Array.Sort(array);



            int result = 0;

            for(int i = 0; i < array.Length; i++)
                for(int j = i + 1; j < array.Length; j++)
                {
                   if( ( (array[i] + array[j]))%k == 0 )
                    {
                        Pair pair = new Pair(); 
                        pair.i = array[i];
                        pair.j = array[j];      
                        
                        result++;
                       
                    }    
                } 

            return result;
        }

        class Pair
        {
            public int i;
            public int j;

            public bool Compare(Pair p1, Pair p2)
            {
                if (p1.i == p2.i && p1.j == p2.j)
                    return true;

                return false;
            }

        }

        public void Run()
        {
          // List<int> ar = new List<int>() { 1, 2, 3, 1, 2, 6 };

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            divisibleSumPairs(6, 66, ar);

        }
    }
}
