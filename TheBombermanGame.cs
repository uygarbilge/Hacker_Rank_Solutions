using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class TheBombermanGame
    {


        public  List<string> bomberMan(int n, List<string> grid)
        { 

            int second = 0;

            //Create double int array to keep track of which cells will explode in 3rd second

            bool [][] cellsToDetonate =  SetCellsToDetonate(grid);

     
            second = 1;

            //Second 1: Bomberman does nothing
            if( n == 1)
            {
                return grid;
            }

            //Second 2: Bomberman plants bombs in all cells without bombs
            second = 2;

            //set all cells to bomb, but do not touch cellsToDetonate array

            for (int i = 0; i < grid.Count; i++)
                grid[i] = grid[i].Replace(".", "O");
                 

            if ( n == 2)
            {
                return grid;
            }


            //Second 3: any bombs planted exactly three seconds ago will detonate.

            List<string> newGrid = GenereateGridAfterExplosion(cellsToDetonate, grid);


            second = 3;
            if( n == 3)
            {
                return grid;
            }

            // if n >= 4, repeat second 2 and 3 repeatedly

            second = 4;

            while (second <= n)
            {
               

                if (second % 2 == 0  )
                {
                   cellsToDetonate = SetCellsToDetonate(grid);

                    for (int i = 0; i < grid.Count; i++)
                        grid[i] = grid[i].Replace(".", "O");
                }

                if (second % 2 == 1)
                {
                    grid = GenereateGridAfterExplosion(cellsToDetonate, grid);
                }
                
                second++;
            }
             
            return grid;
        }


        public static  bool [][] SetCellsToDetonate(List<string> grid)
        {
            bool[][] cellsToDetonate = new bool[grid.Count][];

            for (int i = 0; i < grid.Count; i++)
            {
                cellsToDetonate[i] = new bool[grid[0].Length];

                for (int j = 0; j < grid[0].Length; j++)
                {
                    cellsToDetonate[i][j] = grid[i][j] == '.' ? false : true;
                }
            }

            return cellsToDetonate;
        }


        public static List<string> GenereateGridAfterExplosion(bool[][] cellsToDetonate, List<string> allBombGrid)
        { 

            int rowCount = cellsToDetonate.Length;
            int colCount = cellsToDetonate[0].Length;

            //iterate in cellsToDetonate array.
            // If it is a bomb, replace it and its neighbors to "." in allBombgrid

            for(int i = 0; i < rowCount; i++)
            {

                for(int j = 0; j < colCount; j++)
                {

                    if (cellsToDetonate[i][j] == true) // it is a bomb
                    {
                       
                        //explode itself
                        StringBuilder sb = new StringBuilder(allBombGrid[i]);
                        sb[j] = '.';
                        allBombGrid[i] = sb.ToString();



                        //explode 1 up if in boundary
                        if (i - 1 >= 0)
                        {
                            sb = new StringBuilder(allBombGrid[i-1]);
                            sb[j] = '.';
                            allBombGrid[i-1] = sb.ToString();
                        }

                        //explode 1 down if in boundary
                        if (i + 1 < rowCount)
                        {
                            sb = new StringBuilder(allBombGrid[i + 1]);
                            sb[j] = '.';
                            allBombGrid[i + 1] = sb.ToString();
                        }


                        //explode 1 left if in boundary
                        if (j - 1 >= 0)
                        {
                            sb = new StringBuilder(allBombGrid[i]);
                            sb[j-1] = '.';
                            allBombGrid[i] = sb.ToString();
                        }

                        //explode 1 right if in boundary
                        if (j + 1 <  colCount)
                        {
                            sb = new StringBuilder(allBombGrid[i]);
                            sb[j + 1] = '.';
                            allBombGrid[i] = sb.ToString();
                        }


                    }
                }
            }


            return allBombGrid;
        }

        public void Run()
        {
            List<string> grid = new List<string>();
            grid.Add(".......");
            grid.Add("...O...");
            grid.Add("....O..");
            grid.Add(".......");
            grid.Add("OO.....");
            grid.Add("OO.....");
 

            //grid.Add("...");
            //grid.Add(".O.");
            //grid.Add("...");

            int n = 4;

            var result = bomberMan(n, grid);

            Console.WriteLine(String.Join("\n", result));


        }

    }
}

