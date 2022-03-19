using System.Linq;

namespace LeetCode.Array.Medium.MinimumSwapstoGroupAll1_sTogether
{
    //https://leetcode.com/problems/minimum-swaps-to-group-all-1s-together/
    public class Solution
    {
        public int MinSwaps(int[] data)
        {
            int numberOfOne = data.Count(x => x == 1);
            int currentOne = 0, maxOne = 0;
            int left = 0, right = 0;

            while (right < data.Length)
            {
                currentOne += data[right++];

                if (right - left > numberOfOne)
                    currentOne -= data[left++];

                maxOne = System.Math.Max(maxOne, currentOne);
            }

            return numberOfOne - maxOne;
        }
    }
}
