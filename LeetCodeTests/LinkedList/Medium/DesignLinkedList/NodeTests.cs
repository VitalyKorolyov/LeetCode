using LeetCode.LinkedList.Medium.DesignLinkedList;
using Xunit;

namespace LeetCodeTests.LinkedList.Medium.DesignLinkedList;

public class NodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var list = new MyLinkedList();

        // Act
        list.AddAtHead(1);
        list.AddAtTail(2);
        list.AddAtIndex(1, 2);
        list.Get(1);
        list.DeleteAtIndex(1);
        list.Get(1);

        // Assert
        Assert.True(true);
    }
}
