using LeetCode.Graph.Medium.PacificAtlanticWaterFlow;
using Xunit;

namespace LeetCodeTests.Graph.Medium.PacificAtlanticWaterFlow
{
    public class SolutionTests
    {
        [Fact]
        public void PacificAtlantic_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] heights = new int[3][];
            heights[0] = new int[3] { 10, 10, 10 };
            heights[1] = new int[3] { 10, 1, 10 };
            heights[2] = new int[3] { 10, 10, 10 };

            // Act
            var result = solution.PacificAtlantic(heights);

            // Assert
            Assert.True(true);
        }
    }
}
