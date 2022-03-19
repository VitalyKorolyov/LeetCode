using LeetCode.Array.Medium.MinimumSwapstoGroupAll1_sTogether;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.MinimumSwapstoGroupAll1
{
    public class SolutionTests
    {
        [Fact]
        public void MinSwaps_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] data = { 1,0,0,1,1,1 };

            // Act
            var result = solution.MinSwaps(
                data);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
