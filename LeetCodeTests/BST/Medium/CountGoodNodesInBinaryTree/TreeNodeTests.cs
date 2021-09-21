using LeetCode.BST.Medium.CountGoodNodesInBinaryTree;
using System;
using Xunit;

namespace LeetCodeTests.BST.Medium.CountGoodNodesInBinaryTree
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(9, null, new TreeNode(3, new TreeNode(6)));

            // Act
            var res = new Solution().GoodNodes(treeNode);

            // Assert
            Assert.Equal(1, res);
        }
    }
}
