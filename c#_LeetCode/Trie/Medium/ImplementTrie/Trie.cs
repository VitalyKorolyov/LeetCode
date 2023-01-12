using System.Collections.Generic;

namespace LeetCode.Trie.Medium.ImplementTrie;

//https://leetcode.com/problems/implement-trie-prefix-tree/description/
public class TrieNode
{
    public char Value { get; set; }
    public Dictionary<char, TrieNode> Nodes { get; set; }
    public bool IsEnd { get; set; }

    public TrieNode(char value = '/')
    {
        Value = value;
        Nodes = new();
        IsEnd = false;
    }
}

public class Trie
{
    private readonly TrieNode root;

    public Trie()
    {
        root = new();
    }

    public void Insert(string word)
    {
        var letters = word.ToCharArray();
        var node = root;

        for (int i = 0; i < letters.Length; i++)
        {
            var letter = letters[i];

            if (node.Nodes.ContainsKey(letter))
                node = node.Nodes[letter];
            else
            {
                var newNode = new TrieNode(letter);
                node.Nodes.Add(letter, newNode);
                node = newNode;
            }
        }

        node.IsEnd = true;
    }

    public bool Search(string word)
    {
        var letters = word.ToCharArray();
        var node = root;

        for (int i = 0; i < letters.Length; i++)
        {
            var letter = letters[i];

            if (node.Nodes.ContainsKey(letter))
                node = node.Nodes[letter];
            else
                return false;
        }

        return node.IsEnd;
    }

    public bool StartsWith(string prefix)
    {
        var letters = prefix.ToCharArray();
        var node = root;

        for (int i = 0; i < letters.Length; i++)
        {
            var letter = letters[i];

            if (node.Nodes.ContainsKey(letter))
                node = node.Nodes[letter];
            else
                return false;
        }

        return true;
    }
}
