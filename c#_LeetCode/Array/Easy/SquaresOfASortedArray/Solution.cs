namespace LeetCode.Array.Easy.SquaresOfASortedArray
{
    //https://leetcode.com/problems/squares-of-a-sorted-array/
    public class Solution
    {
        public static int[] SortedSquares(int[] nums)
        {
            var res = new int[nums.Length];

            var index = nums.Length - 1;
            for (int i = 0, j = nums.Length - 1; index >= 0;)
            {
                var square1 = nums[i] * nums[i];
                var square2 = nums[j] * nums[j];

                if (square1 > square2) 
                {
                    res[index--] = square1;
                    i++;
                }
                else
                {
                    res[index--] = square2;
                    j--;
                }
            }

            return res;
        }
    }
}