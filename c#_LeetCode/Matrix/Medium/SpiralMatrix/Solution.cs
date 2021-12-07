using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.SpiralMatrix
{
    //https://leetcode.com/problems/spiral-matrix/
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var res = new List<int>(matrix.Length * matrix[0].Length);

            int rowSize = matrix.Length;
            int colSize = matrix[0].Length;
            int up = 0;
            int left = 0;
            int right = colSize - 1;
            int down = rowSize - 1;

            while (res.Count < rowSize * colSize)
            {
                // Traverse from left to right.
                for (int col = left; col <= right; col++)
                {
                    res.Add(matrix[up][col]);
                }
                // Traverse downwards.
                for (int row = up + 1; row <= down; row++)
                {
                    res.Add(matrix[row][right]);
                }
                // Make sure we are now on a different row.
                if (up != down)
                {
                    // Traverse from right to left.
                    for (int col = right - 1; col >= left; col--)
                    {
                        res.Add(matrix[down][col]);
                    }
                }
                // Make sure we are now on a different column.
                if (left != right)
                {
                    // Traverse upwards.
                    for (int row = down - 1; row > up; row--)
                    {
                        res.Add(matrix[row][left]);
                    }
                }

                left++;
                right--;
                up++;
                down--;
            }

            return res;
        }
    }
}