using LeetCode.Trees.Medium.ConstructBinaryTreeFromPreorderAndInorderTraversal;
using Xunit;

namespace LeetCodeTests.Trees.Medium.ConstructBinaryTreeFromPreorderAndInorderTraversal;
public class TreeNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var solution = new Solution();
        int[] preOrder = new int[] { 3, 9, 20, 15, 7 };
        int[] inOrder = new int[] { 9, 3, 15, 20, 7 };

        // Act
        var result = solution.BuildTree(preOrder, inOrder);

        // Assert
        Assert.True(true);
    }
}
