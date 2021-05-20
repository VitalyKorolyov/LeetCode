using System.Collections.Generic;

namespace LeetCode.Array.Easy.PascalsTriangle
{
    //https://leetcode.com/problems/pascals-triangle/
    public static class Solution
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var resultLIst = new List<IList<int>>(numRows);

            for (int i = 0; i < numRows; i++)
            {
                var prevIndexLayer = i == 0 ? i : i - 1;
                var nextLayerSize = i + 1;
                var nextLayer = new List<int>(nextLayerSize);

                for (int j = 0; j < nextLayerSize; j++)
                {
                    if (j == 0 || j == resultLIst[prevIndexLayer].Count)
                    {
                        nextLayer.Add(1);
                        continue;
                    }

                    nextLayer.Add(resultLIst[prevIndexLayer][j - 1] + resultLIst[prevIndexLayer][j]);
                }

                resultLIst.Add(nextLayer);
            }

            return resultLIst;
        }
    }
}