namespace LeetCode.Matrix.Medium.RotateImage
{
    //https://leetcode.com/problems/rotate-image/
    /*
    * clockwise rotate
    * first reverse up to down, then swap the symmetry 
    * 1 2 3     7 8 9     7 4 1
    * 4 5 6  => 4 5 6  => 8 5 2
    * 7 8 9     1 2 3     9 6 3
    */

    /*
     * anticlockwise rotate
     * first reverse left to right, then swap the symmetry
     * 1 2 3     3 2 1     3 6 9
     * 4 5 6  => 6 5 4  => 2 5 8
     * 7 8 9     9 8 7     1 4 7
    */
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length / 2; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[matrix.Length - i - 1][j];
                    matrix[matrix.Length - i - 1][j] = temp;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }
    }
}
