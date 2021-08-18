using System.Collections.Generic;
using LeetCode.Trees.Easy.AverageOfLevelsInBinaryTree;
using Xunit;

namespace LeetCodeTests.BST.Easy.AverageOfLevelsInBinaryTree
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

            // Act
            var res = Solution.AverageOfLevels(treeNode);

            var ex = new List<double> { 3.00000, 14.50000, 11.00000 };

            // Assert
            Assert.Equal(ex, res);
        }
    }
}
