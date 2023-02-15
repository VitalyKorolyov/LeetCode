using System.Collections.Generic;

namespace LeetCode.Design.Medium.DesignUndergroundSystem;

//https://leetcode.com/problems/design-underground-system/description/

public class TravelInfo
{
    public string StationName { get; set; }
    public int Time { get; set; }
}

public class AverageTime
{
    public double TotalTime { get; set; }
    public double TotalTravels { get; set; }
}

public class UndergroundSystem
{
    private readonly Dictionary<int, TravelInfo> checkIn = new();
    private readonly Dictionary<string, AverageTime> pathToTime = new();

    public void CheckIn(int id, string stationName, int t)
    {
        checkIn.Add(id, new TravelInfo { StationName = stationName,Time = t });
    }

    public void CheckOut(int id, string stationName, int t)
    {
        TravelInfo currentTravel = checkIn[id];
        
        string key = $"{currentTravel.StationName}-{stationName}";
        int takeTime = t - currentTravel.Time;

        if (pathToTime.ContainsKey(key))
        {
            AverageTime averageTime = pathToTime[key];
            averageTime.TotalTime += takeTime;
            averageTime.TotalTravels++;
        }
        else
        {
            pathToTime.Add(key, new AverageTime { TotalTravels = 1, TotalTime = takeTime });
        }

        checkIn.Remove(id);
    }

    public double GetAverageTime(string startStation, string endStation)
    {
        string key = $"{startStation}-{endStation}";
        return pathToTime[key].TotalTime / pathToTime[key].TotalTravels;
    }
}
