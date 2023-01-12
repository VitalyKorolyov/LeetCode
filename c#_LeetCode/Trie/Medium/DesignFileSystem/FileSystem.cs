using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Trie.Medium.DesignFileSystem;

//https://leetcode.com/problems/design-file-system/description/

public class Node
{
    public int? Value { get; set; }
    public Dictionary<string, Node> Nodes { get; set; } = new();
}

public class Trie
{
    public Node Head { get; set; } = new();
}

public class FileSystem
{
    private readonly Trie Trie;

    public FileSystem()
    {
        Trie = new Trie();
    }

    public bool CreatePath(string path, int value)
    {
        var paths = path.Split('/').Skip(1).ToArray();

        var node = Trie.Head;
        for (int i = 0; i < paths.Length && node != null; i++)
        {
            if(i == paths.Length - 1)
            {
                if (!node.Nodes.ContainsKey(paths[i]))
                {
                    Node newNode = new();

                    node.Nodes.Add(paths[i], newNode);
                    newNode.Value = value;

                    return true;
                }

                return false;
            }
            else
            {
                if (node.Nodes.ContainsKey(paths[i]))
                    node = node.Nodes[paths[i]];
                else
                    return false;
            }
        }

        return false;
    }

    public int Get(string path)
    {
        var paths = path.Split('/').Skip(1).ToArray();

        var node = Trie.Head;
        for (int i = 0; i < paths.Length && node != null; i++)
        {
            if (node.Nodes.ContainsKey(paths[i]))
            {
                if (i == paths.Length - 1)
                {
                    var nodeToGet = node.Nodes[paths[i]];
                    return nodeToGet.Value ?? -1;
                }
                else if (node.Nodes.ContainsKey(paths[i]))
                    node = node.Nodes[paths[i]];
            }
            else
                return -1;
        }

        return -1;
    }
}
