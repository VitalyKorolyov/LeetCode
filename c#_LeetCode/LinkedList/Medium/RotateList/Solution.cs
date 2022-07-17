
namespace LeetCode.LinkedList.Medium.RotateList
{
    //https://leetcode.com/problems/rotate-list/
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
        public ListNode RotateRight(ListNode head, int k)
        {
            var length = GetLength(head);
            if(length == 0 || length == 1 || k == 0 || k % length == 0) return head;

            k = k > length ? k % length : k;

            var n = length - k - 1;

            var newHead = head;
            while (n > 0)
            {
                newHead = newHead.next;
                n--;
            }

            var next = newHead.next;
            newHead.next = null;
            newHead = next;

            next = newHead;
            while (next.next != null)
                next = next.next;

            next.next = head;

            return newHead;
        }

        private int GetLength(ListNode head)
        {
            int length = 0;

            while (head != null)
            {
                head = head.next;
                length++;
            }

            return length;
        }
    }
}
