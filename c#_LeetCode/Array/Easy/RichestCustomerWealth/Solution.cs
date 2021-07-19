namespace LeetCode.Array.Easy.RichestCustomerWealth
{
    //https://leetcode.com/problems/richest-customer-wealth/
    public class Solution
    {
        public static int MaximumWealth(int[][] accounts)
        {
            var result = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                var sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sum += accounts[i][j];
                }

                if (result < sum) result = sum;
            }

            return result;
        }
    }
}