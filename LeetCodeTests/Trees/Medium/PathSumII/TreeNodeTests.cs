using LeetCode.Trees.Medium.PathSumII;
using System;
using Xunit;

namespace LeetCodeTests.Trees.Medium.PathSumII
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(5, 
                new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))),
                new TreeNode(8, new TreeNode(13), new TreeNode(4, new TreeNode(5), new TreeNode(1))));

            // Act
            var res = new Solution().PathSum(treeNode, 22);

            // Assert
            Assert.True(true);
        }
    }
}
