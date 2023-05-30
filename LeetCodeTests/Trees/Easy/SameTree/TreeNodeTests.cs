using LeetCode.Trees.Easy.SameTree;
using Xunit;

namespace LeetCodeTests.Trees.Easy.SameTree;

public class TreeNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var q = new TreeNode(1, new TreeNode(0), new TreeNode(3));

        // Act
        var res = new Solution().IsSameTree(p, q);

        // Assert
        Assert.False(res);
    }
}