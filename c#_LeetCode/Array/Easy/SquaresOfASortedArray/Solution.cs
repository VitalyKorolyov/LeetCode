namespace LeetCode.Array.Easy.SquaresOfASortedArray
{
    //https://leetcode.com/problems/squares-of-a-sorted-array/
    public class Solution
    {
        public static int[] SortedSquares(int[] nums)
        {
            int k = 0;

            for (k = 0; k < nums.Length; k++)
            {
                if (nums[k] >= 0) break;
            }

            var res = new int[nums.Length];

            int tempIndex = 0;
            int i = k - 1;
            int j = k;

            while (i >= 0 && j <= nums.Length - 1)
            {
                var r1 = nums[i] * nums[i];
                var r2 = nums[j] * nums[j];

                if (r1 < r2)
                {
                    res[tempIndex++] = r1;
                    i--;
                }
                else
                {
                    res[tempIndex++] = r2;
                    j++;
                }
            }

            while (i >= 0)
            {
                res[tempIndex++] = nums[i] * nums[i];
                i--;
            }

            while (j <= nums.Length - 1)
            {
                res[tempIndex++] = nums[j] * nums[j];
                j++;
            }

            return res;
        }
    }
}