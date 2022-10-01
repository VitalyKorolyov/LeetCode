using LeetCode.String.Easy.ValidPalindrome;
using Xunit;

namespace LeetCodeTests.String.Easy.ValidPalindrome
{
    public class SolutionTests
    {
        [Fact]
        public void IsPalindrome_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "A man, a plan, a canal: Panama";

            // Act
            var result = solution.IsPalindrome(s);

            // Assert
            Assert.True(result);
        }
    }
}
