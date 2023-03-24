namespace LeetCode.Math.Medium.ReverseInteger;

//https://leetcode.com/problems/reverse-integer/description/
public class Solution
{
    public int Reverse(int x)
    {
        int res = 0;

        while (x != 0)
        {
            int value = x % 10;
            x /= 10;

            if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && value > 7)) return 0;
            if (res < int.MinValue / 10 || (res == int.MinValue / 10 && value < -8)) return 0;

            res = res * 10 + value;
        }

        return res;
    }
}