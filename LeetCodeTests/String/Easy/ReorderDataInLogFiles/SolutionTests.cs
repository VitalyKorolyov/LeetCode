using Xunit;

namespace LeetCodeTests.String.Easy.ReorderDataInLogFiles
{
    public class SolutionTests
    {
        [Fact]
        public void ReorderLogFiles_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new LeetCode.String.Easy.ReorderDataInLogFiles.Solution();
            string[] logs = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };

            // Act
            var result = solution.ReorderLogFiles(
                logs);

            // Assert
            Assert.Equal(new string[]{ "let1 art can","let3 art zero",
                "let2 own kit dig","dig1 8 1 5 1","dig2 3 6" }, result);
        }
    }
}
