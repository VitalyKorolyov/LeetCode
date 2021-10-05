using LeetCode.LinkedList.Medium.ReverseLinkedListII;
using System;
using Xunit;

namespace LeetCodeTests.LinkedList.Medium.ReverseLinkedListII
{
    public class ListNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

            // Act
            var res = new Solution().ReverseBetween(listNode, 2, 4);

            // Assert
            Assert.True(true);
        }
    }
}
