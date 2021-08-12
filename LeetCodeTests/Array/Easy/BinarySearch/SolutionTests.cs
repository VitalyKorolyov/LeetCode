using LeetCode.Array.Easy.BinarySearch;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.BinarySearch
{
    public class SolutionTests
    {
        [Fact]
        public void Search_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = -2;

            // Act
            var result = Solution.Search(
                nums,
                target);

            // Assert
            Assert.Equal(-1, result);
        }
    }
}
