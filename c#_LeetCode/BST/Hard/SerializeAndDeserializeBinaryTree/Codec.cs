using System.Text;

namespace LeetCode.BST.Hard.SerializeAndDeserializeBinaryTree
{
    //https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x, TreeNode l = null, TreeNode r = null)
        {
            val = x;
            left = l;
            right = r;
        }
    }

    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return null;

            var res = new StringBuilder();

            Ser(root, res);
            res.Remove(res.Length - 1, 1);

            return res.ToString();
        }

        private void Ser(TreeNode node, StringBuilder res)
        {
            if (node == null)
            {
                res.Append("null,");
                return;
            }

            res.Append($"{node.val},");

            Ser(node.left, res);
            Ser(node.right, res);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data)) return null;

            var parts = data.Split(',');

            int i = 0;
            return Des(parts, null, ref i);
        }

        private TreeNode Des(string[] parts, TreeNode res, ref int i)
        {
            if(parts.Length - 1 < i) return null;
            if(parts[i] == "null") return null;

            if (res == null)
                res = new TreeNode(int.Parse(parts[i]));

            i += 1;
            res.left = Des(parts, res.left, ref i);
            i += 1;
            res.right = Des(parts, res.right, ref i);

            return res;
        }
    }
}