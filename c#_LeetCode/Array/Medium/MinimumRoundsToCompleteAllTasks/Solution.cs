using System.Collections.Generic;

namespace LeetCode.Array.Medium.MinimumRoundsToCompleteAllTasks;

//https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/description/
public class Solution
{
    public int MinimumRounds(int[] tasks)
    {
        Dictionary<int, int> taskToCount = new();

        for (int i = 0; i < tasks.Length; i++)
            taskToCount[tasks[i]] = taskToCount.GetValueOrDefault(tasks[i], 0) + 1;

        int result = 0;
        foreach (int count in taskToCount.Values)
        {
            if (count == 1) return -1;

            if (count % 3 == 0) result += count / 3;
            else result += count / 3 + 1;
        }

        return result;
    }
}