using LeetCode.Array.Easy.MovingAverageFromDataStream;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.MovingAverageFromDataStream
{
    public class MovingAverageTests
    {
        [Fact]
        public void Next_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var movingAverage = new MovingAverage(3);

            // Act
            Assert.Equal(1.0, movingAverage.Next(1));
            Assert.Equal(5.5, movingAverage.Next(10));
            Assert.Equal(4.666666666666667, movingAverage.Next(3));
            Assert.Equal(6.0, movingAverage.Next(5));
        }
    }
}
