using System.Collections.Generic;

namespace LeetCode.Trees.Easy.MaximumDepthOfNaryTree
{
    //https://leetcode.com/problems/maximum-depth-of-n-ary-tree/
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public class Solution
    {
        private int _maxDepth = 0;

        public int MaxDepth(Node root)
        {
            if (root == null) return 0;

            Max(root, 1);

            return _maxDepth;
        }

        private void Max(Node root, int depth)
        {
            if(root == null) return;

            if (_maxDepth < depth)
                _maxDepth = depth;

            foreach (var child in root.children)
            {
                Max(child, depth + 1);
            }
        }
    }
}