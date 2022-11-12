namespace LeetCode.Matrix.Medium.MinimumPathSum
{
    //https://leetcode.com/problems/minimum-path-sum/description/
    public class Solution
    {
        public int MinPathSum(int[][] grid)
        {
            var matrix = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
                matrix[i] = new int[grid[0].Length];

            matrix[0][0] = grid[0][0];

            for (int i = 1; i < grid.Length; i++)
                matrix[i][0] = matrix[i - 1][0] + grid[i][0];

            for (int i = 1; i < grid[0].Length; i++)
                matrix[0][i] = matrix[0][i - 1] + grid[0][i];

            for (int i = 1; i < grid.Length; i++)
                for (int j = 1; j < grid[0].Length; j++)
                    matrix[i][j] = grid[i][j] + System.Math.Min(matrix[i][j - 1], matrix[i - 1][j]);

            return matrix[matrix.Length - 1][matrix[0].Length - 1];
        }


        //2^(m+n)
        //private int MinSum(int[][] grid, int i, int j)
        //{
        //    if (i == grid.Length || j == grid[0].Length) return int.MaxValue;
        //    if (i == grid.Length - 1 && j == grid[0].Length - 1) return grid[i][j];

        //    return grid[i][j] + System.Math.Min(MinSum(grid, i + 1, j), MinSum(grid, i, j + 1));
        //}
    }
}
