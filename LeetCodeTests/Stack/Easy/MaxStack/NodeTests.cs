using LeetCode.Stack.Easy.MaxStack;
using System;
using Xunit;

namespace LeetCodeTests.Stack.Easy.MaxStack
{
    public class NodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            var stack = new LeetCode.Stack.Easy.MaxStack.MaxStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(1);

            Assert.Equal(3, stack.PeekMax());
            Assert.Equal(3, stack.PopMax());
            Assert.Equal(1, stack.Top());
            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.PeekMax());
            Assert.Equal(2, stack.PopMax());
        }
    }
}
