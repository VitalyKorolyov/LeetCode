using LeetCode.Array.Easy.SumOfAllOddLengthSubarrays;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.SumOfAllOddLengthSubarrays
{
    public class SolutionTests
    {
        [Fact]
        public void SumOddLengthSubarrays_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] arr = {1,4,2,5,3};

            // Act
            var result = solution.SumOddLengthSubarrays(arr);

            // Assert
            Assert.Equal(58, result);
        }
    }
}
