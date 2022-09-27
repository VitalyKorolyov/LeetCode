using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.ShortestPathToGetFood
{
    //https://leetcode.com/problems/shortest-path-to-get-food/
    public class Solution
    {
        private int[][] dirs = new int[][] {
            new[] { 1, 0 },
            new[] { 0, 1 },
            new[] { -1, 0 },
            new[] { 0, -1 } 
        };

        public int GetFood(char[][] grid)
        {
            var queue = InitQueue(grid);

            var visited = new bool[grid.Length, grid[0].Length];

            int step = 0;
            while(queue.Count > 0)
            {
                var size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    var pos = queue.Dequeue();

                    if (grid[pos[0]][pos[1]] == '#') return step;

                    foreach (var dir in dirs)
                    {
                        int newX = pos[0] + dir[0];
                        int newY = pos[1] + dir[1];

                        if (IsValid(grid, newX, newY) && !visited[newX, newY])
                        {
                            visited[newX, newY] = true;
                            queue.Enqueue(new int[] { newX, newY });
                        }
                    }
                }
                step++;
            }

            return -1;
        }

        private Queue<int[]> InitQueue(char[][] grid)
        {
            var queue = new Queue<int[]>();

            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == '*')
                        queue.Enqueue(new int[] { i, j });

            return queue;
        }

        private bool IsValid(char[][] grid, int i, int j)
        {
            return i >= 0 && i < grid.Length && j >= 0 && j < grid[0].Length && grid[i][j] != 'X';
        }
    }
}
