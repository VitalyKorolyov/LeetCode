namespace LeetCode.Array.Hard.FindKthSmallestPairDistance;

//https://leetcode.com/problems/find-k-th-smallest-pair-distance/description/
public class Solution
{
    public int SmallestDistancePair(int[] nums, int k)
    {
        System.Array.Sort(nums);

        int left = 0;
        int right = nums[nums.Length - 1] - nums[0];

        while(left < right)
        {
            int mid = left + (right - left) / 2;

            if (Enough(mid, k, nums))
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }

    private bool Enough(int distance, int k, int[] nums)
    {
        int count = 0, i = 0, j = 0;

        while (i < nums.Length || j < nums.Length)
        {
            while (j < nums.Length && nums[j] - nums[i] <= distance)
                j += 1;

            count += j - i - 1;
            i += 1;
        }

        return count >= k;
    }
}