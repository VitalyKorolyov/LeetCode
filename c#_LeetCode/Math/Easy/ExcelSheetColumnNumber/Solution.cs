namespace LeetCode.Math.Easy.ExcelSheetColumnNumber;

//https://leetcode.com/problems/excel-sheet-column-number/description/
public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int number = 0;

        for (int i = 0; i < columnTitle.Length; i++)
            number = 26 * number + (columnTitle[i] - 'A' + 1);

        return number;
    }
}