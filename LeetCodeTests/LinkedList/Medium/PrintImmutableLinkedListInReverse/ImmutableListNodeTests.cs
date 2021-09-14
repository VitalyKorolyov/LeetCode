using LeetCode.LinkedList.Medium.PrintImmutableLinkedListInReverse;
using System;
using Xunit;

namespace LeetCodeTests.LinkedList.Medium.PrintImmutableLinkedListInReverse
{
    public class ImmutableListNodeTests
    {
        [Fact]
        public void PrintValue_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var immutableListNode = 
                new ImmutableListNode(1, new ImmutableListNode(2, new ImmutableListNode(3, new ImmutableListNode(4, null))));

            // Act
            var solution = new Solution();
            solution.PrintLinkedListInReverse(immutableListNode);

            // Assert
            Assert.True(true);
        }

    }
}
