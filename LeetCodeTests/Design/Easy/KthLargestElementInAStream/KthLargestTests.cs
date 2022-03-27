using LeetCode.Design.Easy.KthLargestElementInAStream;
using System;
using Xunit;

namespace LeetCodeTests.Design.Easy.KthLargestElementInAStream
{
    public class KthLargestTests
    {
        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var kthLargest = new KthLargest(3, new[] { 4, 5, 8, 2 });

            // Act
            var result = kthLargest.Add(3);
            Assert.Equal(4, result);
            result = kthLargest.Add(5);
            Assert.Equal(5, result);
            result = kthLargest.Add(10);
            Assert.Equal(5, result);
        }
    }
}
