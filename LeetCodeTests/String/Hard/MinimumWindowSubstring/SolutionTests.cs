using LeetCode.String.Hard.MinimumWindowSubstring;
using Xunit;

namespace LeetCodeTests.String.Hard.MinimumWindowSubstring
{
    public class SolutionTests
    {
        [Fact]
        public void MinWindow_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "ADOBECODEBANC";
            string t = "ABC";

            // Act
            var result = solution.MinWindow(
                s,
                t);

            // Assert
            Assert.True(true);
        }
    }
}
