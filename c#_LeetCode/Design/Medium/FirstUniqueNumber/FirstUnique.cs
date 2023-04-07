using System.Collections.Generic;

namespace LeetCode.Design.Medium.FirstUniqueNumber;

//https://leetcode.com/problems/first-unique-number/description/

public class UniqueNumber
{
    public int Number { get; set; }
}

public class FirstUnique
{
    private readonly HashSet<int> allNumbers;
    private readonly Dictionary<int, UniqueNumber> numberToUniqueNumber;
    private readonly LinkedList<UniqueNumber> uniqueNumbers;

    public FirstUnique(int[] nums)
    {
        allNumbers = new();
        numberToUniqueNumber = new();
        uniqueNumbers = new();

        for (int i = 0; i < nums.Length; i++)
            Add(nums[i]);
    }

    public int ShowFirstUnique()
    {
        if (uniqueNumbers.Count == 0) return -1;

        return uniqueNumbers.First.Value.Number;
    }

    public void Add(int value)
    {
        if (allNumbers.Contains(value) && numberToUniqueNumber.ContainsKey(value))
        {
            UniqueNumber numberToRemove = numberToUniqueNumber[value];
            uniqueNumbers.Remove(numberToRemove);
            numberToUniqueNumber.Remove(value);
        }
        else if(!allNumbers.Contains(value))
        {
            allNumbers.Add(value);
            UniqueNumber uniqueNumberToAdd = new() { Number = value };
            numberToUniqueNumber.Add(value, uniqueNumberToAdd);
            uniqueNumbers.AddLast(uniqueNumberToAdd);
        }
    }
}