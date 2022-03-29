using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class LonelyInteger
    {

        public static int lonelyinteger(List<int> a)
        {
            int lonelyInt = 0;

            int [] array = a.ToArray();
            Array.Sort(array);

            bool loneFound = false;
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (i == 0 && array[i] != array[i+1])
                {
                    lonelyInt = array[0];
                    loneFound = true;
                    break;
                }

                if (array[i] != array[i + 1] && array[i] != array[i-1])
                {
                    lonelyInt = array[i ];
                   loneFound = true;
                    break;
                }
            }
           if(!loneFound)
                lonelyInt = array[array.Length - 1];

            return lonelyInt;
        }

        public void Run()
        {
            List<int> a = new() {1, 1 ,2 ,3 ,3, 2, 1, 12 } ;
            lonelyinteger(a);

        }
    

    }
}

