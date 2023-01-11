using LeetCode.Array.Medium.Permutations;
using Xunit;

namespace LeetCodeTests.Array.Medium.Permutations
{
    public class SolutionTests
    {
        [Fact]
        public void Permute_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] {1, 2, 3};

            // Act
            var result = solution.Permute(nums);

            // Assert
            Assert.True(true);
        }
    }
}
