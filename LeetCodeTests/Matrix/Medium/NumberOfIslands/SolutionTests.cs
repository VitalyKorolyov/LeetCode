using LeetCode.Matrix.Medium.NumberOfIslands;
using System;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.NumberOfIslands
{
    public class SolutionTests
    {
        [Fact]
        public void NumIslands_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            char[][] grid = new char[4][];
            grid[0] = new char[] { '1','1','1','1','0' };
            grid[1] = new char[] { '1', '1', '0', '1', '0' };
            grid[2] = new char[] { '1', '1', '0', '0', '0' };
            grid[3] = new char[] { '0', '0', '0', '0', '0' };

            // Act
            var result = solution.NumIslands(
                grid);

            // Assert
            Assert.True(result == 1);
        }
    }
}
