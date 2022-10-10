namespace LeetCode.Matrix.Medium.SearchA2DMatrix
{
    //https://leetcode.com/problems/search-a-2d-matrix/
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var m = matrix.Length;
            if(m == 0) return false;

            var n = matrix[0].Length;
            var left = 0;
            var right = (n * m) - 1;

            while (left <= right)
            {
                var middleIndex = (left + right) / 2;
                var middleElement = matrix[middleIndex / n][middleIndex % n];

                if(target == middleElement) return true;

                if (target < middleElement)
                    right = middleIndex - 1;
                else
                    left = middleIndex + 1;
            }

            return false;
        }
    }
}
