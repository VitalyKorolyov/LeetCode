using System.Collections.Generic;

namespace LeetCode.LinkedList.Medium.NextGreaterNodeInLinkedList;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public int[] NextLargerNodes(ListNode head)
    {
        ListNode node = head;
        List<int> array = new();

        while (node != null)
        {
            array.Add(node.val);
            node = node.next;
        }

        int[] result = new int[array.Count];
        Stack<int> stack = new();
        for (int i = array.Count - 1; i >= 0; i--)
        {
            while(stack.Count > 0 && stack.Peek() <= array[i])
                stack.Pop();

            if (stack.Count > 0)
                result[i] = stack.Peek();
            
            stack.Push(array[i]);
        }

        return result;
    }
}