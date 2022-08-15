using LeetCode.Array.Medium.ShortestUnsortedContinuousSubarray;
using Xunit;

namespace LeetCodeTests.Array.Medium.ShortestUnsortedContinuousSubarray
{
    public class SolutionTests
    {
        [Fact]
        public void FindUnsortedSubarray_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { 2, 1 };

            // Act
            var result = solution.FindUnsortedSubarray(nums);

            // Assert
            Assert.True(result == 2);
        }
    }
}
