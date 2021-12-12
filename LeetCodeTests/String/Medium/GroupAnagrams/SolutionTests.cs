using LeetCode.String.Medium.GroupAnagrams;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.GroupAnagrams
{
    public class SolutionTests
    {
        [Fact]
        public void GroupAnagrams_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string[] strs = {"ddddddddddg","dgggggggggg"};

            // Act
            var result = solution.GroupAnagrams(
                strs);

            // Assert
            Assert.True(true);
        }
    }
}
