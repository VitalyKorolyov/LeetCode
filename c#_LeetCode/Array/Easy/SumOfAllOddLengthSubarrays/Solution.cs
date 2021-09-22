namespace LeetCode.Array.Easy.SumOfAllOddLengthSubarrays
{
    //https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
    public class Solution
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int res = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currSum = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    currSum += arr[j];

                    if ((j - i + 1) % 2 != 0)
                        res += currSum;
                }
            }

            return res;
        }
    }
}