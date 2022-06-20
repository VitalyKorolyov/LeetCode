using LeetCode.String.Medium.LongestSubstringWithAtMostKDistinctCharacters;
using Xunit;

namespace LeetCodeTests.String.Medium.LongestSubstringWithAtMostKDistinctCharacters
{
    public class SolutionTests
    {
        [Fact]
        public void LengthOfLongestSubstringKDistinct_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "a";
            int k = 0;

            // Act
            var result = solution.LengthOfLongestSubstringKDistinct(
                s,
                k);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
