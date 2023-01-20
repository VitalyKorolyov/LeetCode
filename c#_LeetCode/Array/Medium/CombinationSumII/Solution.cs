using System.Collections.Generic;

namespace LeetCode.Array.Medium.CombinationSumII;

//https://leetcode.com/problems/combination-sum-ii/description/
public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        List<IList<int>> result = new();

        System.Array.Sort(candidates);
        GenerateComp(result, candidates, new List<int>(), 0, target, 0);

        return result;
    }

    private void GenerateComp(IList<IList<int>> result, int[] candidates,
        IList<int> temp, int currentSum, int target, int startIndex)
    {
        temp = new List<int>(temp);

        if (currentSum > target) return;
        if (currentSum == target)
        {
            result.Add(temp);
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++)
        {
            if (i > startIndex && candidates[i] == candidates[i-1]) continue;

            temp.Add(candidates[i]);
            GenerateComp(result, candidates, temp, currentSum + candidates[i], target, i + 1);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}
