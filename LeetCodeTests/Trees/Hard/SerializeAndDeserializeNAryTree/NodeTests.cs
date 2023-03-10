using LeetCode.Trees.Hard.SerializeAndDeserializeNAryTree;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.Trees.Hard.SerializeAndDeserializeNAryTree;

public class NodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var node = new Node(1 , new List<Node> { new Node(3, new List<Node> { new Node(5), new Node(6)}), 
            new Node(2), new Node(4)});

        // Act
        var res = new Codec().serialize(node);

        // Assert
        Assert.True(res == "1[3] 3[2] 5 6 2 4");

        var tree = new Codec().deserialize(res);
    }
}