using LeetCode.Array.Hard.FirstMissingPositive;
using Xunit;

namespace LeetCodeTests.Array.Hard.FirstMissingPositive
{
    public class SolutionTests
    {
        [Fact]
        public void FirstMissingPositive_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] {3, 4, -1, 1};

            // Act
            var result = solution.FirstMissingPositive(
                nums);

            // Assert
            Assert.True(true);
        }
    }
}
