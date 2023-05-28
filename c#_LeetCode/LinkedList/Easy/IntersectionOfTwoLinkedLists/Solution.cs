using System.Collections.Generic;

namespace LeetCode.LinkedList.Easy.IntersectionOfTwoLinkedLists;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

//https://leetcode.com/problems/intersection-of-two-linked-lists/description/
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> hash = new();

        while (headA != null)
        {
            hash.Add(headA);
            headA = headA.next;
        }

        while (headB != null)
        {
            if (hash.Contains(headB)) return headB;
            headB = headB.next;
        }

        return null;
    }
}