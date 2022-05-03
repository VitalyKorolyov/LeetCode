namespace LeetCode.Matrix.Medium.CountServersThatCommunicate
{
    //https://leetcode.com/problems/count-servers-that-communicate/
    public class Solution
    {
        public int CountServers(int[][] grid)
        {
            for (int row = 0; row < grid.Length; row++)
            {
                var firstRow = -1; 
                var firstColumn = -1;

                for (int column = 0; column < grid[0].Length; column++)
                {
                    if(grid[row][column] == 1)
                    {
                        if (firstRow == -1 && firstColumn == -1)
                        {
                            firstRow = row;
                            firstColumn = column;
                        }
                        else
                        {
                            grid[row][column] = 2;
                            grid[firstRow][firstColumn] = 2;
                        }
                    }
                }
            }

            for (int column = 0; column < grid[0].Length; column++)
            {
                var firstRow = -1;
                var firstColumn = -1;

                for (int row = 0; row < grid.Length; row++)
                {
                    if (grid[row][column] != 0)
                    {
                        if (firstRow == -1 && firstColumn == -1)
                        {
                            firstRow = row;
                            firstColumn = column;
                        }
                        else
                        {
                            grid[row][column] = 2;
                            grid[firstRow][firstColumn] = 2;
                        }
                    }
                }
            }

            var res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2) res++;
                }
            }

            return res;
        }
    }
}
