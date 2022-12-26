namespace LeetCode.Matrix.Easy.CheckifEveryRowAndColumnContainsAllNumbers
{
    //https://leetcode.com/problems/check-if-every-row-and-column-contains-all-numbers/
    public class Solution
    {
        public bool CheckValid(int[][] matrix)
        {
            int n = matrix.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var index = System.Math.Abs(matrix[i][j]) - 1;
                    if (matrix[i][index] < 0) return false;

                    matrix[i][index] *= -1; 
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var index = System.Math.Abs(matrix[j][i]) - 1;
                    if (matrix[index][i] > 0) return false;

                    matrix[index][i] *= -1;
                }
            }

            return true;
        }
    }
}
