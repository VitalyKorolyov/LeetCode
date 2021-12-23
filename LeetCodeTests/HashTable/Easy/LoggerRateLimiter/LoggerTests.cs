using LeetCode.HashTable.Easy.LoggerRateLimiter;
using System;
using Xunit;

namespace LeetCodeTests.HashTable.Easy.LoggerRateLimiter
{
    public class LoggerTests
    {
        [Fact]
        public void ShouldPrintMessage_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var logger = new Logger();

            // Asserts
            Assert.True(logger.ShouldPrintMessage(1, "foo"));
            Assert.True(logger.ShouldPrintMessage(2, "bar"));
            Assert.False(logger.ShouldPrintMessage(3, "foo"));
            Assert.False(logger.ShouldPrintMessage(8, "bar"));
            Assert.False(logger.ShouldPrintMessage(10, "foo"));
            Assert.True(logger.ShouldPrintMessage(11, "foo"));
        }
    }
}
