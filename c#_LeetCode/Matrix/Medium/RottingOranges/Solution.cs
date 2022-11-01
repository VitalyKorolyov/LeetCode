using System;
using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.RottingOranges
{
    //https://leetcode.com/problems/rotting-oranges/
    public class Solution
    {
        private int[][] directions = new int[][]
        {
            new int[]{1, 0}, new int[]{-1, 0}, new int[]{0, 1}, new int[]{0, -1}
        };

        public int OrangesRotting(int[][] grid)
        {
            Queue<Tuple<int, int>> queue = new();
            int freshOranges = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] == 1)
                        freshOranges++;
                    if (grid[i][j] == 2)
                        queue.Enqueue(Tuple.Create(i, j));
                }
            }

            if (queue.Count == 0 && freshOranges > 0) return -1;
            if (queue.Count == 0 && freshOranges == 0) return 0;

            Dictionary<int, HashSet<int>> visited = new();
            var time = 0;

            while (queue.Count > 0)
            {
                time += 1;

                var node = queue.Dequeue();
                AddVisited(visited, node.Item1, node.Item2);

                for (int j = 0; j < directions.Length; j++)
                {
                    var newX = directions[j][0] + node.Item1;
                    var newY = directions[j][1] + node.Item2;

                    if (newX >= 0 && newX < grid.Length && newY >= 0 && newY < grid[newX].Length &&
                        grid[newX][newY] == 1 && !IsVisited(visited, newX, newY))
                    {
                        freshOranges--;
                        AddVisited(visited, newX, newY);
                        queue.Enqueue(Tuple.Create(newX, newY));
                    }
                }
            }

            return freshOranges == 0 ? time - 1 : -1;
        }

        private bool IsVisited(Dictionary<int, HashSet<int>> visited, int i, int j)
        {
            return visited.ContainsKey(i) && visited[i].Contains(j);
        }

        private void AddVisited(Dictionary<int, HashSet<int>> visited, int i, int j)
        {
            if(!visited.ContainsKey(i))
                visited.Add(i, new HashSet<int>());

            visited[i].Add(j);
        }
    }
}
