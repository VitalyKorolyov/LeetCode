using System.Collections.Generic;

namespace LeetCode.Array.Medium.Subsets
{
    //https://leetcode.com/problems/subsets/
    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> list = new();

            Backtrack(list, new List<int>(), nums, 0);

            return list;
        }

        private void Backtrack(IList<IList<int>> list, IList<int> tempList, int[] nums, int start)
        {
            list.Add(new List<int>(tempList));
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                Backtrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }

        //public IList<IList<int>> Subsets(int[] nums)
        //{
        //    List<IList<int>> result = new() { new List<int>() };

        //    foreach (int currentNumber in nums)
        //    {
        //        int n = result.Count;

        //        for (int i = 0; i < n; i++)
        //        {
        //            List<int> set = new(result[i]);
        //            set.Add(currentNumber);
        //            result.Add(set);
        //        }
        //    }

        //    return result;
        //}
    }
}
