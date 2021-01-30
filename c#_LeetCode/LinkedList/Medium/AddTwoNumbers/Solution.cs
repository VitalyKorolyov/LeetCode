namespace LeetCode.LinkedList.Medium.AddTwoNumbers
{
    //https://leetcode.com/problems/add-two-numbers/

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
            var needToAddOne = false;
            var output = new ListNode();

            var iterator = output;
            for (var i = 0; i <= 100; i++)
            {
                var value = l1.val + l2.val + (needToAddOne ? 1 : 0);
                needToAddOne = value >= 10;
                iterator.val = value % 10;

                if (l1.next == null && l2.next == null)
                {
                    if (needToAddOne)
                        iterator.next = new ListNode(1);
                    break;
                }

                l1 = l1.next;
                l2 = l2.next;

                if (l1 == null && l2 != null)
                {
                    l1 = new ListNode();
                }

                if (l1 != null && l2 == null)
                {
                    l2 = new ListNode();
                }

                iterator.next = new ListNode();
                iterator = iterator.next;
            }

            return output;
        }
    }
}