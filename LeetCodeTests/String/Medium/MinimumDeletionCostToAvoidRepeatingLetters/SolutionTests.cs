using LeetCode.String.Medium.MinimumDeletionCostToAvoidRepeatingLetters;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.MinimumDeletionCostToAvoidRepeatingLetters
{
    public class SolutionTests
    {
        [Fact]
        public void MinCost_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "aaabbbabbbb";
            int[] cost = { 3, 5, 10, 7, 5, 3, 5, 5, 4, 8, 1 };

            // Act
            var result = solution.MinCost(
                s,
                cost);

            // Assert
            Assert.Equal(26, result);
        }
    }
}
