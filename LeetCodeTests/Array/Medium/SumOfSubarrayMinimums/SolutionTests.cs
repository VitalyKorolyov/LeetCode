using LeetCode.Array.Medium.SumOfSubarrayMinimums;
using Xunit;

namespace LeetCodeTests.Array.Medium.SumOfSubarrayMinimums
{
    public class SolutionTests
    {
        [Fact]
        public void SumSubarrayMins_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] arr = { 3, 1, 2, 4 };

            // Act
            var result = solution.SumSubarrayMins(arr);

            // Assert
            Assert.Equal(17, result);
        }
    }
}
