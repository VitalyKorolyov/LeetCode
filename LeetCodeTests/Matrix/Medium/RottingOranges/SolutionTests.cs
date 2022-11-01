using LeetCode.Matrix.Medium.RottingOranges;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.RottingOranges
{
    public class SolutionTests
    {
        [Fact]
        public void OrangesRotting_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] grid = new int[3][];
            grid[0] = new int[] { 2, 1, 1 };
            grid[1] = new int[] { 1, 1, 0 };
            grid[2] = new int[] { 0, 1, 1 };

            // Act
            var result = solution.OrangesRotting(
                grid);

            // Assert
            Assert.True(result == 4);
        }
    }
}
