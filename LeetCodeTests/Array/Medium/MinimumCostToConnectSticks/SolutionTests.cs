using LeetCode.Array.Medium.MinimumCostToConnectSticks;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.MinimumCostToConnectSticks
{
    public class SolutionTests
    {
        [Fact]
        public void ConnectSticks_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] sticks = {3, 7, 1, 10, 8};

            // Act
            var result = solution.ConnectSticks(
                sticks);

            // Assert
            Assert.Equal(62, result);
        }
    }
}
