using System.Collections.Generic;

namespace LeetCode.Graph.Medium.ParallelCourses;

//https://leetcode.com/problems/parallel-courses/description/
public class Solution
{
    public int MinimumSemesters(int n, int[][] relations)
    {
        Dictionary<int, List<int>> graph = new();
        Dictionary<int, int> parentCount = new();

        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<int>();
            parentCount[i] = 0;
        }

        for (int i = 0; i < relations.Length; i++) 
        {
            var parent = relations[i][0];
            var child = relations[i][1];

            graph[parent].Add(child);
            parentCount[child]++;
        }

        Queue<int> queue = new();
        foreach(var count in parentCount)
        {
            if(count.Value == 0)
                queue.Enqueue(count.Key);
        }

        int courseCount = 0;
        int semesters = 0;

        while(queue.Count > 0)
        {
            var size = queue.Count;
            semesters++;

            for (var i = 0; i < size; i++)
            {
                var current = queue.Dequeue();
                courseCount++;

                foreach (var child in graph[current])
                {
                    parentCount[child]--;

                    if (parentCount[child] == 0)
                        queue.Enqueue(child);
                }
            }
        }

        return courseCount == n ? semesters : -1;
    }
}