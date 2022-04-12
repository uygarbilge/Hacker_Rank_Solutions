using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class FormingAMagicSquare
    {

        public static int formingMagicSquare(List<List<int>> s)
        { 
            
            int compare = compareWithMagics(s);  
            return compare;
        }

        public static int compareWithMagics(List<List<int>> s)
        {
            int minAbsDifference = int.MaxValue;

            List<List<int>> magics = new List<List<int>>();

            List<int> magic1 = new List<int>() { 4, 9, 2, 3, 5, 7, 8, 1, 6};
            List<int> magic2 = new List<int>() { 2, 7, 6, 9, 5, 1, 4, 3, 8 };
            List<int> magic3 = new List<int>() { 6, 1, 8, 7, 5, 3, 2, 9, 4 };
            List<int> magic4 = new List<int>() { 8, 3, 4, 1, 5, 9, 6, 7, 2 };
            List<int> magic5 = new List<int>() { 2, 9, 4, 7, 5, 3, 6, 1, 8 };
            List<int> magic6 = new List<int>() { 6, 7, 2, 1, 5, 9, 8, 3, 4 };
            List<int> magic7 = new List<int>() { 8, 1, 6, 3, 5, 7, 4, 9, 2 };
            List<int> magic8 = new List<int>() { 4, 3, 8, 9, 5, 1, 2, 7, 6 };

            magics.Add(magic1);
            magics.Add(magic2);
            magics.Add(magic3);
            magics.Add(magic4);
            magics.Add(magic5);
            magics.Add(magic6);
            magics.Add(magic7);
            magics.Add(magic8);

            int [] sArray = new int[9];
            sArray[0] = s[0][0];
            sArray[1] = s[0][1];
            sArray[2] = s[0][2];

            sArray[3] = s[1][0];
            sArray[4] = s[1][1];
            sArray[5] = s[1][2];

            sArray[6] = s[2][0];
            sArray[7] = s[2][1];
            sArray[8] = s[2][2];

            for (int i = 0; i < 8; i++)
            {
                int diff = 0;

                for(int index = 0; index < 9; index++)
                {
                    int num = Math.Abs( sArray[index] - magics[i][index] );
                    diff += num;
                }

                if(diff < minAbsDifference)
                    minAbsDifference = diff;
            }
            
             

            return minAbsDifference;
        }


        public static bool isMagicSquare(List<List<int>> s)
        {
            int row1Sum = s[0][0] + s[0][1] + s[0][2];
            int row2Sum = s[1][0] + s[1][1] + s[1][2];
            int row3Sum = s[2][0] + s[2][1] + s[2][2];

            int col1Sum = s[0][0] + s[1][0] + s[2][0];
            int col2Sum = s[0][1] + s[1][1] + s[2][1];
            int col3Sum = s[0][2] + s[1][2] + s[2][2];

            int downDiagonal = s[0][0] + s[1][1] + s[2][2];
            int upDiagonal = s[0][2] + s[1][1] + s[2][0];

            if (row1Sum == row2Sum &&
                row2Sum == row3Sum &&
                row3Sum == col1Sum &&
                col1Sum == col2Sum &&
                col2Sum == col3Sum &&
                col3Sum == downDiagonal &&
                downDiagonal == upDiagonal)
                return true;
            else
                return false;
        }



        public void Run()
        {

            List<List<int>> s = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
            }

            int result = formingMagicSquare(s);


        }

    }
}

