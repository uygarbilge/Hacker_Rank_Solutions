using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GamingArray1
    {

        public static string gamingArray(List<int> arr)
        {

            int[] sortedArr = arr.ToArray();
            Array.Sort(sortedArr);


            //Bob plays  0
            //And plays  1


            int count = 0;
            int i = arr.Count - 1;

            while (i >= 0)
            {
                //find index of i in arr
                int index = arr.IndexOf(sortedArr[i]);

                i = index - 1;
                ;
                if (i == -1)
                    break;

                count++;
            }


            if (count % 2 == 0)
                return "BOB";
            else
                return "ANDY";


            /*
             *  int whoseTurn = 0;

            while( arr.Count > -1)
            {
                int max = arr.Max();
                int index = arr.IndexOf(max);
                arr.RemoveRange(index, arr.Count - index);
                if(arr.Count == 0)
                {
                    break;
                }

                whoseTurn++;
                whoseTurn = whoseTurn % 2;
            }


            if (whoseTurn == 0)
                return "BOB";
            else
                return "ANDY";
            */
        }


        public void Run()
        {
             
            List<int> arr = new List<int>() { 3,1};
            gamingArray( arr); 
        }


    }
}

