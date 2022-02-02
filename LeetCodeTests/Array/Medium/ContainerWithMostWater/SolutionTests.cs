using LeetCode.Array.Medium.ContainerWithMostWater;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.ContainerWithMostWater
{
    public class SolutionTests
    {
        [Fact]
        public void MaxArea_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7};

            // Act
            var result = solution.MaxArea(
                height);

            // Assert
            Assert.Equal(49, result);
        }
    }
}
