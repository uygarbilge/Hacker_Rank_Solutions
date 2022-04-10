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
            int result = 0;

            int row1Sum = s[0][0] + s[0][1] + s[0][2];
            int row2Sum = s[1][0] + s[1][1] + s[1][2];
            int row3Sum = s[2][0] + s[2][1] + s[2][2];

            int col1Sum = s[0][0] + s[1][0] + s[2][0];
            int col2Sum = s[0][1] + s[1][1] + s[2][1];
            int col3Sum = s[0][2] + s[1][2] + s[2][2];

            int downDiagonal = s[0][0] + s[1][1] + s[2][2];
            int upDiagonal = s[0][2] + s[1][1] + s[2][0];

            bool magic = checkIfMagic(row1Sum, row2Sum, row3Sum, col1Sum, col2Sum, col3Sum, downDiagonal, upDiagonal);

            
            


            if (magic)
                return result;



            return result;
        }

        public static bool checkIfMagic(int row1, int row2, int row3, 
                                 int col1, int col2, int col3,
                                int downDiagonal, int upDiagonal)
        {
            if (row1 == row2 &&
                row2 == row3 &&
                row3 == col1 &&
                col1 == col2 &&
                col2 == col3 &&
                col3 == downDiagonal &&
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

