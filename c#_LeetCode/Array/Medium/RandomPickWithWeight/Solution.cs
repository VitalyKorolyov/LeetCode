using System;

namespace LeetCode.Array.Medium.RandomPickWithWeight;

//https://leetcode.com/problems/random-pick-with-weight/description/
public class Solution
{
    private readonly int[] sum;
    private readonly Random random;

    public Solution(int[] w)
    {
        sum = new int[w.Length];

        int prefixSum = 0;
        for (int i = 0; i < w.Length; ++i)
        {
            prefixSum += w[i];
            sum[i] = prefixSum;
        }

        random = new Random();
    }

    public int PickIndex()
    {
        double target = sum[sum.Length - 1] * random.NextDouble();

        int left = 0, right = sum.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (target < sum[mid])
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}