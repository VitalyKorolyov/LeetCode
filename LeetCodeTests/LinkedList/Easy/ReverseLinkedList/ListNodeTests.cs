using LeetCode.LinkedList.Easy.ReverseLinkedList;
using Xunit;

namespace LeetCodeTests.LinkedList.Easy.ReverseLinkedList;

public class ListNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var listNode = new ListNode(1, new ListNode(2, new ListNode(3)));

        // Act
        var result = new Solution().ReverseList(listNode);

        // Assert
        Assert.Equal(3, result.val);
    }
}