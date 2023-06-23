using System.Collections.Generic;

namespace LeetCode.LinkedList.Medium.AddTwoNumbersII;

//https://leetcode.com/problems/add-two-numbers-ii/description/
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        Stack<int> stack1 = new();
        Stack<int> stack2 = new();

        while(l1 != null)
        {
            stack1.Push(l1.val);
            l1 = l1.next;
        }

        while (l2 != null)
        {
            stack2.Push(l2.val);
            l2 = l2.next;
        }

        ListNode prev = null;
        ListNode fake = new ListNode();

        int reminder = 0;
        while(stack1.Count > 0 || stack2.Count > 0)
        {
            int number1 = stack1.Count > 0 ? stack1.Pop() : 0;
            int number2 = stack2.Count > 0 ? stack2.Pop() : 0;
            
            int res = number1 + number2 + reminder;
            if (res >= 10)
            {
                reminder = 1;
                res -= 10;
            }
            else
                reminder = 0;

            var currentNode = new ListNode(res, prev);
            fake.next = currentNode;
            prev = currentNode;
        }

        if (reminder > 0)
            fake.next = new ListNode(reminder, prev);

        return fake.next;
    }
}