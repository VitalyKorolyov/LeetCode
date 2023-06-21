using System.Collections.Generic;

namespace LeetCode.Graph.Medium.CourseSchedule;

//https://leetcode.com/problems/course-schedule/
public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> graph = new();
        Dictionary<int, int> referenceCount = new();

        for (int i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
            referenceCount[i] = 0;
        }

        for (int i = 0; i < prerequisites.Length; i++)
        {
            var parent = prerequisites[i][0];
            var child = prerequisites[i][1];

            graph[parent].Add(child);
            referenceCount[child]++;
        }

        Queue<int> queue = new();
        foreach (var count in referenceCount)
        {
            if (count.Value == 0)
                queue.Enqueue(count.Key);
        }

        int visitedNotes = 0;
        while (queue.Count > 0)
        {
            visitedNotes++;
            var current = queue.Dequeue();

            foreach (var child in graph[current])
            {
                referenceCount[child]--;

                if (referenceCount[child] == 0)
                    queue.Enqueue(child);
            }
        }

        return visitedNotes == numCourses;
    }

    //DFS
    public bool CanFinish_dfs(int numCourses, int[][] prerequisites)
    {
        if (prerequisites == null || prerequisites.Length == 0) return true;

        var hashMap = new Dictionary<int, List<int>>();

        for (int i = 0; i < prerequisites.Length; i++)
        {
            if (!hashMap.ContainsKey(prerequisites[i][0]))
                hashMap.Add(prerequisites[i][0], new List<int> { prerequisites[i][1] });
            else
                hashMap[prerequisites[i][0]].Add(prerequisites[i][1]);
        }

        var visited = new HashSet<int>();
        var @checked = new HashSet<int>();

        for (int i = 0; i < numCourses; i++)
        {
            if (@checked.Contains(i)) continue;
            if (IsCycle(i, hashMap, visited, @checked)) return false;
        }

        return true;
    }

    private bool IsCycle(int current, Dictionary<int, List<int>> hashMap,
        HashSet<int> visited, HashSet<int> @checked)
    {
        if (visited.Contains(current)) return true;

        if (!@checked.Contains(current)) @checked.Add(current);
        else return false;

        visited.Add(current);

        var res = false;
        if (hashMap.ContainsKey(current))
        {
            foreach (var course in hashMap[current])
            {
                if (IsCycle(course, hashMap, visited, @checked))
                {
                    res = true;
                    break;
                }
            }
        }

        visited.Remove(current);
        return res;
    }
}