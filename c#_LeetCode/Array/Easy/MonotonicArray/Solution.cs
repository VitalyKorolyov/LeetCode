namespace LeetCode.Array.Easy.MonotonicArray;

//https://leetcode.com/problems/monotonic-array/description/
public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        bool isInc = true, isDec = true;

        for (int i = 1; i < nums.Length; i++)
        {
            isInc = nums[i] >= nums[i - 1] && isInc;
            isDec = nums[i] <= nums[i - 1] && isDec;
        }

        return isInc || isDec;
    }
}