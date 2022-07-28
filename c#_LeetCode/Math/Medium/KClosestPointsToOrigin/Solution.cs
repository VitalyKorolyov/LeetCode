using System.Collections.Generic;

namespace LeetCode.Math.Medium.KClosestPointsToOrigin
{
    //https://leetcode.com/problems/k-closest-points-to-origin/
    public class Solution
    {
        public int[][] KClosest(int[][] points, int k)
        {
            var queue = new PriorityQueue<int[], double>(new Comp());
            for (var i = 0; i < points.Length; i++)
            {
                var distance = System.Math.Sqrt(System.Math.Pow(points[i][0] - 0, 2) + System.Math.Pow(points[i][1] - 0, 2));

                queue.Enqueue(points[i], distance);
                if(queue.Count > k)
                    queue.Dequeue();
            }

            var result = new int[k][];
            for (int i = 0; i < k; i++)
                result[i] = queue.Dequeue();

            return result;
        }

        public class Comp : IComparer<double>
        {
            public int Compare(double x, double y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
