namespace LeetCode.Array.Easy.CreateTargetArrayInTheGivenOrder
{
    public class Solution
    {
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            var targetArray = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                var indexToInsert = index[i];
                var valueToMove = nums[i];

                if (i > indexToInsert)
                {
                    for (var j = nums.Length - 1; indexToInsert <= j && j >= 1; j--)
                    {
                        targetArray[j] = targetArray[j - 1];
                    }
                }

                targetArray[indexToInsert] = valueToMove;
            }

            return targetArray;
        }
    }
}