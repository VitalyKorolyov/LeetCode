using LeetCode.String.Medium.StringWithoutAAAOrBBB;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.StringWithoutAAAOrBBB
{
    public class SolutionTests
    {
        [Fact]
        public void StrWithout3a3b_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int a = 1;
            int b = 2;

            // Act
            var result = solution.StrWithout3a3b(a,b);

            // Assert
            Assert.Equal("bab", result);
        }
    }
}
