namespace LeetCode.Array.Easy.ArrangingCoins;

//https://leetcode.com/problems/arranging-coins/description/
public class Solution
{
    public int ArrangeCoins(int n)
    {
        if (n == 1) return 1;

        long left = 1;
        long right = n;

        while (left < right)
        {
            long mid = left + (right - left) / 2;
            long midResult = mid * (1 + mid) / 2;

            if (midResult > n)
                right = mid;
            else
                left = mid + 1;
        }

        return (int)left - 1;
    }
}