using LeetCode.Trees.Medium.PathSumIII;
using System;
using Xunit;

namespace LeetCodeTests.Trees.Medium.PathSumIII
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(-2, null, new TreeNode(-3));

            // Act
            var solution = new Solution().PathSum(treeNode, -3);

            // Assert
            Assert.True(false);
        }
    }
}
