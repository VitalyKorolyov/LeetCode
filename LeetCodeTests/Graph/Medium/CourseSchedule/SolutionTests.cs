using LeetCode.Graph.Medium.CourseSchedule;
using Xunit;

namespace LeetCodeTests.Graph.Medium.CourseSchedule
{
    public class SolutionTests
    {
        [Fact]
        public void CanFinish_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int numCourses = 20;
            int[][] prerequisites = new int[8][];
            prerequisites[0] = new int[] { 0, 10 };
            prerequisites[1] = new int[] { 3, 18 };
            prerequisites[2] = new int[] { 5, 5 };
            prerequisites[3] = new int[] { 6, 11 };
            prerequisites[4] = new int[] { 11, 14 };
            prerequisites[5] = new int[] { 13, 1 };
            prerequisites[6] = new int[] { 15, 1 };
            prerequisites[7] = new int[] { 17, 4 };

            // Act
            var result = solution.CanFinish(
                numCourses,
                prerequisites);

            // Assert
            Assert.False(result);
        }
    }
}
