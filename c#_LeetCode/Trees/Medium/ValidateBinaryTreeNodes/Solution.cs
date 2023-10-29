using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Trees.Medium.ValidateBinaryTreeNodes;

//https://leetcode.com/problems/validate-binary-tree-nodes/description/
public class Solution
{
    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
    {
        var merged = leftChild.Concat(rightChild).ToHashSet();

        if (merged.Contains(-1))
            merged.Remove(-1);

        if (merged.Count == n) return false;

        int root = -1;
        for (int i = 0; i < n; i++)
        {
            if (!merged.Contains(i))
            {
                root = i;
                break;
            }
        }

        HashSet<int> visited = new();

        return Dfs(root, leftChild, rightChild, visited) && visited.Count == n;
    }

    private bool Dfs(int i, int[] leftChild, int[] rightChild, HashSet<int> visited)
    {
        if (i == -1) return true;
        if (visited.Contains(i)) return false;

        visited.Add(i);

        return Dfs(leftChild[i], leftChild, rightChild, visited) &&
            Dfs(rightChild[i], leftChild, rightChild, visited);
    }
}