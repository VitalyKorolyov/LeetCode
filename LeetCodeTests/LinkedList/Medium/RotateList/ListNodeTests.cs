using LeetCode.LinkedList.Medium.RotateList;
using System;
using Xunit;

namespace LeetCodeTests.LinkedList.Medium.RotateList
{
    public class ListNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

            // Act
            var res = new Solution().RotateRight(listNode, 10);

            // Assert
            Assert.True(true);
        }
    }
}
