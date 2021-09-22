using System.Collections.Generic;

namespace LeetCode.Array.Medium.SubarraySumEqualsK
{
    //https://leetcode.com/problems/subarray-sum-equals-k/
    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            var sum = 0;
            var counter = 0;
            var hash = new Dictionary<int, int>();
            hash.Add(0, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (hash.ContainsKey(sum - k))
                    counter += hash[sum - k];

                if (hash.ContainsKey(sum))
                {
                    hash[sum] = hash[sum] + 1;
                }
                else
                {
                    hash.Add(sum, hash.GetValueOrDefault(sum) + 1);
                }
            }

            return counter;
        }

        public int SubarraySumN2(int[] nums, int k)
        {
            var counter = 0;

            for (int start = 0; start < nums.Length; start++)
            {
                var sum = 0;
                for (int j = start; j < nums.Length; j++)
                {
                    sum += nums[j];

                    if (k == sum)
                        counter++;
                }
            }

            return counter;
        }

        public int SubarraySumN3(int[] nums, int k)//O(n^2)
        {
            var counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= nums.Length; j++)
                {
                    var sum = 0;
                    for (int l = i; l < j; l++)
                        sum += nums[l];

                    if (sum == k)
                        counter++;
                }
            }

            return counter;
        }
    }
}