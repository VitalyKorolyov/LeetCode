using LeetCode.Trees.Medium.LowestCommonAncestorOfABinaryTree;
using System;
using Xunit;

namespace LeetCodeTests.Trees.Medium.LowestCommonAncestorOfABinaryTree
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var exRes = new TreeNode()
            {
                val = 5,
                left = new TreeNode { val = 6 },
                right = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode() { val = 7 },
                    right = new TreeNode() { val = 4 }
                }
            };
            var treeNode = new TreeNode()
            {
                val = 3,
                left = exRes,
                right = new TreeNode() 
                {
                    val = 1,
                    left = new TreeNode() { val = 0 },
                    right = new TreeNode() { val = 8 }
                }
            };

            // Act
            var res = new Solution().LowestCommonAncestor(treeNode, new TreeNode { val = 5 }, new TreeNode { val = 4 });

            // Assert
            Assert.Equal(exRes, res);
        }
    }
}
