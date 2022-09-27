using LeetCode.Matrix.Medium.ShortestPathToGetFood;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.ShortestPathToGetFood
{
    public class SolutionTests
    {
        [Fact]
        public void GetFood_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            char[][] grid = new char[4][];
            grid[0] = new char[] { 'X', 'X', 'X', 'X', 'X', 'X' };
            grid[1] = new char[] { 'X', '*', 'O', 'O', 'O', 'X' };
            grid[2] = new char[] { 'X', 'O', 'O', '#', 'O', 'X' };
            grid[3] = new char[] { 'X', 'X', 'X', 'X', 'X', 'X' };

            // Act
            var result = solution.GetFood(grid);

            // Assert
            Assert.True(result == 3);
        }
    }
}
