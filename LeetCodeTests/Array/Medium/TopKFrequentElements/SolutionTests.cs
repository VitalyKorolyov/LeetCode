using LeetCode.Array.Medium.TopKFrequentElements;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.TopKFrequentElements
{
    public class SolutionTests
    {
        [Fact]
        public void TopKFrequent_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;

            // Act
            var result = solution.TopKFrequent(
                nums,
                k);

            // Assert
            Assert.Equal(new[] {2, 1}, result);
        }
    }
}
