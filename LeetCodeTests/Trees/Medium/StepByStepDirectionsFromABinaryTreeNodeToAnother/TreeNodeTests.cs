using LeetCode.Trees.Medium.StepByStepDirectionsFromABinaryTreeNodeToAnother;
using Xunit;

namespace LeetCodeTests.Trees.Medium.StepByStepDirectionsFromABinaryTreeNodeToAnother
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(2, new TreeNode(1));

            // Act
            var res = new Solution().GetDirections(treeNode, 2, 1);

            // Assert
            Assert.Equal("L", res);
        }
    }
}
