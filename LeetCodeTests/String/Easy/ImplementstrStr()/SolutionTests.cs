using LeetCode.String.Easy;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.ImplementstrStr
{
    public class SolutionTests
    {
        [Fact]
        public void StrStr_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string haystack = "mississippi";
            string needle = "issipi";

            // Act
            var result = solution.StrStr(
                haystack,
                needle);

            // Assert
            Assert.Equal(-1, result);
        }
    }
}
