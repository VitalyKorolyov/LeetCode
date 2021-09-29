using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LeetCode.LinkedList.Easy.ConvertBinaryNumberInALinkedListToInteger
{
    //https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
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
        public int GetDecimalValue(ListNode head)
        {
            var sb = new StringBuilder();

            while (head != null)
            {
                sb.Append(head.val);
                head = head.next;
            }

            return Convert.ToInt32(sb.ToString(), 2);
        }
    }
}