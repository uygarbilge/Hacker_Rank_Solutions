using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CounterGame
    {

        public static string counterGame(long n)
        {
            int whoseTurn = 0;
            //Louise = 0, Richard = 1
              
            while( n != 1)
            {
                if(n == 1)
                {
                    break;
                }

                if( IsPowerOfTwo(n) ) // n is power of 2
                {
                    n = n / 2;

                    if (n == 1)
                        break;
                }
                else  // current number is not 1 and it is not divisible by 2
                {
                    n -= ToNearest(n);

                    if (n == 1)
                        break;
                } 

                whoseTurn++;
            }

            return whoseTurn % 2 == 0 ? "Louise" : "Richard";
        }
 

        public static bool IsPowerOfTwo(long x)
        {
            return (x & (x - 1)) == 0;
        }

 
        public static int ToNearest(long x)
        {
            int next = ToNextNearest(x);
            int prev = next >> 1;
            return next - x < x - prev ? next : prev;
        }

        public static int ToNextNearest(long x)
        {
            if (x < 0) 
            { 
                return 0; 
            }
            --x;

            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return (int)x + 1;
        }

        public void Run()
        {

            var a = ToNearest(548);

            var result = counterGame(6);
            Console.WriteLine(result); 

        }


    }
}

