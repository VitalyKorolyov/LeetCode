using LeetCode.Array.Hard.EmployeeFreeTime;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.Array.Hard.EmployeeFreeTime
{
    public class IntervalTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var solution = new Solution();

            var schedule = new List<IList<Interval>>();
            schedule.Add(new List<Interval> { new Interval { start = 1, end = 2 }, new Interval { start = 5, end = 6 } });
            schedule.Add(new List<Interval> { new Interval { start = 1, end = 3 } });
            schedule.Add(new List<Interval> { new Interval { start = 4, end = 10 } });

            // Act
            solution.EmployeeFreeTime(schedule);

            // Assert
            Assert.True(false);
        }
    }
}
