using LeetCode.Array.Medium.MinimumAdjacentSwapsToMakeAValidArray;
using Xunit;

namespace LeetCodeTests.Array.Medium.MinimumAdjacentSwapsToMakeAValidArray
{
    public class SolutionTests
    {
        [Fact]
        public void MinimumSwaps_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] {3, 4, 5, 5, 3, 1};

            // Act
            var result = solution.MinimumSwaps(nums);

            // Assert
            Assert.True(result == 6);
        }
    }
}
