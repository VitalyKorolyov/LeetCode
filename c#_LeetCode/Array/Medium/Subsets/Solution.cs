using System.Collections.Generic;

namespace LeetCode.Array.Medium.Subsets
{
    //https://leetcode.com/problems/subsets/
    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> result = new() { new List<int>() };

            foreach (int currentNumber in nums)
            {
                int n = result.Count;

                for (int i = 0; i < n; i++)
                {
                    List<int> set = new(result[i]);
                    set.Add(currentNumber);
                    result.Add(set);
                }
            }

            return result;
        }
    }
}
