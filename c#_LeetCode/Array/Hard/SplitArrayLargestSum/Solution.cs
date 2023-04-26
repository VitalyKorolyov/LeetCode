using System.Linq;

namespace LeetCode.Array.Hard.SplitArrayLargestSum;

//https://leetcode.com/problems/split-array-largest-sum/description/
public class Solution
{
    public int SplitArray(int[] nums, int k)
    {
        int left = nums.Max();
        int right = nums.Sum();

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (Feasible(mid, nums, k))
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }

    private bool Feasible(int threshold, int[] nums, int k)
    {
        int count = 1;
        int total = 0;

        foreach (int num in nums)
        {
            total += num;
            if (total > threshold)
            {
                total = num;
                count++;
                if (count > k) return false;
            }
        }

        return true;
    }
}