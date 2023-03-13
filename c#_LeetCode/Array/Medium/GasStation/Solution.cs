namespace LeetCode.Array.Medium.GasStation;

//https://leetcode.com/problems/gas-station/description/
public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int wholeRoad = 0;
        int startGasStation = 0;
        int tank = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            var diff = gas[i] - cost[i];

            wholeRoad += diff;
            tank += diff;

            if(tank < 0)
            {
                tank = 0;
                startGasStation = i + 1;
            }
        }

        return wholeRoad >= 0 ? startGasStation : -1;
    }

    //O(n^2)
    //public int CanCompleteCircuit(int[] gas, int[] cost)
    //{
    //    int n = gas.Length;

    //    for (int i = 0; i < n; i++)
    //    {
    //        int currentGas = 0;
    //        int count = 0;
    //        int j = i;

    //        while(count < n && currentGas >= 0)
    //        {
    //            currentGas += gas[j % n] - cost[j % n];
    //            count++;
    //            j++;
    //        }

    //        if (count == n && currentGas >= 0) return i;
    //    }

    //    return -1;
    //}
}