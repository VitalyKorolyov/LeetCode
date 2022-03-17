using System.Collections.Generic;

namespace LeetCode.Array.Medium.NestedListWeightSum
{
    //https://leetcode.com/problems/nested-list-weight-sum/
    public interface NestedInteger
    {
        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // Set this NestedInteger to hold a single integer.
        public void SetInteger(int value);

        // Set this NestedInteger to hold a nested list and adds a nested integer to it.
        public void Add(NestedInteger ni);

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

    public class Solution
    {
        public int DepthSum(IList<NestedInteger> nestedList)
        {
            return Dfs(nestedList, 1);
        }

        private int Dfs(IList<NestedInteger> nestedList, int depth)
        {
            var result = 0;

            foreach (var nested in nestedList)
            {
                if (nested.IsInteger())
                {
                    result += nested.GetInteger() * depth;
                }
                else
                {
                    result += Dfs(nested.GetList(), depth + 1);
                }
            }

            return result;
        }
    }
}
