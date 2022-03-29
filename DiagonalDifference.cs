using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class DiagonalDifference
    {

        public static int diagonalDifference(List<List<int>> arr)
        {


            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;


            int arrayLlength = arr[0].Count;

            int row = 0;
            int col = 0;
            
            for(int i = 0; i < arrayLlength; i++)
            {
                int val = arr[row++][col++];
                rightDiagonalSum += val;
            }

            row = 0; 
            col = arrayLlength - 1;

            for (int i = 0; i < arrayLlength; i++)
            {
                int val = arr[row++][col--];
                leftDiagonalSum += val;
            }

            int result = Math.Abs(leftDiagonalSum - rightDiagonalSum);
            return result;


        }


        public void Run()
        {

            List<List<int>> arr = new List<List<int>>();

            List<int> a1 = new List<int>() {1, 2, 3, 6 };  
            List<int> a2 = new List<int>() { 4, 5, 6, 4 };
            List<int> a3 = new List<int>() { 9, 8, 9, 12 };
            List<int> a4 = new List<int>() { 4, 1, 4, 12 };

            arr.Add(a1);
            arr.Add(a2);
            arr.Add(a3);
            arr.Add(a4);

      
            int result = diagonalDifference(arr);

        }

    }
}

