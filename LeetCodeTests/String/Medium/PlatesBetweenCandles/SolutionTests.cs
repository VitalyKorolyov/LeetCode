using LeetCode.String.Medium.PlatesBetweenCandles;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.PlatesBetweenCandles
{
    public class SolutionTests
    {
        [Fact]
        public void PlatesBetweenCandles_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "**|**|***|";
            int[][] queries = new int[2][];
            queries[0] = new int[] {2, 5};
            queries[1] = new int[] { 5, 9 };

            // Act
            var result = solution.PlatesBetweenCandles(s, queries);

            // Assert
            Assert.True(true);
        }
    }
}
