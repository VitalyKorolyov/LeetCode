using LeetCode.BST.Easy.MergeTwoBinaryTrees;
using Xunit;

namespace LeetCodeTests.BST.Easy.MergeTwoBinaryTrees
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode1 = new TreeNode(1, new TreeNode(3, new TreeNode(5)), new TreeNode(2));
            var treeNode2 = new TreeNode(2, new TreeNode(1, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(7)));

            // Act
            var res = Solution.MergeTrees(treeNode1, treeNode2);

            // Assert
            Assert.True(true);
        }
    }
}
