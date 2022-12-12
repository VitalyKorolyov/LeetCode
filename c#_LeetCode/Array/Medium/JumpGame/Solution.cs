namespace LeetCode.Array.Medium.JumpGame
{
    //https://leetcode.com/problems/jump-game/description/
    public class Solution
    {
        //O(N^2)
        public bool CanJump(int[] nums)
        {
            var visited = new bool?[nums.Length];
            visited[nums.Length - 1] = true;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                int furthestJump = System.Math.Min(i + nums[i], nums.Length - 1);

                for (int j = i + 1; j <= furthestJump; j++)
                {
                    if (visited[j] == true)
                    {
                        visited[i] = true;
                        break;
                    }
                }
            }

            return visited[0] == true;
        }

        //O(N^2)
        //private bool CanJimp(int[] nums, int position, bool?[] visited)
        //{
        //    if (position == nums.Length - 1) return true;

        //    int furthestJump = System.Math.Min(position + nums[position], nums.Length - 1);
        //    for (int jump = 1 + position; jump <= furthestJump; jump++)
        //    {
        //        if (visited[jump] == false) continue;

        //        if (CanJimp(nums, jump, visited))
        //        {
        //            visited[jump] = true;
        //            return true;
        //        }
        //    }

        //    visited[position] = false;
        //    return visited[position].Value;
        //}
    }
}
