namespace LeetCode.LinkedList.Easy.DeleteNodeInALinkedList
{
    //https://leetcode.com/problems/delete-node-in-a-linked-list/

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    public class Solution
    {
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}