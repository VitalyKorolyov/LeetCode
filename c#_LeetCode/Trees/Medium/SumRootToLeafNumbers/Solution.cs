namespace LeetCode.Trees.Medium.SumRootToLeafNumbers
{
    //https://leetcode.com/problems/sum-root-to-leaf-numbers/
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public int SumNumbers(TreeNode root)
        {
            var sum = Dfs(root, 0);

            return sum;
        }

        private int Dfs(TreeNode node, int sum)
        {
            if (node == null) return 0;

            sum = sum * 10 + node.val;

            if(node.left == null && node.right == null)
            {
                return sum;
            }
            
            return Dfs(node.left, sum) + Dfs(node.right, sum);
        }

        //public int SumNumbers(TreeNode root)
        //{
        //    var res = new List<string>();

        //    Dfs(root, new StringBuilder(), res);

        //    int sum = 0;
        //    foreach (var number in res)
        //        sum += int.Parse(number);

        //    return sum;
        //}

        //private void Dfs(TreeNode node, StringBuilder builder, List<string> result)
        //{
        //    if (node == null) return;

        //    builder.Append(node.val);

        //    if (node.left == null && node.right == null)
        //    {
        //        result.Add(builder.ToString());
        //    }
        //    else
        //    {
        //        Dfs(node.left, builder, result);
        //        Dfs(node.right, builder, result);
        //    }

        //    builder.Remove(builder.Length - 1, 1);
        //}
    }
}
