using System.Collections.Generic;

namespace LeetCode.Graph.Medium.PacificAtlanticWaterFlow
{
    //https://leetcode.com/problems/pacific-atlantic-water-flow/description/
    public class Solution
    {
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            var pacificOcean =  new bool[heights.Length, heights[0].Length];
            var atlanticOcean = new bool[heights.Length, heights[0].Length];

            for (int i = 0; i < heights.Length; i++)
                Dfs(heights, pacificOcean, i, 0, heights[i][0]);

            for (int i = 0; i < heights[0].Length; i++)
                Dfs(heights, pacificOcean, 0, i, heights[0][i]);

            for (int i = heights.Length - 1; i >= 0; i--)
                Dfs(heights, atlanticOcean, i, heights[0].Length - 1, heights[i][heights[0].Length - 1]);

            for (int i = heights[0].Length - 1; i >= 0; i--)
                Dfs(heights, atlanticOcean, heights.Length - 1, i, heights[heights.Length - 1][i]);

            List<IList<int>> result = new();
            for (int i = 0; i < heights.Length; i++)
                for (int j = 0; j < heights[0].Length; j++)
                    if (atlanticOcean[i, j] && atlanticOcean[i, j] == pacificOcean[i, j])
                        result.Add(new List<int> { i, j });

            return result;
        }

        private void Dfs(int[][] heights, bool[,] ocean, int i, int j, int height)
        {
            if(i < 0 || j < 0 || i >= heights.Length || j >= heights[0].Length || ocean[i,j]) return;

            var newHeight = heights[i][j];

            if (height > newHeight) return;

            ocean[i, j] = true;

            Dfs(heights, ocean, i + 1, j, newHeight);
            Dfs(heights, ocean, i, j + 1, newHeight);
            Dfs(heights, ocean, i - 1, j, newHeight);
            Dfs(heights, ocean, i, j - 1, newHeight);
        }
    }
}
