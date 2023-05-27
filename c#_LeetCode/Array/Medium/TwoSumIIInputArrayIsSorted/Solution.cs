namespace LeetCode.Array.Medium.TwoSumIIInputArrayIsSorted;

//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int i = 0;
        int j = numbers.Length - 1;

        while (i < j)
        {
            int currentSum = numbers[i] + numbers[j];

            if (currentSum == target) return new int[] { i + 1, j + 1 };

            if(currentSum > target) j--;
            else i++;
        }

        return new int[] { };
    }
}