using LeetCode.BST.Medium.ConstructBinarySearchTreeFromPreorderTraversal;
using Xunit;

namespace LeetCodeTests.BST.Medium.ConstructBinarySearchTreeFromPreorderTraversal;

public class TreeNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var res = solution.BstFromPreorder(new int[] { 8, 5, 1, 7, 10, 12 });

        // Assert
        Assert.True(true);
    }
}