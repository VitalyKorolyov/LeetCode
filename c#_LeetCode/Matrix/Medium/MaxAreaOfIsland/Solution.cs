namespace LeetCode.Matrix.Medium.MaxAreaOfIsland
{
    //https://leetcode.com/problems/max-area-of-island/
    public class Solution
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            var maxArea = 0;

            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[i].Length; j++)
                    if (grid[i][j] == 1)
                        maxArea = System.Math.Max(Dfs(grid, i, j), maxArea);

            return maxArea;
        }

        private int Dfs(int[][] grid, int i, int j)
        {
            if (i < 0 || j < 0) return 0;
            if(grid.Length <= i || grid[i].Length <= j) return 0;
            if (grid[i][j] == 0) return 0;

            grid[i][j] = 0;

            return 1 + 
                Dfs(grid, i + 1, j) + 
                Dfs(grid, i - 1, j) + 
                Dfs(grid, i, j + 1) + 
                Dfs(grid, i, j - 1);
        }
    }
}
