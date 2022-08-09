using LeetCode.DynamicProgramming.Medium.HouseRobber;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Medium.HouseRobber
{
    public class SolutionTests
    {
        [Fact]
        public void Rob_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] {1, 2, 3, 1};

            // Act
            var result = solution.Rob(nums);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
