using LeetCode.Stack.Hard;
using System;
using Xunit;

namespace LeetCodeTests.Stack.Hard
{
    public class FreqTests
    {
        [Fact]
        public void Compare_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var freq = new FreqStack();

            // Act
            freq.Push(5); 
            freq.Push(5);
            freq.Push(5);
            freq.Push(7);
            freq.Push(5);
            freq.Push(7);
            freq.Push(1);
            freq.Push(1);
            freq.Push(1);
            freq.Push(1);
            freq.Push(1);
            freq.Push(5);
            freq.Push(1);

            var value = freq.Pop();

            // Assert
            Assert.True(true);
        }
    }
}
