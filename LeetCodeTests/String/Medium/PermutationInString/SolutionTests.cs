using LeetCode.String.Medium.PermutationInString;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.PermutationInString
{
    public class SolutionTests
    {
        [Fact]
        public void CheckInclusion_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s1 = "adc";
            string s2 = "dcda";

            // Act
            var result = solution.CheckInclusion(
                s1,
                s2);

            // Assert
            Assert.True(result);
        }
    }
}
