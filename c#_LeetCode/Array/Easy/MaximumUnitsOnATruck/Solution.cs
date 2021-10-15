namespace LeetCode.Array.Easy.MaximumUnitsOnATruck
{
    //https://leetcode.com/problems/maximum-units-on-a-truck/
    public class Solution
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            System.Array.Sort(boxTypes, (x, y) => y[1].CompareTo(x[1]));

            var res = 0;
            for (int i = 0; i < boxTypes.Length && truckSize != 0; i++)
            {
                if (boxTypes[i][0] <= truckSize)
                {
                    truckSize -= boxTypes[i][0];
                    res += boxTypes[i][1] * boxTypes[i][0];
                }
                else
                {
                    res += truckSize * boxTypes[i][1];
                    truckSize -= truckSize;
                }
            }

            return res;
        }
    }
}