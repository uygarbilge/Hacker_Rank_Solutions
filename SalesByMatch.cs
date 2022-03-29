using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class SalesByMatch
    {

        public static int sockMerchant(int n, List<int> ar)
        {
            int numOfPairs = 0;

            Hashtable h = new Hashtable();

            for(int i = 0; i < ar.Count; i++)
            {
                if(h.ContainsKey(ar[i]))
                {
                    h[ar[i]] = (int)h[ar[i]] + 1;
                }
                else
                    h[ar[i]] = 1;
            }

            foreach( int key in h.Keys)
            {
                if ((int)h[key] == 1)
                    ;
                else // (key >=2)
                {
                    int divide = (int)h[key] / 2;

                    numOfPairs += divide;
                }
            }


            return numOfPairs;
        }

        public void Run()
        {
            
            List<int> ar = new List<int> { 1, 2, 1, 2 , 1, 3 , 2 };   

            int result = sockMerchant(ar.Count, ar);

        }

    }
}

