using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.WordSearch
{
    //https://leetcode.com/problems/word-search/
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            for (int col = 0; col < board.Length; col++)
            {
                for (int row = 0; row < board[0].Length; row++)
                {
                    if (board[col][row] == word[0])
                    {
                        var isExist = IsExist(board, col, row, word, 0);
                        if (isExist) return true;
                    }
                }
            }

            return false;
        }

        private bool IsExist(char[][] board, int col, int row, string word, 
            int indexWord)
        {
            if (col < 0 || row < 0 || col > board.Length - 1 
                || row > board[0].Length - 1 || word.Length - 1 < indexWord) return false;

            if (board[col][row] != word[indexWord]) return false;

            if (word.Length - 1 == indexWord) return true;

            board[col][row] = '#';

            var res = IsExist(board, col - 1, row, word, indexWord + 1)
                   || IsExist(board, col, row - 1, word, indexWord + 1)
                   || IsExist(board, col + 1, row, word, indexWord + 1)
                   || IsExist(board, col, row + 1, word, indexWord + 1);

            board[col][row] = word[indexWord];

            return res;
        }
    }
}