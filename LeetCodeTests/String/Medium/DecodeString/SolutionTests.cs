using LeetCode.String.Medium.DecodeString;
using Xunit;

namespace LeetCodeTests.String.Medium.DecodeString
{
    public class SolutionTests
    {
        [Fact]
        public void DecodeString_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "3[a2[bx]]";

            // Act
            var result = solution.DecodeString(s);

            // Assert
            Assert.Equal("abxbxabxbxabxbx", result);
        }
    }
}
