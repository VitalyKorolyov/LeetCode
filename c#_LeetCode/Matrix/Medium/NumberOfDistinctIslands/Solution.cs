using System.Collections.Generic;
using System.Text;

namespace LeetCode.Matrix.Medium.NumberOfDistinctIslands;

//https://leetcode.com/problems/number-of-distinct-islands/description/
public class Solution
{
    public int NumDistinctIslands(int[][] grid)
    {
        HashSet<string> hash = new();
        HashSet<(int, int)> visited = new();

        for (int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(!visited.Contains((i, j)) && grid[i][j] == 1)
                {
                    StringBuilder shape = new();
                    Dfs(grid, i, j, i, j, shape, visited);
                    hash.Add(shape.ToString());
                }
            }
        }

        return hash.Count;
    }

    private void Dfs(int[][] grid, int i, int j, int iOriginal, int jOriginal, 
        StringBuilder shape, HashSet<(int, int)> visited)
    {
        if (i < 0 || i >= grid.Length) return;
        if (j < 0 || j >= grid[i].Length) return;
        if (grid[i][j] != 1) return;

        var currentCell = (i, j);
        if (visited.Contains(currentCell)) return;

        visited.Add(currentCell);

        int iCurrent = iOriginal - i;
        int jCurrent = jOriginal - j;
        shape.Append($"({iCurrent},{jCurrent})");

        Dfs(grid, i + 1, j, iOriginal, jOriginal, shape, visited);
        Dfs(grid, i, j + 1, iOriginal, jOriginal, shape, visited);
        Dfs(grid, i - 1, j, iOriginal, jOriginal, shape, visited);
        Dfs(grid, i, j - 1, iOriginal, jOriginal, shape, visited);
    }
}