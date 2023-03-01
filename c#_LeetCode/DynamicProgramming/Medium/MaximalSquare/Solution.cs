namespace LeetCode.DynamicProgramming.Medium.MaximalSquare;

//https://leetcode.com/problems/maximal-square/description/
public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        int rows = matrix.Length, cols = rows > 0 ? matrix[0].Length : 0;
        int[,] dp = new int[rows + 1, cols + 1];
        int maxsqlen = 0;

        for (int i = 1; i <= rows; i++)
            for (int j = 1; j <= cols; j++)
                if (matrix[i - 1][j - 1] == '1')
                {
                    dp[i, j] = System.Math.Min(System.Math.Min(dp[i, j - 1], dp[i - 1, j]), dp[i - 1, j - 1]) + 1;
                    maxsqlen = System.Math.Max(maxsqlen, dp[i, j]);
                }

        return maxsqlen * maxsqlen;
    }
}