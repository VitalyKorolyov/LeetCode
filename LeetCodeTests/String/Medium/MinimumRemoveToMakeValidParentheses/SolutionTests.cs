using LeetCode.String.Medium.MinimumRemoveToMakeValidParentheses;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.MinimumRemoveToMakeValidParentheses
{
    public class SolutionTests
    {
        [Fact]
        public void MinRemoveToMakeValid_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "(a(b(c)d)";

            // Act
            var result = solution.MinRemoveToMakeValid(
                s);

            // Assert
            Assert.Equal("a(b(c)d)", result);
        }
    }
}
