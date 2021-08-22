using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.SetMatrixZeroes
{
    //https://leetcode.com/problems/set-matrix-zeroes/
    public class Solution
    {
        //constant space
        public static void SetZeroes(int[][] matrix)
        {
            bool isCol = false;
            int R = matrix.Length;
            int C = matrix[0].Length;

            for (int i = 0; i < R; i++)
            {

                // Since first cell for both first row and first column is the same i.e. matrix[0][0]
                // We can use an additional variable for either the first row/column.
                // For this solution we are using an additional variable for the first column
                // and using matrix[0][0] for the first row.
                if (matrix[i][0] == 0)
                {
                    isCol = true;
                }

                for (int j = 1; j < C; j++)
                {
                    // If an element is zero, we set the first element of the corresponding row and column to 0
                    if (matrix[i][j] == 0)
                    {
                        matrix[0][j] = 0;
                        matrix[i][0] = 0;
                    }
                }
            }

            // Iterate over the array once again and using the first row and first column, update the elements.
            for (int i = 1; i < R; i++)
            {
                for (int j = 1; j < C; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            // See if the first row needs to be set to zero as well
            if (matrix[0][0] == 0)
            {
                for (int j = 0; j < C; j++)
                {
                    matrix[0][j] = 0;
                }
            }

            // See if the first column needs to be set to zero as well
            if (isCol)
            {
                for (int i = 0; i < R; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }

        ////O(n + m) extra space solution
        //public static void SetZeroes(int[][] matrix)
        //{
        //    var rows = new HashSet<int>();
        //    var cols = new HashSet<int>();

        //    for (var row = 0; row < matrix.Length; row++)
        //    {
        //        for (var col = 0; col < matrix[0].Length; col++)
        //        {
        //            if (matrix[row][col] != 0) continue;

        //            rows.Add(row);
        //            cols.Add(col);
        //        }
        //    }

        //    for (var row = 0; row < matrix.Length; row++)
        //    {
        //        for (var col = 0; col < matrix[0].Length; col++)
        //        {
        //            if (rows.Contains(row) || cols.Contains(col))
        //            {
        //                matrix[row][col] = 0;
        //            }
        //        }
        //    }
        //}
    }
}