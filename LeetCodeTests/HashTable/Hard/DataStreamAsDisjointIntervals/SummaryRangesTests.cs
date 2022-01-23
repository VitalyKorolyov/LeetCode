using LeetCode.HashTable.Hard.DataStreamAsDisjointIntervals;
using System;
using Xunit;

namespace LeetCodeTests.HashTable.Hard.DataStreamAsDisjointIntervals
{
    public class SummaryRangesTests
    {
        [Fact]
        public void AddNum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var summaryRanges = new SummaryRanges();
            int val = 1;

            // Act
            summaryRanges.AddNum(val);
            var res =  summaryRanges.GetIntervals();
            summaryRanges.AddNum(3);
            res = summaryRanges.GetIntervals();
            summaryRanges.AddNum(7);
            res = summaryRanges.GetIntervals();
            summaryRanges.AddNum(2);
            res = summaryRanges.GetIntervals();
            summaryRanges.AddNum(6);
            res = summaryRanges.GetIntervals();

            // Assert
            //Assert.True(false);
        }
    }
}
