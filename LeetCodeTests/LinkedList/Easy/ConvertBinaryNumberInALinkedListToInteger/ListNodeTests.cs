using LeetCode.LinkedList.Easy.ConvertBinaryNumberInALinkedListToInteger;
using System;
using Xunit;

namespace LeetCodeTests.LinkedList.Easy.ConvertBinaryNumberInALinkedListToInteger
{
    public class ListNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var listNode = new ListNode(1, new ListNode(0, new ListNode(1)));

            // Act
            var res = new Solution().GetDecimalValue(listNode);

            // Assert
            Assert.Equal(5, res);
        }
    }
}
