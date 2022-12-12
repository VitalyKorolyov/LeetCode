using LeetCode.Array.Medium.JumpGame;
using Xunit;

namespace LeetCodeTests.Array.Medium.JumpGame
{
    public class SolutionTests
    {
        [Fact]
        public void CanJump_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { 2, 5, 0, 0 };

            // Act
            var result = solution.CanJump(nums);

            // Assert
            Assert.True(result);
        }
    }
}
