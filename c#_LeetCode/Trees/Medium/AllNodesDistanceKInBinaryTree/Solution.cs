using System.Collections.Generic;

namespace LeetCode.Trees.Medium.AllNodesDistanceKInBinaryTree;

//https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/description/
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x, TreeNode left = null, TreeNode right = null) 
    { 
        val = x; 
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    private readonly Dictionary<TreeNode, TreeNode> parents = new();
    private static readonly TreeNode nullNode = new TreeNode(0);

    public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
    {
        target = Dfs(root, nullNode, target);

        HashSet<TreeNode> visited = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(target);
        visited.Add(target);

        while (queue.Count > 0 && k > 0)
        {
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();
                AddToQueue(queue, current, visited);
            }

            k--;
        }

        List<int> result = new();
        while (queue.Count > 0)
            result.Add(queue.Dequeue().val);

        return result;
    }

    private void AddToQueue(Queue<TreeNode> queue, TreeNode node, HashSet<TreeNode> visited)
    {
        if(node.left != null && !visited.Contains(node.left))
        {
            queue.Enqueue(node.left);
            visited.Add(node.left);
        }
        if (node.right != null && !visited.Contains(node.right))
        {
            queue.Enqueue(node.right);
            visited.Add(node.right);
        }
        var parent = parents[node];
        if (parent != nullNode && !visited.Contains(parent))
        {
            queue.Enqueue(parent);
            visited.Add(parent);
        }
    }

    private TreeNode Dfs(TreeNode node, TreeNode parent, TreeNode target)
    {
        if(node == null) return null;

        parents.Add(node, parent);

        var left = Dfs(node.left, node, target);
        var right = Dfs(node.right, node, target);

        return node.val == target.val ? node : left ?? right;
    }
}