namespace LeetCode.Math.Easy.NumberOf1Bits;

//https://leetcode.com/problems/number-of-1-bits/
public class Solution
{
    public int HammingWeight(uint n)
    {
        int oneCount = 0;

        while(n != 0)
        {
            if(n % 2 == 1)
                oneCount++;

            n /= 2;
        }

        return oneCount;
    }
}
