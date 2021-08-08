using LeetCode.LinkedList.Easy.PalindromeLinkedList;
using System;
using Xunit;

namespace LeetCodeTests.LinkedList.Easy.PalindromeLinkedList
{
    public class ListNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var listNode = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));

            // Act
            var res = Solution.IsPalindrome(listNode);

            // Assert
            Assert.True(res);
        }
    }
}
