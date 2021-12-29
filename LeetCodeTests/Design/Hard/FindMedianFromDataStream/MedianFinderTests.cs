using LeetCode.Design.Hard.FindMedianFromDataStream;
using System;
using Xunit;

namespace LeetCodeTests.Design.Hard.FindMedianFromDataStream
{
    public class MedianFinderTests
    {
        [Fact]
        public void AddNum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var medianFinder = new MedianFinder();

            // Act
            medianFinder.AddNum(6);
            medianFinder.AddNum(10);
            medianFinder.AddNum(2);

            // Assert
            Assert.Equal(6, medianFinder.FindMedian());
        }
    }
}
