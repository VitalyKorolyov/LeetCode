namespace LeetCode.Matrix.Medium.DifferenceBetweenOnesAndZerosInRowAndColumn;

//https://leetcode.com/problems/difference-between-ones-and-zeros-in-row-and-column/description/
public class Solution
{
    public int[][] OnesMinusZeros(int[][] grid)
    {
        var row = new int[grid.Length];
        var col = new int[grid[0].Length];

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1) row[i]++;
                if (grid[i][j] == 0) row[i]--;
            }
        }

        for (int i = 0; i < grid[0].Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                if (grid[j][i] == 1) col[i]++;
                if (grid[j][i] == 0) col[i]--;
            }
        }

        int[][] diff = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            diff[i] = new int[grid[0].Length];
            for (int j = 0; j < grid[0].Length; j++)
                diff[i][j] = row[i] + col[j];
        }

        return diff;
    }
}