namespace LeetCode.Array.Medium.FindPeakElement;

//https://leetcode.com/problems/find-peak-element/
public class Solution
{
    public static int FindPeakElement(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while(left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[mid + 1])
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}