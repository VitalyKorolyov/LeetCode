using LeetCode.Array.Easy.MaximumUnitsOnATruck;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.MaximumUnitsOnATruck
{
    public class SolutionTests
    {
        [Fact]
        public void MaximumUnits_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] boxTypes = new[] {new[] {1, 3}, new Int32[] {2, 2}, new Int32[] {3, 1}};
            int truckSize = 4;

            // Act
            var result = solution.MaximumUnits(
                boxTypes,
                truckSize);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
