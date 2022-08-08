namespace LeetCode.Array.Medium._3Sum_Closest
{
    //https://leetcode.com/problems/3sum-closest
    //O(n^3), can be improved to O(n^2)
    public class Solution
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            System.Array.Sort(nums);

            var smalestDiff = int.MaxValue;

            for (int left = 0; left < nums.Length; left++)
            {
                var right = nums.Length - 1;
                var middle = left + 1;

                while (right > middle)
                {
                    var sum = nums[left] + nums[middle] + nums[right];

                    if (System.Math.Abs(target - sum) < System.Math.Abs(smalestDiff))
                        smalestDiff = target - sum;
                    if (sum < target)
                        middle++;
                    else
                        right--;
                }
            }

            return target - smalestDiff;
        }
    }
}