using System.Collections.Generic;

namespace LeetCode.BST.Medium.ConvertSortedListToBinarySearchTree;

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

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

//https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/description/

public class Solution
{
    //O(N)
    public TreeNode SortedListToBST(ListNode head)
    {
        if(head == null) return null;

        List<int> array = new();
        while(head != null)
        {
            array.Add(head.val);
            head = head.next;
        }

        return BuildTree(array, 0, array.Count - 1);
    }

    private TreeNode BuildTree(List<int> array, int left, int right)
    {
        if(left > right) return null;

        int middle = (left + right) / 2;

        TreeNode root = new(array[middle]);

        if (left == right) return root;

        root.left = BuildTree(array, left, middle - 1);
        root.right = BuildTree(array, middle + 1, right);

        return root;
    }

    //NLogN
    //public TreeNode SortedListToBST(ListNode head)
    //{
    //    if (head == null) return null;

    //    ListNode mid = GetMiddle(head);

    //    TreeNode node = new(mid.val);

    //    if (head == mid) return node;

    //    node.left = SortedListToBST(head);
    //    node.right = SortedListToBST(mid.next);

    //    return node;
    //}

    //private ListNode GetMiddle(ListNode head)
    //{
    //    ListNode prevSlow = null;
    //    ListNode slow = head;
    //    ListNode fast = head;

    //    while (fast != null && fast.next != null)
    //    {
    //        prevSlow = slow;
    //        slow = slow.next;
    //        fast = fast.next.next;
    //    }

    //    // Handling the case when slow was equal to head.
    //    if (prevSlow != null)
    //        prevSlow.next = null;

    //    return slow;
    //}
}