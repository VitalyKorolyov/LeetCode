using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.SurroundedRegions;

//https://leetcode.com/problems/surrounded-regions/description/
public class Solution
{
    private readonly int[][] directions = new int[][]
    {
        new int[] {1, 0},
        new int[] {0, 1},
        new int[] {-1, 0},
        new int[] {0, -1}
    };

    public void Solve(char[][] board)
    {
        HashSet<(int, int)> visited = new();

        int rows = board.Length;
        int columns = board[0].Length;

        for (int i = 0; i < columns; i++)
            if (board[0][i] == 'O')
                Dfs(board, visited, 0, i);

        for (int i = 0; i < rows; i++)
            if (board[i][0] == 'O')
                Dfs(board, visited, i, 0);

        for (int i = 0; i < columns; i++)
            if (board[rows - 1][i] == 'O')
                Dfs(board, visited, rows - 1, i);

        for (int i = 0; i < rows; i++)
            if (board[i][columns - 1] == 'O')
                Dfs(board, visited, i, columns - 1);

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                var cell = (i, j);

                if (board[i][j] == 'O' && !visited.Contains(cell))
                    board[i][j] = 'X';
            }
        }
    }

    private void Dfs(char[][] board, HashSet<(int, int)> visited, int row, int column)
    {
        var cell = (row, column);

        if (row < 0 || column < 0) return;
        if (row >= board.Length || column >= board[row].Length) return;
        if (visited.Contains(cell)) return;
        if (board[row][column] == 'X') return;

        visited.Add(cell);

        foreach(var direction in directions)
        {
            var x = direction[0] + row;
            var y = direction[1] + column;

            Dfs(board, visited, x, y);
        }
    }
}
