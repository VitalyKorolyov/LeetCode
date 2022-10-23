using LeetCode.DynamicProgramming.Medium.HouseRobberII;
using System;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Medium.HouseRobberII
{
    public class SolutionTests
    {
        [Fact]
        public void Rob_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] {2, 3, 2 };

            // Act
            var result = solution.Rob(
                nums);

            // Assert
            Assert.True(result == 3);
        }
    }
}
