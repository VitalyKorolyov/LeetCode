namespace LeetCode.Array.Medium.PeakIndexInAMountainArray;

//https://leetcode.com/problems/peak-index-in-a-mountain-array/description/
public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid - 1] > arr[mid])
                right = mid;
            else
                left = mid + 1;
        }

        return left - 1;
    }
}