using System.Linq;

namespace LeetCode.Array.Medium.CapacityToShipPackagesWithinDDays;

//https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/description/
public class Solution
{
    public int ShipWithinDays(int[] weights, int days)
    {
        int left = weights.Max();
        int right = weights.Sum();

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (Feasible(mid, weights, days))
                right = mid;
            else 
                left = mid + 1;
        }

        return left;
    }

    private bool Feasible(int capacity, int[] weights, int d)
    {
        int days = 1;
        int total = 0;

        foreach (int weight in weights)
        {
            total += weight;

            if(total > capacity) //too heavy, wait for the next day
            {
                total = weight;
                days++;

                if(days > d) return false; //cannot ship within D days
            }
        }

        return true;
    }
}