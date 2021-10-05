using System;

namespace LeetCode.LinkedList.Medium.ReverseLinkedListII
{
    //https://leetcode.com/problems/reverse-linked-list-ii/
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
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            var res = new ListNode(0, head);

            ListNode prLeft = null;
            ListNode leftN = null;
            ListNode rightN = null;
            ListNode rightNextN = null;

            var current = res.next;
            var pr = res;

            var index = 1;
            while (current != null)
            {
                if (index == left)
                {
                    prLeft = pr;
                    leftN = current;
                }

                if (index == right)
                {
                    rightN = current;
                    rightNextN = rightN.next;
                    break;
                }

                pr = current;
                current = current.next;
                index++;
            }

            if (leftN == null || rightN == null) return res.next;

            var (headR, end) = Reverse(leftN, rightNextN);

            prLeft.next = headR;
            end.next = rightNextN;

            return res.next;
        }

        private Tuple<ListNode, ListNode> Reverse(ListNode left, ListNode right)
        {
            var root = left;
            ListNode prev = null;

            while (root != right)
            {
                var next = root.next;
                root.next = prev;
                prev = root;
                root = next;
            }

            return Tuple.Create(prev, left);
        }
    }
}