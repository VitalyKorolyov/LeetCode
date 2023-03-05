using System.Collections.Generic;

namespace LeetCode.Trees.Medium.ClosestLeafInABinaryTree;

//https://leetcode.com/problems/closest-leaf-in-a-binary-tree/description/
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
    public int FindClosestLeaf(TreeNode root, int k)
    {
        Dictionary<TreeNode, List<TreeNode>> graph = new();
        Dfs(root, graph);

        HashSet<TreeNode> visited = new();
        Queue<TreeNode> queue = new();

        foreach (TreeNode node in graph.Keys)
        {
            if (node != null && node.val == k)
            {
                queue.Enqueue(node);
                visited.Add(node);
            }
        }

        while (queue.Count > 0)
        {
            int size = queue.Count;
            var val = queue.Dequeue();
            if (val.left == null && val.right == null) return val.val;

            for (int i = 0; i < size; i++)
            {
                var list = graph[val];

                foreach (var child in list)
                {
                    if(child.right == null && child.left == null) return child.val;

                    if (visited.Contains(child)) continue;
                    queue.Enqueue(child);
                    visited.Add(child);
                }
            }
        }

        return 1;
    }

    private void Dfs(TreeNode node, Dictionary<TreeNode, List<TreeNode>> graph)
    {
        if(node == null) return;

        if(!graph.ContainsKey(node))
            graph.Add(node, new List<TreeNode>());

        if (node.left != null)
        {
            if (!graph.ContainsKey(node.left))
                graph.Add(node.left, new List<TreeNode>());

            graph[node.left].Add(node);
            graph[node].Add(node.left);
        }
        if (node.right != null)
        {
            if (!graph.ContainsKey(node.right))
                graph.Add(node.right, new List<TreeNode>());

            graph[node.right].Add(node);
            graph[node].Add(node.right);
        }

        Dfs(node.left, graph);
        Dfs(node.right, graph);
    }
}