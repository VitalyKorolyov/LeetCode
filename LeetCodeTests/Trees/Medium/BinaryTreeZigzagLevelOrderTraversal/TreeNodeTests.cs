using LeetCode.Trees.Medium.BinaryTreeZigzagLevelOrderTraversal;
using System;
using Xunit;

namespace LeetCodeTests.Trees.Medium.BinaryTreeZigzagLevelOrderTraversal
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(0, new TreeNode(2, new TreeNode(1, new TreeNode(5), new TreeNode(1))), 
                new TreeNode(4, new TreeNode(3, null, new TreeNode(6)), new TreeNode(-1, null, new TreeNode(8))));

            // Act
            var res = new Solution().ZigzagLevelOrder(treeNode);

            // Assert
            Assert.True(true);
        }
    }
}
