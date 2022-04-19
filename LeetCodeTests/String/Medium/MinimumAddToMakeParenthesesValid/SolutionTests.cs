using LeetCode.String.Medium.MinimumAddToMakeParenthesesValid;
using Xunit;

namespace LeetCodeTests.String.Medium.MinimumAddToMakeParenthesesValid
{
    public class SolutionTests
    {
        [Fact]
        public void MinAddToMakeValid_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "()))((";

            // Act
            var result = solution.MinAddToMakeValid(
                s);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
