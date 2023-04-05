namespace LeetCode.DynamicProgramming.Medium.UniqueBinarySearchTrees;

//https://leetcode.com/problems/unique-binary-search-trees/description/
public class Solution
{
    public int NumTrees(int n)
    {
        int[] unique = new int[n + 1];
        unique[0] = 1;
        unique[1] = 1;

        for (int i = 2; i <= n; ++i)
            for (int j = 1; j <= i; ++j)
                unique[i] += unique[j - 1] * unique[i - j];

        return unique[n];
    }
}