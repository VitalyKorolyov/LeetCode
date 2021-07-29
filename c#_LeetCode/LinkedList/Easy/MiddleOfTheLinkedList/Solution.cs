namespace LeetCode.LinkedList.Easy.MiddleOfTheLinkedList
{
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

    //https://leetcode.com/problems/middle-of-the-linked-list/submissions/
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var slowPointer = head;
            var fastPointer = head;

            while (fastPointer?.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }

            return slowPointer;
        }
    }
}