﻿using LeetCode.String.Medium.FindAllAnagramsInAString;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.FindAllAnagramsInAString
{
    public class SolutionTests
    {
        [Fact]
        public void FindAnagrams_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "aa";
            string p = "bb";

            // Act
            var result = solution.FindAnagrams(
                s,
                p);

            // Assert
            Assert.True(true);
        }
    }
}
