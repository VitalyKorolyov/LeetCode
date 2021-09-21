using System.Linq;

namespace LeetCode.Array.Easy.SumOfAllOddLengthSubarrays
{
    //https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
    public class Solution
    {
        private int[] oddValue = new[]
        {
            1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55,
            57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99
        };

        public int SumOddLengthSubarrays(int[] arr)
        {
            var oddValues = oddValue.Where(x => arr.Length >= x).ToArray();
            var sum = 0;
            for (int i = 0; i < oddValues.Length; i++)
            {
                var k = 0;
                var j1 = 0;
                for (int j = 0; j < arr.Length;)
                {
                    if (k >= oddValues[i])
                    {
                        j1++;
                        j = j1;
                        k = 0;
                        continue;
                    }

                    sum += arr[j++];
                    k++;
                }
            }

            return sum;
        }
    }
}