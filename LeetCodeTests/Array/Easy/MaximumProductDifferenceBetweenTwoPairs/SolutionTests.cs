using LeetCode.Array.Easy.MaximumProductDifferenceBetweenTwoPairs;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.MaximumProductDifferenceBetweenTwoPairs
{
    public class SolutionTests
    {
        [Fact]
        public void MaxProductDifference_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int[] nums = { 4, 2, 5, 9, 7, 4, 8 };

            // Act
            var result = Solution.MaxProductDifference(
                nums);

            // Assert
            Assert.Equal(64, result);
        }
    }
}
