using System.Collections.Generic;

namespace LeetCode.Array.Medium.KthSmallestElementInASortedMatrix
{
    //https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/
    public class Solution
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            var priorityQueue = new PriorityQueue<int, int>(new Comparer());

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    priorityQueue.Enqueue(matrix[i][j], matrix[i][j]);
                    if (priorityQueue.Count > k) priorityQueue.Dequeue();
                }
            }

            return priorityQueue.Peek();
        }

        public class Comparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
