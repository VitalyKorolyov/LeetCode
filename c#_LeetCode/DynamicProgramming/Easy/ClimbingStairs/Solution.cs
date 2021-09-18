namespace LeetCode.DynamicProgramming.Easy.ClimbingStairs
{
    //https://leetcode.com/problems/climbing-stairs/
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;

            int prev1 = 1;
            int prev2 = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = prev1 + prev2;
                prev1 = prev2;
                prev2 = third;
            }

            return prev2;
        }

        public int ClimbStairsRecursive(int n)
        {
            return Calc(n, 0);
        }

        private int Calc(int n, int i)
        {
            if (i > n) return 0;
            if (i == n) return 1;

            return Calc(n, i + 1) + Calc(n, i + 2);
        }
    }
}