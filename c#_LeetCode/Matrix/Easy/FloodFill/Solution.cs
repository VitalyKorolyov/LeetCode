using System.Collections.Generic;

namespace LeetCode.Matrix.Easy.FloodFill;

//https://leetcode.com/problems/flood-fill/description/
public class Solution
{
    private int[][] directions = new int[4][]
    {
        new int[]{ -1, 0 },
        new int[]{ 0, -1 },
        new int[]{ 1, 0 },
        new int[]{ 0, 1 }
    };

    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int[][] newImage = (int[][])image.Clone();
        if (image[sr][sc] == color) return newImage;

        int origin = image[sr][sc];
        Queue<(int i, int j)> queue = new();
        HashSet<(int i, int j)> visited = new();

        visited.Add((sr, sc));
        queue.Enqueue((sr, sc));

        while (queue.Count > 0)
        {
            (int i, int j) = queue.Dequeue();
            newImage[i][j] = color;

            foreach (var item in directions)
            {
                var newI = item[0] + i;
                var newJ = item[1] + j;

                var cellToVisite = (newI, newJ);

                if (newI < 0 || newI >= newImage.Length) continue;
                if (newJ < 0 || newJ >= newImage[0].Length) continue;
                if (newImage[newI][newJ] != origin) continue;
                if (visited.Contains(cellToVisite)) continue;

                visited.Add(cellToVisite);
                queue.Enqueue(cellToVisite);
            }
        }

        return newImage;
    }


    //DFS
    public int[][] FloodFillDfs(int[][] image, int sr, int sc, int color)
    {
        int[][] newImage = (int[][])image.Clone();
        if (image[sr][sc] == color) return newImage;

        Dfs(newImage, sr, sc, newImage[sr][sc], color);

        return newImage;
    }

    private void Dfs(int[][] image, int i, int j, int originColor, int newColor)
    {
        if (i < 0 || i >= image.Length) return;
        if (j < 0 || j >= image[0].Length) return;
        if (originColor != image[i][j]) return;

        image[i][j] = newColor;

        Dfs(image, i + 1, j, originColor, newColor);
        Dfs(image, i, j + 1, originColor, newColor);
        Dfs(image, i - 1, j, originColor, newColor);
        Dfs(image, i, j - 1, originColor, newColor);
    }
}