using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GridChallenge

    {

        public static string gridChallenge(List<string> grid)
        {
            int rowLength = grid.Count;
            int colLength = grid[0].Length;

            //generate double array

            int[][] array = new int[rowLength][];

            for (int i = 0; i < rowLength; i++)
            {
                array[i] = new int[colLength];
                for (int j = 0; j < colLength; j++)
                {

                    char c = grid[i][j];
                    array[i][j] = c;
                }
            }

            for(int i = 0; i < rowLength; i++) 
                Array.Sort(array[i]);

            for (int col = 0; col < colLength - 1 ; col++)
            {
                for (int row = 0; row < rowLength -1 ; row++)
                {
                    if(array[row+1][col] < array[row][col])
                    {
                        return "NO";
                    }
                }
            }

            return "YES";
        }

        public void Run()
        {

             

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<string> grid = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    string gridItem = Console.ReadLine();
                    grid.Add(gridItem);
                }

                string result = gridChallenge(grid);

                Console.WriteLine(result);
            }

          
        }
    
    }
}
