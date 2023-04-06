using LeetCode.BST.Medium.ConvertSortedListToBinarySearchTree;
using Xunit;

namespace LeetCodeTests.BST.Medium.ConvertSortedListToBinarySearchTree;

public class ListNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var listNode = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

        // Act
        var res = new Solution().SortedListToBST(listNode);

        // Assert
        Assert.True(true);
    }
}