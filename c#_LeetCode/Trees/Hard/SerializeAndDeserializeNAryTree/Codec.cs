using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Trees.Hard.SerializeAndDeserializeNAryTree;

//https://leetcode.com/problems/serialize-and-deserialize-n-ary-tree/description/
public class Node
{
    public int val;
    public IList<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}

public class Codec
{
    public string serialize(Node root)
    {
        if (root == null) return string.Empty;

        if (root.children == null || !root.children.Any()) 
            return $"{root.val}";

        StringBuilder res = new($"{root.val}[{root.children.Count}] ");
        foreach (var child in root.children)
            res.Append(serialize(child) + " ");

        res.Remove(res.Length - 1, 1);

        return res.ToString();
    }

    public Node deserialize(string data)
    {
        if(data == null || string.IsNullOrEmpty(data)) return null;

        return Deserialize(new Queue<char>(data));
    }

    private Node Deserialize(Queue<char> queue)
    {
        while(queue.Peek() == ' ') queue.Dequeue();

        var value = GetInt(queue);
        Node node = new(value, new List<Node>());

        if(queue.Count > 0 && queue.Peek() == '[')
        {
            queue.Dequeue();
            var size = GetInt(queue);
            queue.Dequeue();

            for (int i = 0; i < size; i++)
                node.children.Add(Deserialize(queue));
        }

        return node;
    }

    private int GetInt(Queue<char> queue)
    {
        StringBuilder res = new();

        while (queue.Count > 0 && char.IsDigit(queue.Peek()))
            res.Append(queue.Dequeue());

        return int.Parse(res.ToString());
    }
}