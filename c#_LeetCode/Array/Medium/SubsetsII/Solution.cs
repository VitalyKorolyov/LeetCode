using System.Collections.Generic;

namespace LeetCode.Array.Medium.SubsetsII
{
    //https://leetcode.com/problems/subsets-ii/description/
    public class Solution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> result = new();

            System.Array.Sort(nums);
            BuildSubSets(result, new List<int>(), nums, 0);

            return result;
        }

        private void BuildSubSets(IList<IList<int>> res, IList<int> temp, int[] nums, int start)
        {
            res.Add(new List<int>(temp));

            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1]) continue;

                temp.Add(nums[i]);
                BuildSubSets(res, temp, nums, i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
