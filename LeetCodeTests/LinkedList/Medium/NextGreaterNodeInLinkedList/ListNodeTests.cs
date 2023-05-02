using LeetCode.LinkedList.Medium.NextGreaterNodeInLinkedList;
using Xunit;

namespace LeetCodeTests.LinkedList.Medium.NextGreaterNodeInLinkedList;

public class ListNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var listNode = new ListNode(2, new(7, new(4, new(3, new(5)))));

        // Act
        var res = new Solution().NextLargerNodes(listNode);

        // Assert
        Assert.Equal(new int[] { 7, 0, 5, 5, 0 }, res);
    }
}