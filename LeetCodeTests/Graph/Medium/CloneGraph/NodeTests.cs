using LeetCode.Graph.Medium.CloneGraph;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.Graph.Medium.CloneGraph
{
    public class NodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);

            node1.neighbors.Add(node2);
            node1.neighbors.Add(node4);

            node2.neighbors.Add(node1);
            node2.neighbors.Add(node3);

            node3.neighbors.Add(node2);
            node3.neighbors.Add(node4);

            node4.neighbors.Add(node1);
            node4.neighbors.Add(node3);


            var solution = new Solution();

            // Act
            solution.CloneGraph(node1);


            // Assert
            Assert.True(false);
        }
    }
}
