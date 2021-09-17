namespace LeetCode.Math.Easy.FibonacciNumber
{
    //https://leetcode.com/problems/fibonacci-number/
    public class Solution
    {
        public int Fib(int n)
        {
            if (n <= 1) return n;

            var priv1 = 0;
            var priv2 = 1;
            var current = 0;

            for (int i = 2; i <= n; i++)
            {
                current = priv1 + priv2;
                priv1 = priv2;
                priv2 = current;
            }

            return current;
        }

        public int FibArraySolution(int n)
        {
            if (n <= 1) return n;

            var ar = new int[n + 1];
            ar[0] = 0;
            ar[1] = 1;

            for (int i = 2; i <= n; i++)
                ar[i] = ar[i - 1] + ar[i - 2];

            return ar[n];
        }

        public int Recursive(int n)
        {
            if (n <= 1) return n;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}