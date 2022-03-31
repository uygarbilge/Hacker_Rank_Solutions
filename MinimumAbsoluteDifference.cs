using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinimumAbsoluteDifference

    {
        public static int minimumAbsoluteDifference(List<int> arr)
        {
            int minAbs = Int32.MaxValue ; 

            int [] array = arr.ToArray();
            Array.Sort(array);

            for(int i = 0; i < array.Length - 1; i++)
            {
                int diff = Math.Abs(array[i+1] - array[i]);
                if(diff < minAbs)
                {
                    minAbs = diff;
                }
                 
            } 

            return minAbs;
        }


        public void Run()
        {
             List<int> arr = new List<int>() { 1, 4, 8, -1, 10 };   
            minimumAbsoluteDifference(arr);

        }
    }
}
