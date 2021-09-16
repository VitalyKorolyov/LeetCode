using System.Collections.Generic;

namespace LeetCode.Graph.Medium.CloneGraph
{
    //https://leetcode.com/problems/clone-graph/
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }


    public class Solution
    {
        public Node CloneGraph(Node node)
        {
            if (node == null) return null;

            var visited = new Dictionary<Node, Node>();

            return Clone(node, visited);
        }

        private Node Clone(Node node, Dictionary<Node, Node> visited)
        {
            if(visited.ContainsKey(node)) return visited[node];

            var copy = new Node(node.val);
            visited.Add(node, copy);

            foreach (var neighbor in node.neighbors)
                copy.neighbors.Add(Clone(neighbor, visited));

            return copy;
        }
    }
}