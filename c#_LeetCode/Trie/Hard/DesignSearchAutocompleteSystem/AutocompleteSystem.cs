using System.Collections.Generic;

namespace LeetCode.Trie.Hard.DesignSearchAutocompleteSystem;

public class TrieNode
{
    public Dictionary<char, TrieNode> Children { get; set; } = new();
    public Dictionary<string, int> Counts { get; set; } = new();
}

//https://leetcode.com/problems/design-search-autocomplete-system/description/
public class AutocompleteSystem
{
    private static readonly IComparer<(string, int)> comparer = Comparer<(string, int)>.Create((a, b)
            => a.Item2 == b.Item2 ? a.Item1.CompareTo(b.Item1) : b.Item2 - a.Item2);

    private readonly TrieNode root;
    private string currentSentence;

    public AutocompleteSystem(string[] sentences, int[] times)
    {
        root = new TrieNode();
        currentSentence = string.Empty;

        for (int i = 0; i < sentences.Length; i++)
            Add(sentences[i], times[i]);
    }

    private void Add(string str, int count)
    {
        TrieNode curr = root;
        foreach (char c in str)
        {
            TrieNode next = curr.Children.GetValueOrDefault(c, null);
            if (next == null)
            {
                next = new TrieNode();
                curr.Children.Add(c, next);
            }
            curr = next;
            curr.Counts[str] = curr.Counts.GetValueOrDefault(str, 0) + count;
        }
    }

    public List<string> Input(char c)
    {
        if (c == '#')
        {
            Add(currentSentence, 1);
            currentSentence = string.Empty;
            return new List<string>();
        }

        currentSentence = currentSentence + c;
        TrieNode curr = root;
        foreach (char cc in currentSentence)
        {
            TrieNode next = curr.Children.GetValueOrDefault(cc, null);

            if (next == null) return new List<string>();
            else curr = next;
        }

        PriorityQueue<string, (string, int)> pq = new(comparer);

        foreach (var item in curr.Counts)
            pq.Enqueue(item.Key, (item.Key, item.Value));

        List<string> res = new();

        int k = 3;
        while (pq.Count > 0 && k > 0)
        {
            res.Add(pq.Dequeue());
            k--;
        }

        return res;
    }
}