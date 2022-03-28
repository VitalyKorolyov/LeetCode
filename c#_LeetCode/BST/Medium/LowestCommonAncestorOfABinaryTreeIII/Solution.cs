using System.Collections.Generic;

namespace LeetCode.BST.Medium.LowestCommonAncestorOfABinaryTreeIII
{

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node parent;
    }

    //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree-iii/
    public class Solution
    {
        public Node LowestCommonAncestor(Node p, Node q)
        {
            var hash = new HashSet<int>();

            while (p != null)
            {
                hash.Add(p.val);
                p = p.parent;
            }

            while (q != null)
            {
                if (hash.Contains(q.val)) return q;

                q = q.parent;
            }

            return null;
        }
    }
}
