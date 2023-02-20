using LeetCode.String.Medium.RewardTopKStudents;
using Xunit;

namespace LeetCodeTests.String.Medium.RewardTopKStudents;
public class SolutionTests
{
    [Fact]
    public void TopStudents_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string[] positive_feedback = { "smart", "brilliant", "studious" };
        string[] negative_feedback = { "not" };
        string[] report = { "this student is not studious", "the student is smart" };
        int[] student_id = { 1, 2 };
        int k = 2;

        // Act
        var result = solution.TopStudents(
            positive_feedback,
            negative_feedback,
            report,
            student_id,
            k);

        // Assert
        Assert.True(true);
    }
}
