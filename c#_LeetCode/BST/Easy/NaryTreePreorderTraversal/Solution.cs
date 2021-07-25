using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BST.Easy.NaryTreePreorderTraversal
{
    //https://leetcode.com/problems/n-ary-tree-preorder-traversal/
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
        public IList<int> Preorder(Node root)
        {
            var result = new List<int>();
            Recursive(root, result);

            return result;
        }

        public void Recursive(Node root, List<int> result)
        {
            if(root == null) return;
            
            result.Add(root.val);

            if(root.children == null || !root.children.Any()) return;

            foreach (var child in root.children)
            {
                Recursive(child, result);
            }
        }
    }
}