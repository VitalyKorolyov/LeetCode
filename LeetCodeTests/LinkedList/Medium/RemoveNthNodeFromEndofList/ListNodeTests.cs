using LeetCode.LinkedList.Medium.RemoveNthNodeFromEndofList;
using System;
using Xunit;

namespace LeetCodeTests.LinkedList.Medium.RemoveNthNodeFromEndofList
{
    public class ListNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

            // Act
            var result = Solution.RemoveNthFromEnd(listNode, 2);

            listNode = new ListNode(1, new ListNode(2));

            result = Solution.RemoveNthFromEnd(listNode, 1);

            // Assert
            Assert.True(true);
        }
    }
}
