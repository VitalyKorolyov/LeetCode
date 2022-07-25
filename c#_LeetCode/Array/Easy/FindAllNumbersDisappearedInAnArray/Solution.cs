using System;
using System.Collections.Generic;

namespace LeetCode.Array.Easy.FindAllNumbersDisappearedInAnArray
{
    //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var res = new List<int>();

            int i = 0;

            while (i < nums.Length)
            {
                if (nums[i] != nums[nums[i] - 1])
                    Swap(nums, i, nums[i] - 1);
                else
                    i++;
            }

            for (int k = 0; k < nums.Length; k++)
            {
                if (k + 1 != nums[k]) res.Add(k + 1);
            }

            return res;
        }

        private void Swap(int[] nums, int i, int j)
        {
            var saved = nums[i];
            nums[i] = nums[j];
            nums[j] = saved;
        }
    }
}
