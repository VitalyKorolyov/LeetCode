using System.Linq;

namespace LeetCode.Array.Medium.KokoEatingBananas;

//https://leetcode.com/problems/koko-eating-bananas/description/
public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();

        while(left < right)
        {
            int mid = left + (right - left) / 2;

            if (CanEat(piles, mid, h))
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }

    private bool CanEat(int[] piles, int k, int h)
    {
        int sum = 0;

        foreach (int pile in piles)
            sum += (pile - 1) / k + 1;

        return sum <= h;
    }
}