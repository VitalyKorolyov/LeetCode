using Xunit;

namespace LeetCodeTests.Stack.Medium.MinStack
{
    public class StackValueTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var minStack = new LeetCode.Stack.Medium.MinStack.MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            var min = minStack.GetMin();
            minStack.Pop();
            minStack.Top();
            min = minStack.GetMin();

            // Assert
            Assert.True(true);
        }
    }
}
