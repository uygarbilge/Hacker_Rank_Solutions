using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class TowerBreakers
    {

        public static int towerBreakers(int n, int m)
        {
            //n number of towers
            //m tower height
             
            int [] heights = new int[n];

            foreach(int i in heights)
                heights[i] = m;

            int winner = 0;

            while(true)
            {

                //Player 1 moves



                //Player 2 moves
                
            }

            return winner;
        }


        public void Run()
        {
            
            int n = 2;
            int m = 6;

            int result = towerBreakers(n, m);

        }
    }
}
