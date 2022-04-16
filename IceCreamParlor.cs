using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IceCreamParlor
    {

        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            List<int> list = new List<int>();

            for(int i = 0; i < arr.Count - 1; i++)
                for(int j = i + 1; j < arr.Count; j++)
                {
                    if(arr[i] + arr[j] == m)
                    {
                        list.Add(i+1);
                        list.Add(j +1);
                        break;
                    }
                }

            return list;
        }


        public void Run()
        {
            int m = 6;

            List<int> arr = new List<int>() { 1, 3 , 4 , 5 , 6 };


            
           var result =  icecreamParlor(m, arr);
           
            foreach(int i in result)    
                Console.WriteLine(i);

        }
    }
}
