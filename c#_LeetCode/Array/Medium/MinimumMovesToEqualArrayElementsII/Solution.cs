namespace LeetCode.Array.Medium.MinimumMovesToEqualArrayElementsII
{
    //https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/
    public class Solution
    {
        public int MinMoves2(int[] nums)
        {
            System.Array.Sort(nums);

            var median = nums[nums.Length/2];

            var moves = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                moves += System.Math.Abs(nums[i] - median);
            }

            return moves;
        }
    }
}
