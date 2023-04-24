namespace LeetCode.Math.Easy.Sqrt_x_;

//https://leetcode.com/problems/sqrtx/description/
public class Solution
{
    public int MySqrt(int x)
    {
        if(x < 2) return x;

        long left = 0;
        long right = x;

        while(left < right)
        {
            long mid = left + (right - left) / 2;

            long num = mid * mid;
            if (num > x)
                right = mid;
            else
                left = mid + 1;
        }

        return (int)left - 1;
    }
}
