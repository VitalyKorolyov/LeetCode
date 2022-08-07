using System.Collections.Generic;

namespace LeetCode.Array.Medium._3Sum
{
    //https://leetcode.com/problems/3sum/
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();

            if (nums == null || nums.Length < 3)
                return res;

            System.Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0) break;
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                SearchTriplets(i, i + 1, nums, res);
            }

            return res;
        }

        private void SearchTriplets(int left, int middle, int[] nums, List<IList<int>> res)
        {
            var right = nums.Length - 1;

            while (middle < right)
            {
                var currentSum = nums[right] + nums[left] + nums[middle];

                if (currentSum == 0)
                {
                    res.Add(new List<int> { nums[right], nums[left], nums[middle] });
                    middle++;
                    right--;

                    while (middle < right && nums[middle] == nums[middle - 1])
                        middle++;
                }
                if (currentSum < 0)
                    middle++;
                if(currentSum > 0)
                    right--;
            }
        }
    }
}
