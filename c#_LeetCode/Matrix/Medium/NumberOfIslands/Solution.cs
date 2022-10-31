using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Matrix.Medium.NumberOfIslands
{
    //https://leetcode.com/problems/number-of-islands/
    public class Solution
    {
        private int[][] directions = new int[][] {
            new int[]{ 1, 0 }, new int[]{ -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };

        public int NumIslands(char[][] grid)
        {
            var number = 0;

            if (grid == null || !grid.Any()) return number;

            Dictionary<int, HashSet<int>> visited = new();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1' && !IsVisited(visited, i, j))
                    {
                        Queue<Tuple<int, int>> queue = new();
                        queue.Enqueue(Tuple.Create(i, j));

                        Bfs(grid, queue, visited);
                        number++;
                    }
                }
            }

            return number;
        }

        private void Bfs(char[][] grid, Queue<Tuple<int, int>> queue, 
            Dictionary<int, HashSet<int>> visited)
        {
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                MakrVisited(visited, node.Item1, node.Item2);

                for (int i = 0; i < directions.Length; i++)
                {
                    var newX = node.Item1 + directions[i][0];
                    var newY = node.Item2 + directions[i][1];

                    if (newX >= 0 && grid.Length > newX
                        && grid[newX].Length > newY && newY >= 0
                        && !IsVisited(visited, newX, newY) && grid[newX][newY] == '1')
                    {
                        queue.Enqueue(Tuple.Create(newX, newY));
                    }
                }
            }
        }

        private bool IsVisited(Dictionary<int, HashSet<int>> visited, int i, int j)
        {
            return visited.ContainsKey(i) && visited[i].Contains(j);
        }

        private void MakrVisited(Dictionary<int, HashSet<int>> visited, int i, int j)
        {
            if(!visited.ContainsKey(i))
                visited.Add(i, new HashSet<int>());

            visited[i].Add(j);
        }


        //public int NumIslands(char[][] grid)
        //{
        //    var number = 0;

        //    if (grid == null || !grid.Any()) return number;

        //    for (int i = 0; i < grid.Length; i++)
        //    {
        //        for (int j = 0; j < grid[0].Length; j++)
        //        {
        //            if (grid[i][j] == '1')
        //            {
        //                number++;
        //                Search(grid, i, j);
        //            }
        //        }
        //    }

        //    return number;
        //}

        //private void Search(char[][] grid, int i, int j)
        //{
        //    if(i < 0 || j < 0 || grid.Length <= i || grid[0].Length <= j || grid[i][j] == '0') return;

        //    grid[i][j] = '0';

        //    Search(grid, i + 1, j);
        //    Search(grid, i - 1, j);
        //    Search(grid, i, j + 1);
        //    Search(grid, i, j - 1);
        //}
    }
}