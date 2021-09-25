using LeetCode.String.Easy.MaximumNestingDepthOfTheParentheses;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.MaximumNestingDepthOfTheParentheses
{
    public class SolutionTests
    {
        [Fact]
        public void MaxDepth_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "(1)+((2))+(((3)))";

            // Act
            var result = solution.MaxDepth(
                s);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
