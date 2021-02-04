using System;

namespace LeetCode.Array.Easy.CountPrimes
{
    //https://leetcode.com/problems/count-primes/
    public class Solution
    {
        public static int CountPrimes(int n)
        {
            if (n == 0 || n == 1) return 0;

            Span<bool> numbers = stackalloc bool[n - 2];
            numbers.Fill(true);

            for (var i = 2; i * i < n; i++)
            {
                if (!numbers[i - 2]) continue;

                for (var j = i * i; j < n; j += i)
                    numbers[j - 2] = false;
            }

            var count = 0;
            foreach (var number in numbers)
                if (number) count++;

            return count;
        }
    }
}