using LeetCode.String.Easy.LongestCommonPrefix;
using Xunit;

namespace LeetCodeTests.String.Easy.LongestCommonPrefix
{
    public class SolutionTests
    {
        [Fact]
        public void LongestCommonPrefix_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string[] strs = new string[] { "flower", "flow", "flight" };

            // Act
            var result = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.True("fl" == result);
        }
    }
}
