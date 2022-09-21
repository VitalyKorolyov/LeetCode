using LeetCode.Trees.Medium.BinaryTreePruning;
using Xunit;

namespace LeetCodeTests.Trees.Medium.BinaryTreePruning
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(1, null, new TreeNode(0, new TreeNode(0), new TreeNode(1)));

            // Act
            var res = new Solution().PruneTree(treeNode);

            // Assert
            Assert.True(true);
        }
    }
}
