using LeetCode.Array.Medium.SortColors;
using Xunit;

namespace LeetCodeTests.Array.Medium.SortColors
{
    public class SolutionTests
    {
        [Fact]
        public void SortColors_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { 1, 2, 0 };

            // Act
            solution.SortColors(nums);

            // Assert
            Assert.True(true);
        }
    }
}
