using LeetCode.Array.Easy.MinCostClimbingStairs;
using Xunit;

namespace LeetCodeTests.Array.Easy.MinCostClimbingStairs
{
    public class SolutionTests
    {
        [Fact]
        public void MinCostClimbingStairs_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] cost = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };

            // Act
            var result = solution.MinCostClimbingStairs(cost);

            // Assert
            Assert.Equal(15, result);
        }
    }
}
