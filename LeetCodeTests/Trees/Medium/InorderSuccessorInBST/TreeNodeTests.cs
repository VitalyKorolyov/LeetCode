using LeetCode.Trees.Medium.InorderSuccessorInBST;
using System;
using Xunit;

namespace LeetCodeTests.Trees.Medium.InorderSuccessorInBST
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(5);
            treeNode.left = new TreeNode(3);
            treeNode.right = new TreeNode(6);   
            treeNode.left.left = new TreeNode(2);
            treeNode.left.right = new TreeNode(4);
            treeNode.left.left.left = new TreeNode(1);

            // Act
            var res = new Solution().InorderSuccessor(treeNode, new TreeNode(3));

            // Assert
            Assert.Equal(treeNode.left.right, res);
        }
    }
}
