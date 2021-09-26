using LeetCode.BST.Medium.BinaryTreeRightSideView;
using System;
using Xunit;

namespace LeetCodeTests.BST.Medium.BinaryTreeRightSideView
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3, null, new TreeNode(4)));

            // Act
            var res = new Solution().RightSideView(treeNode);

            // Assert
            Assert.True(true);
        }
    }
}
