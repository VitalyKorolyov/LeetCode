using System.Collections.Generic;

namespace LeetCode.Matrix.Medium._01Matrix;

//https://leetcode.com/problems/01-matrix/description/
public class Solution
{
    private static int[][] directions = new int[][] 
    {
        new [] { 0, 1 },
        new [] { 1, 0 },
        new [] { 0, -1 },
        new [] { -1, 0 } 
    };

    public int[][] UpdateMatrix(int[][] mat)
    {
        Queue<(int, int)> queue = new();

        int[][] distanceMatrix = (int[][])mat.Clone();

        HashSet<(int, int)> visited = new();
        for (int i = 0; i < distanceMatrix.Length; i++)
        {
            for (int j = 0; j < distanceMatrix[i].Length; j++)
            {
                if (distanceMatrix[i][j] == 0)
                {
                    var cell = (i, j);
                    queue.Enqueue(cell);
                    visited.Add(cell);
                }
            }
        }

        int distance = -1;

        while (queue.Count > 0)
        {
            distance++;
            var size = queue.Count;

            while (size > 0)
            {
                (int i, int j) = queue.Dequeue();

                if (distanceMatrix[i][j] == 1)
                    distanceMatrix[i][j] = distance;

                foreach (var direction in directions)
                {
                    var x = direction[0] + i;
                    var y = direction[1] + j;
                    var currentCell = (x, y);

                    if (x < 0 || y < 0) continue;
                    if(x > distanceMatrix.Length - 1 || y > distanceMatrix[x].Length - 1) continue;
                    if(visited.Contains(currentCell)) continue;

                    queue.Enqueue(currentCell);
                    visited.Add(currentCell);
                }

                size--;
            }
        }

        return distanceMatrix;
    }
}
