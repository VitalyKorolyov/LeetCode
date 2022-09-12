namespace LeetCode.Array.Medium.PairsOfSongsWithTotalDurationsDivisibleBy60
{
    //https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/
    public class Solution
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            var remainders = new int[60];

            int count = 0;
            for (int i = 0; i < time.Length; i++)
            {
                var remainder = time[i] % 60;

                if (remainder == 0)
                    count += remainders[0];
                else
                    count += remainders[60 - remainder];

                remainders[remainder]++;
            }

            return count;
        }
    }
}
