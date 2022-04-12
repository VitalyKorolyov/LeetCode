using System.Collections.Generic;

namespace LeetCode.LinkedList.Medium.MaximumTwinSumOfALinkedList
{
    //https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
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
        public int PairSum(ListNode head)
        {
            var stack = new Stack<ListNode>();

            var savedHead = head;

            while (head != null)
            {
                stack.Push(head);
                head = head.next;
            }

            head = savedHead;

            var maxSum = int.MinValue;
            var length = stack.Count;

            for (var i = 0; i < length / 2; i++)
            {
                maxSum = System.Math.Max(maxSum, head.val + stack.Pop().val);
                head = head.next;
            }

            return maxSum;
        }
    }
}
