using System;
using LeetCode.Queue.Medium.DesignHitCounter;
using Xunit;

namespace LeetCodeTests.HashTable.Medium.DesignHitCounter
{
    public class HitCounterTests
    {
        [Fact]
        public void Hit_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var hitCounter = new HitCounter();

            // Act
            hitCounter.Hit(1);
            hitCounter.Hit(1);
            hitCounter.Hit(2);
            hitCounter.Hit(3);
            hitCounter.Hit(3);
            hitCounter.Hit(300);

            // Assert
            Assert.Equal(6, hitCounter.GetHits(300));
            Assert.Equal(4, hitCounter.GetHits(301));
        }

        [Fact]
        public void GetHits_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var hitCounter = new HitCounter();
            int timestamp = 0;

            // Act
            var result = hitCounter.GetHits(
                timestamp);

            // Assert
            Assert.True(false);
        }
    }
}
