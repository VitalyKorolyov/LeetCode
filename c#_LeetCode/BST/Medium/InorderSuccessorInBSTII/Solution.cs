namespace LeetCode.BST.Medium.InorderSuccessorInBSTII
{

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node parent;
    }

    //https://leetcode.com/problems/inorder-successor-in-bst-ii/
    public class Solution
    {
        public Node InorderSuccessor(Node x)
        {
            Node successor = null;
            var value = x.val;

            var node = x.right;
            while(node != null)
            {
                successor = node;
                node = node.left;
            }

            if(successor != null) return successor;

            node = x.parent;
            while (node != null)
            {
                if(node.val > value)
                {
                    if(successor == null)
                        successor = node;
                    else
                    {
                        if (successor.val > node.val)
                            successor = node;
                    }
                }

                node = node.parent;
            }


            return successor;
        }
    }
}
