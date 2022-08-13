using LeetCode.Array.Medium._3SumSmaller;
using Xunit;

namespace LeetCodeTests.Array.Medium.SumSmaller
{
    public class SolutionTests
    {
        [Fact]
        public void ThreeSumSmaller_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { -2, 0, 1, 3 };
            int target = 2;

            // Act
            var result = solution.ThreeSumSmaller(
                nums,
                target);

            // Assert
            Assert.True(result == 2);
        }
    }
}
