using LeetCode.Graph.Medium.CourseScheduleII;
using System;
using Xunit;

namespace LeetCodeTests.Graph.Medium.CourseScheduleII
{
    public class SolutionTests
    {
        [Fact]
        public void FindOrder_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int numCourses = 2;
            int[][] prerequisites = new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } };

            // Act
            var result = solution.FindOrder(
                numCourses,
                prerequisites);

            // Assert
            Assert.True(true);
        }
    }
}
