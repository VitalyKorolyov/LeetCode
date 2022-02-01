﻿using LeetCode.String.Medium.DecodeString;
using System;
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
            string s = "3[a]2[bc]";

            // Act
            var result = solution.DecodeString(
                s);

            // Assert
            Assert.Equal("zzzyypqjkjkefjkjkefjkjkefjkjkefyypqjkjkefjkjkefjkjkefjkjkefef", result);
        }
    }
}
