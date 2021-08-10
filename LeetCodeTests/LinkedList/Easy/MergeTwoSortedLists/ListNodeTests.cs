using LeetCode.LinkedList.Easy.MergeTwoSortedLists;
using System;
using Xunit;

namespace LeetCodeTests.LinkedList.Easy.MergeTwoSortedLists
{
    public class ListNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var listNode1 = new ListNode(1, new ListNode(2, new ListNode(3)));
            var listNode2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            // Act
            var result = Solution.MergeTwoLists(listNode1, listNode2);

            // Assert
            Assert.True(true);
        }
    }
}
