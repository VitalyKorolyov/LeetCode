using LeetCode.BST.Easy.CousinsInBinaryTree;
using Xunit;

namespace LeetCodeTests.BST.Easy.CousinsInBinaryTree
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3));

            // Act
            var res = new Solution().IsCousins(treeNode, 2, 3);

            // Assert
            Assert.False(res);
        }
    }
}
