using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Graph.Medium.CourseScheduleII
{
    //https://leetcode.com/problems/course-schedule-ii/description/
    public class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> graph = new();

            for (int i = 0; i < prerequisites.Length; i++)
            {
                if (graph.ContainsKey(prerequisites[i][0]))
                    graph[prerequisites[i][0]].Add(prerequisites[i][1]);
                else graph.Add(prerequisites[i][0], new List<int> { prerequisites[i][1] });
            }

            HashSet<int> visited = new();
            HashSet<int> @check = new();
            List<int> topologicalResult = new();
            for (int i = 0; i < numCourses; i++)
            {
                var res = IsCycle(i, graph, visited, @check, topologicalResult);
                if (res) return new int[0];
            }

            return topologicalResult.ToArray();
        }

        private bool IsCycle(int current, Dictionary<int, List<int>> graph,
            HashSet<int> visited, HashSet<int> @checked, List<int> topologicalRes)
        {
            if (@checked.Contains(current)) return true;
            if (visited.Contains(current)) return false;

            visited.Add(current);
            @checked.Add(current);

            if(graph.ContainsKey(current))
            {
                foreach (var item in graph[current])
                {
                    var res = IsCycle(item, graph, visited, @checked, topologicalRes);
                    if (res) return true;
                }
            }

            topologicalRes.Add(current);
            @checked.Remove(current);
            return false;
        }
    }
}
