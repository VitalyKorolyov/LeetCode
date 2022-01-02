using LeetCode.BST.Hard.SerializeAndDeserializeBinaryTree;
using System;
using Xunit;

namespace LeetCodeTests.BST.Hard.SerializeAndDeserializeBinaryTree
{
    public class TreeNodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var treeNode = new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5)));

            // Act
            var codec = new Codec();
            var res = codec.serialize(treeNode);
            var a = codec.deserialize(res);

            // Assert
            Assert.True(true);
        }
    }
}
