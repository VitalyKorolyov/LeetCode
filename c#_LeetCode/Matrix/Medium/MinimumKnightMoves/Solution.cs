using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.MinimumKnightMoves;

//https://leetcode.com/problems/minimum-knight-moves/description/
public class Solution
{
    private static readonly int[][] directions = new[]
    {
        new int[] { 2,1 },
        new int[] { 2,-1 },
        new int[] { 1,2 },
        new int[] { -1,2 },
        new int[] { -2,1 },
        new int[] { -2,-1 },
        new int[] { 1,-2 },
        new int[] { -1,-2 }
    };

    public int MinKnightMoves(int x, int y)
    {
        x = System.Math.Abs(x);
        y = System.Math.Abs(y);

        Queue<(int, int)> queue = new();
        queue.Enqueue((0, 0));
        int step = -1;
        Dictionary<int, HashSet<int>> visited = new();

        while (queue.Count > 0)
        {
            var size = queue.Count;
            step++;

            for (int i = 0; i < size; i++)
            {
                var (currentX, currentY) = queue.Dequeue();

                if (currentX == x && currentY == y) return step;

                for (int k = 0; k < directions.Length; k++)
                {
                    var newX = directions[k][0] + currentX;
                    var newY = directions[k][1] + currentY;

                    if (!IsVisited(newX, newY, visited) && newX >= -1 && newY >= -1)
                    {
                        MarkVisited(newX, newY, visited);
                        queue.Enqueue((newX, newY));
                    }
                }
            }
        }

        return -1;
    }

    private void MarkVisited(int x, int y, Dictionary<int, HashSet<int>> visited)
    {
        if(!visited.ContainsKey(x)) visited.Add(x, new HashSet<int> { y });
        else visited[x].Add(y);
    }

    private bool IsVisited(int x, int y, Dictionary<int, HashSet<int>> visited)
    {
        if (visited.ContainsKey(x) && visited[x].Contains(y)) return true;

        return false;
    }
}