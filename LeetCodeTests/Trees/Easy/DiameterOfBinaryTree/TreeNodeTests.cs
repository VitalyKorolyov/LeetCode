using LeetCode.Trees.Easy.DiameterOfBinaryTree;
using Xunit;

namespace LeetCodeTests.Trees.Easy.DiameterOfBinaryTree
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));

            // Act
            var result = Solution.DiameterOfBinaryTree(treeNode);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
