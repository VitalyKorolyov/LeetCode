using LeetCode.Array.Easy.RangeSumQueryImmutable;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.RangeSumQueryImmutable
{
    public class SolutionTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var numArray = new Solution.NumArray(new []{ -2, 0, 3, -5, 2, -1 });
            // Act
            var res = numArray.SumRange(2, 5);
            res = numArray.SumRange(2, 5);

            // Assert
            Assert.False(false);
        }
    }
}
