namespace LeetCode.Graph.Easy
{
    //https://leetcode.com/problems/find-center-of-star-graph/
    public class FindCenterOfStarGraph
    {
        public static int FindCenter(int[][] edges)
        {
            return edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1] ? edges[0][0] : edges[0][1];
        }
    }
}