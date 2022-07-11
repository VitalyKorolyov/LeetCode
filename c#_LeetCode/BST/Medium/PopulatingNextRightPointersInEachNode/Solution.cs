using System.Collections.Generic;

namespace LeetCode.BST.Medium.PopulatingNextRightPointersInEachNode
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    //https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null) return root;

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var size = queue.Count;

                Node prev = null;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();

                    node.next = prev;
                    prev = node;

                    if (node.right != null)
                        queue.Enqueue(node.right);

                    if (node.left != null)
                        queue.Enqueue(node.left);
                }
            }

            return root;
        }
    }
}
