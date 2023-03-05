using LeetCode.Trees.Medium.ClosestLeafInABinaryTree;
using Xunit;

namespace LeetCodeTests.Trees.Medium.ClosestLeafInABinaryTree;

public class TreeNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var treeNode = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));

        // Act
        var result = new Solution().FindClosestLeaf(treeNode, 5);

        // Assert
        Assert.True(result == 5);
    }
}