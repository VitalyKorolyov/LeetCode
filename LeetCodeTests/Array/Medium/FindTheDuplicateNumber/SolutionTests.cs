using LeetCode.Array.Medium.FindTheDuplicateNumber;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.FindTheDuplicateNumber
{
    public class SolutionTests
    {
        [Fact]
        public void FindDuplicate_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int[] nums = {4, 2, 3, 4};

            // Act
            var result = Solution.FindDuplicate(nums);

            // Assert
            Assert.True(result == 1);
        }
    }
}
