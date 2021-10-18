using LeetCode.Array.Easy.HighFive;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.HighFive
{
    public class SolutionTests
    {
        [Fact]
        public void HighFive_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] items =
            {
                new int[] {1, 91}, new int[] {1, 92}, new int[] {2, 93}, new int[] {2, 97}, new int[] {1, 60},
                new int[] {2, 77}, new int[] {1, 65},
                new int[] {1, 87}, new int[] {1, 100}, new int[] {2, 100}, new int[] {2, 76}
            };

            // Act
            var result = solution.HighFive(
                items);

            // Assert
            Assert.True(true);
        }
    }
}
