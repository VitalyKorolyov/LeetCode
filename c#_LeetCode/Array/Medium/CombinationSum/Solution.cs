using System.Collections.Generic;

namespace LeetCode.Array.Medium.CombinationSum;

//https://leetcode.com/problems/combination-sum/description/
public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> result = new();

        GenerateCombSum(result, new List<int>(), 0, target, candidates, 0);

        return result;
    }

    private void GenerateCombSum(IList<IList<int>> result, IList<int> temp,
        int currentSum, int targetSum, int[] candidates, int start)
    {
        temp = new List<int>(temp);

        if (currentSum > targetSum) return;
        if (currentSum == targetSum)
        {
            result.Add(temp);
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            temp.Add(candidates[i]);
            GenerateCombSum(result, temp, currentSum + candidates[i], targetSum, candidates, i);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}