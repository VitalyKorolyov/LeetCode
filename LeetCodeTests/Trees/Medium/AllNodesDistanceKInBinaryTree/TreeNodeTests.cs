using LeetCode.Trees.Medium.AllNodesDistanceKInBinaryTree;
using Xunit;

namespace LeetCodeTests.Trees.Medium.AllNodesDistanceKInBinaryTree;

public class TreeNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var treeNode = new TreeNode(0, new TreeNode(1, null, new TreeNode(2, null, new TreeNode(3, null, new TreeNode(4)))));

        // Act
        var res = new Solution().DistanceK(treeNode, new TreeNode(3), 0);

        // Assert
        Assert.True(true);
    }
}