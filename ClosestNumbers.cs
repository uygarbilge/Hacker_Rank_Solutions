using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class ClosestNumbers
    {

        public static List<int> closestNumbers(List<int> arr)
        {
            List<int> result = new List<int>();

            int[] sortedArray = arr.ToArray();
            Array.Sort(sortedArray);
           

            int minAbsDifference = Int32.MaxValue;

            for(int i = 0; i < sortedArray.Length -1; i++)
            {
                int diff = sortedArray[i + 1] - sortedArray[i];

                if(diff < minAbsDifference)
                    minAbsDifference = diff;
            }

            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                int diff = sortedArray[i + 1] - sortedArray[i];
                
                if(diff == minAbsDifference)
                {
                    result.Add( sortedArray[i]);
                    result.Add(sortedArray[i+1]);
                }
            }

                return result;  
        }

        public void Run()
        {
             
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();


            closestNumbers(arr); ;
        }
    }
}
