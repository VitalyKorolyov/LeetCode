using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.LeftmostColumnWithAtLeastAOne;

// This is BinaryMatrix's API interface.
// You should not implement it, or speculate about its implementation
class BinaryMatrix
{
    public int Get(int row, int col) { return 1; }
    public IList<int> Dimensions() { return new List<int>(); }
}

//https://leetcode.com/problems/leftmost-column-with-at-least-a-one/description/
class Solution
{
    public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
    {
        int columnResult = -1;

        var demensions = binaryMatrix.Dimensions();
        var rows = demensions[0];
        var columns = demensions[1];

        int currentColumn = columns - 1;
        int currentRow = 0;

        while(currentColumn >= 0 && currentRow < rows)
        {
            var value = binaryMatrix.Get(currentRow, currentColumn);

            if (value == 1)
            {
                columnResult = currentColumn;
                currentColumn--;
            }
            else
                currentRow++;
        }


        return columnResult;
    }
}