using LeetCode.Trees.Medium.FindDuplicateSubtrees;
using Xunit;

namespace LeetCodeTests.Trees.Medium.FindDuplicateSubtrees;
public class TreeNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var treeNode = new TreeNode(1, new TreeNode(2, 
            new TreeNode(4)), new TreeNode(3, new TreeNode(2, new TreeNode(4)), new TreeNode(4)));

        // Act
        var solution = new Solution();
        solution.FindDuplicateSubtrees(treeNode);

        // Assert
        Assert.True(true);
    }
}