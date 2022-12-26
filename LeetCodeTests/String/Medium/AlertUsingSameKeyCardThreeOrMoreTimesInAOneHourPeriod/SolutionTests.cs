using LeetCode.String.Medium.AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriod;
using System;
using System.Linq;
using Xunit;

namespace LeetCodeTests.String.Medium.AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriod
{
    public class SolutionTests
    {
        [Fact]
        public void AlertNames_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string[] keyName = { "a", "a", "a", "a", "a", "b", "b", "b", "b", "b", "b" };
            string[] keyTime = { "04:48", "23:53", "06:36", "07:45", "12:16", "00:52", "10:59", "17:16", "00:36", "01:26", "22:42" };

            // Act
            var result = solution.AlertNames(keyName, keyTime);

            // Assert
            Assert.True(!result.Any());
        }
    }
}
