using System.Collections.Generic;

namespace LeetCode.Design.Medium.StockPriceFluctuation;

//https://leetcode.com/problems/stock-price-fluctuation/description/
public class StockPrice
{
    private int latestTS = 0;
    private readonly Dictionary<int, int> timeToPrice = new();
    private readonly SortedSet<(int price, int timeStamp)> priceToTime = new();

    public void Update(int timestamp, int price)
    {
        latestTS = System.Math.Max(latestTS, timestamp);

        if (timeToPrice.ContainsKey(timestamp))
        {
            int incorrectPrice = timeToPrice[timestamp];
            priceToTime.Remove((incorrectPrice, timestamp));
            priceToTime.Add((price, timestamp));
            timeToPrice[timestamp] = price;
        }
        else
        {
            timeToPrice.Add(timestamp, price);
            priceToTime.Add((price, timestamp));
        }
    }

    public int Current()
    {
        if (timeToPrice.Count == 0) return -1;
        return timeToPrice[latestTS];
    }

    public int Maximum()
    {
        if (priceToTime.Count == 0) return -1;
        return priceToTime.Max.price;
    }

    public int Minimum()
    {
        if (priceToTime.Count == 0) return -1;
        return priceToTime.Min.price;
    }
}
