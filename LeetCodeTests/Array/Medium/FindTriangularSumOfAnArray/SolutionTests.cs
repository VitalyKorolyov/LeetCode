using LeetCode.Array.Medium.FindTriangularSumOfAnArray;
using Xunit;

namespace LeetCodeTests.Array.Medium.FindTriangularSumOfAnArray
{
    public class SolutionTests
    {
        [Fact]
        public void TriangularSum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            // Act
            var result = solution.TriangularSum(nums);

            // Assert
            Assert.True(result == 8);
        }
    }
}
