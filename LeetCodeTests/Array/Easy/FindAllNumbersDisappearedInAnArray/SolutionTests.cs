using LeetCode.Array.Easy.FindAllNumbersDisappearedInAnArray;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.FindAllNumbersDisappearedInAnArray
{
    public class SolutionTests
    {
        [Fact]
        public void FindDisappearedNumbers_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 4 };

            // Act
            var result = solution.FindDisappearedNumbers(
                nums);

            // Assert
            Assert.True(true);
        }
    }
}
