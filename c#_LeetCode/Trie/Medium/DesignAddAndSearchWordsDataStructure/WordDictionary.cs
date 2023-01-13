using System.Collections.Generic;

namespace LeetCode.Trie.Medium.DesignAddAndSearchWordsDataStructure;

//https://leetcode.com/problems/design-add-and-search-words-data-structure/description/
public class TrieNode
{
    public char Value { get; set; }
    public bool IsEnd { get; set; }
    public Dictionary<char, TrieNode> Nodes { get; set; }

    public TrieNode(char value)
    {
        Value = value;
        Nodes = new();
    }
}

public class WordDictionary
{
    private readonly TrieNode root;

    public WordDictionary()
    {
        root = new TrieNode('/');
    }

    public void AddWord(string word)
    {
        var letters = word.ToCharArray();
        var node = root;

        foreach (var letter in letters)
        {
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

        return Search(letters, node, 0);
    }

    private bool Search(char[] letters, TrieNode node, int start)
    {
        if (start == letters.Length) return node.IsEnd;

        if (letters[start] != '.')
        {
            if (!node.Nodes.ContainsKey(letters[start])) return false;

            node = node.Nodes[letters[start]];
            return Search(letters, node, start + 1);
        }
        else
        {
            foreach (var item in node.Nodes.Values)
                if (Search(letters, item, start + 1))
                    return true;
        }

        return false;
    }
}