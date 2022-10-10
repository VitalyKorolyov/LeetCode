namespace LeetCode.Matrix.Medium.SearchA2DMatrixII
{
    //https://leetcode.com/problems/search-a-2d-matrix-ii/
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if(matrix == null || matrix[0].Length == 0) return false;

            var row = matrix.Length - 1;
            var col = 0;

            while (col < matrix[0].Length && row >= 0)
            {
                if (matrix[row][col] == target) return true;

                if (matrix[row][col] < target)
                    col++;
                else
                    row--;
            }

            return false;
        }
    }
}
