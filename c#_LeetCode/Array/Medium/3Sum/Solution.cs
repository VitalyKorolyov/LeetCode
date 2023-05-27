using System.Collections.Generic;

namespace LeetCode.Array.Medium._3Sum;

//https://leetcode.com/problems/3sum/
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        System.Array.Sort(nums);

        List<IList<int>> res = new();

        for (int i = 0; i < nums.Length && nums[i] <= 0; ++i)
        {
            if (i == 0 || nums[i - 1] != nums[i])
                Sum(nums, i, res);
        }

        return res;
    }

    private void Sum(int[] nums, int i, List<IList<int>> result)
    {
        int left = i + 1, right = nums.Length - 1;

        while (left < right)
        {
            int sum = nums[i] + nums[left] + nums[right];

            if (sum < 0) ++left;
            else if (sum > 0) --right;
            else
            {
                result.Add(new List<int> { nums[i], nums[left++], nums[right--] });

                while (left < right && nums[left] == nums[left - 1])
                    ++left;
            }
        }
    }
}