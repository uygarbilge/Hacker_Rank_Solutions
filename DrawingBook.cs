using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class DrawingBook
    {

        public static int pageCount(int n, int p)
        {
            int minPage = 0;

            /*
             
                1
            2   3
            4   5
            6   7
       

            98  99
            100
             */

            //find the total number of array elements ( page pairs)
            int pagePairCount = 0;
            pagePairCount = (n / 2) + 1;


            //find the pair index of the page searched
            int searchPageIndex =  (p / 2) + 1;

            //find which end is  closer by difference
            int frontDistance = searchPageIndex - 1;
            int endDistance = pagePairCount - searchPageIndex;

            if (frontDistance < endDistance)
                minPage = frontDistance;
            else
                minPage = endDistance;
             
            return minPage;
        }

        public void Run()
        {
            int n = 5; //number of pages in the book

            int p = 3; //page number

            int result = pageCount(n, p);

        }

    }
}

