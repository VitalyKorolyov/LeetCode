using LeetCode.DynamicProgramming.Hard;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Hard
{
    public class SolutionTests
    {
        [Fact]
        public void Trap_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] height = new int[] {4, 2, 0, 3, 2, 5};

            // Act
            var result = solution.Trap(height);

            // Assert
            Assert.Equal(9, result);
        }
    }
}
