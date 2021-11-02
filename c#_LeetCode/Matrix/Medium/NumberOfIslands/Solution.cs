using System.Linq;

namespace LeetCode.Matrix.Medium.NumberOfIslands
{
    //https://leetcode.com/problems/number-of-islands/
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            var number = 0;

            if (grid == null || !grid.Any()) return number;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        number++;
                        Search(grid, i, j);
                    }
                }
            }

            return number;
        }

        private void Search(char[][] grid, int i, int j)
        {
            if(i < 0 || j < 0 || grid.Length <= i || grid[0].Length <= j || grid[i][j] == '0') return;

            grid[i][j] = '0';

            Search(grid, i + 1, j);
            Search(grid, i - 1, j);
            Search(grid, i, j + 1);
            Search(grid, i, j - 1);
        }
    }
}