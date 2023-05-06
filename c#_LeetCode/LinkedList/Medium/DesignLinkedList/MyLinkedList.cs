namespace LeetCode.LinkedList.Medium.DesignLinkedList;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}

//https://leetcode.com/problems/design-linked-list/description/
public class MyLinkedList
{
    private Node head = new Node { Value = 0 };
    private int count = 0;

    public int Get(int index)
    {
        if (index < 0 || index >= count) return -1;

        var node = head;
        for (int i = 0; i < index + 1; i++)
            node = node.Next;

        return node.Value;
    }

    public void AddAtHead(int val)
    {
        AddAtIndex(0, val);
    }

    public void AddAtTail(int val)
    {
        AddAtIndex(count, val);
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > count) return;
        if (index < 0) index = 0;

        count++;
        var newNode = new Node { Value = val };
        var node = head;

        for (int i = 0; i < index; i++)
            node = node.Next;

        newNode.Next = node.Next;
        node.Next = newNode;
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= count) return;

        count--;
        var node = head;
        for (int i = 0; i < index; i++)
            node = node.Next;

        node.Next = node.Next.Next;
    }
}