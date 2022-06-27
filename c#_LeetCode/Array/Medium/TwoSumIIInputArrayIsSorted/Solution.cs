namespace LeetCode.Array.Medium.TwoSumIIInputArrayIsSorted
{
    //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];

            for (int i = 0, j = numbers.Length - 1; j > i;)
            {
                var sum = numbers[i] + numbers[j];

                if (sum == target)
                {
                    result[0] = i + 1;
                    result[1] = j + 1;
                    break;
                }
                if (sum > target) j--;
                else i++;
            }

            return result;
        }
    }
}
