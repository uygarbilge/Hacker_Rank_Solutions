using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LeftRotation
    {

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            List<int> result = new List<int>();
            
            int[] array = arr.ToArray();

            int [] newArray = new int[array.Length];


            for(int i = 0; i < array.Length; i++)
            {
              

                int newIndex = i - d;

                while ( newIndex  < 0)
                    newIndex +=  arr.Count;

                newArray[newIndex] = array[i];
            }

            result = newArray.ToList();


            return result;
        }


        public void Run()
        {


            int d = 32;
            List<int> arr = new List<int>() { 1, 2, 4, 5 };
            rotateLeft(d, arr);


        }


    }
}

