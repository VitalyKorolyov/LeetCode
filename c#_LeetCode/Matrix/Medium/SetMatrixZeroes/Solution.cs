using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.SetMatrixZeroes
{
    //https://leetcode.com/problems/set-matrix-zeroes/
    public class Solution
    {
        //O(n + m) extra space solution
        public static void SetZeroes(int[][] matrix)
        {
            var rows = new HashSet<int>();
            var cols = new HashSet<int>();

            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[0].Length; col++)
                {
                    if (matrix[row][col] != 0) continue;

                    rows.Add(row);
                    cols.Add(col);
                }
            }

            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[0].Length; col++)
                {
                    if (rows.Contains(row) || cols.Contains(col))
                    {
                        matrix[row][col] = 0;
                    }
                }
            }
        }
    }
}