using LeetCode.BST.Medium.FindLeavesOfBinaryTree;
using System;
using Xunit;

namespace LeetCodeTests.BST.Medium.FindLeavesOfBinaryTree
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));

            // Act
            var res = new Solution().FindLeaves(treeNode);

            // Assert
            Assert.True(true);
        }
    }
}
