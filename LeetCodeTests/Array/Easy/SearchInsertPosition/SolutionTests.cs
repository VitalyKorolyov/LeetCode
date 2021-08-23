using LeetCode.Array.Easy.SearchInsertPosition;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.SearchInsertPosition
{
    public class SolutionTests
    {
        [Fact]
        public void SearchInsert_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int[] nums = { 1 };
            int target = 7;

            // Act
            var result = Solution.SearchInsert(
                nums,
                target);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
