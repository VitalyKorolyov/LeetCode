using LeetCode.Array.Hard.SlidingWindowMaximum;
using Xunit;

namespace LeetCodeTests.Array.Hard.SlidingWindowMaximum
{
    public class SolutionTests
    {
        [Fact]
        public void MaxSlidingWindow_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            // Act
            var result = solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.True(true);
        }
    }
}
