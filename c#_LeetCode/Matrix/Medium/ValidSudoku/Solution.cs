using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.ValidSudoku
{
    //https://leetcode.com/problems/valid-sudoku/description/
    public class Solution
    {
        //public bool IsValidSudoku(char[][] board)
        //{
        //    HashSet<string> seen = new();

        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            if (board[i][j] != '.') 
        //            {
        //                var rowKey = $"r{i}={board[i][j]}";
        //                var columnKey = $"c{j}={board[i][j]}";
        //                var boxKey = $"b{i/3}-{j/3}={board[i][j]}";

        //                if (seen.Contains(rowKey)) return false;
        //                if(seen.Contains(columnKey)) return false;
        //                if(seen.Contains(boxKey)) return false;

        //                seen.Add(rowKey);
        //                seen.Add(columnKey);
        //                seen.Add(boxKey);
        //            }
        //        }
        //    }

        //    return true;
        //}

        public bool IsValidSudoku(char[][] board)
        {
            HashSet<char> hashSetRows = new(board.Length);
            HashSet<char> hashSetColumns = new(board.Length);

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (hashSetRows.Contains(board[i][j])) return false;
                        hashSetRows.Add(board[i][j]);
                    }
                    if (board[j][i] != '.')
                    {
                        if (hashSetColumns.Contains(board[j][i])) return false;
                        hashSetRows.Add(board[j][i]);
                    }
                }

                hashSetRows.Clear();
                hashSetColumns.Clear();
            }

            HashSet<char> hashSetBox = new(board.Length);
            for (int i = 0; i < board.Length; i += 3)
            {
                for (int j = 0; j < board.Length; j += 3)
                {
                    if (!ChechBox(i, j, board, hashSetBox)) return false;
                    hashSetBox.Clear();
                }
            }

            return true;
        }

        private bool ChechBox(int i, int j, char[][] board, HashSet<char> hashSetBox)
        {
            for (int m = i; m < 3 + i; m++)
            {
                for (int n = j; n < 3 + j; n++)
                {
                    if (board[m][n] != '.')
                    {
                        if (hashSetBox.Contains(board[m][n])) return false;
                        hashSetBox.Add(board[m][n]);
                    }
                }
            }

            return true;
        }
    }
}
