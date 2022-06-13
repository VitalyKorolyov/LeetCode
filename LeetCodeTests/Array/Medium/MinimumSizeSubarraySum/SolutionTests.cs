using LeetCode.Array.Medium.MinimumSizeSubarraySum;
using Xunit;

namespace LeetCodeTests.Array.Medium.MinimumSizeSubarraySum
{
    public class SolutionTests
    {
        [Fact]
        public void MinSubArrayLen_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int target = 4;
            int[] nums = new int[] { 1, 4, 4 };

            // Act
            var result = solution.MinSubArrayLen(target, nums);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
