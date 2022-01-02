using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Matrix.Hard
{
    //https://leetcode.com/problems/word-search-ii/
    public class Solution
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            var res = new HashSet<string>();

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[0].Length; col++)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (board[row][col] != words[i][0] || res.Contains(words[i])) continue;

                        var isExist = IsExist(board, row, col, words[i], 0);

                        if (isExist)
                            res.Add(words[i]);
                    }
                }
            }

            return res.ToList();
        }

        private bool IsExist(char[][] board, int row, int col, string word, int wordIndex)
        {
            if (row < 0 || row > board.Length - 1 || col < 0 || col > board[0].Length - 1)
                return false;

            if (board[row][col] != word[wordIndex]) return false;

            if (word.Length - 1 == wordIndex) return true;

            board[row][col] = '#';

            var res = IsExist(board, row, col - 1, word, wordIndex + 1)
                      || IsExist(board, row - 1, col, word, wordIndex + 1)
                      || IsExist(board, row, col + 1, word, wordIndex + 1)
                      || IsExist(board, row + 1, col, word, wordIndex + 1);

            board[row][col] = word[wordIndex];

            return res;
        }
    }
}