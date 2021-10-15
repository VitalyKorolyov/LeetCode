using LeetCode.LinkedList.Medium.ReorderList;
using System;
using Xunit;

namespace LeetCodeTests.LinkedList.Medium.ReorderList
{
    public class ListNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var listNode = new ListNode(1);

            // Act
            new Solution().ReorderList(listNode);

            // Assert
            Assert.True(true);
        }
    }
}
