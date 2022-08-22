namespace LeetCode.Math.Easy.CountOddNumbersInAnIntervalRange
{
    //https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
    public class Solution
    {
        public int CountOdds(int low, int high)
        {
            return low % 2 == 0 && high % 2 == 0
                ? (high - low) / 2
                : (high - low) / 2 + 1;
        }
    }
}
