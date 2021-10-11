using LeetCode.String.Medium.PartitionLabels;
using Xunit;

namespace LeetCodeTests.String.Medium.PartitionLabels
{
    public class SolutionTests
    {
        [Fact]
        public void PartitionLabels_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "ababcbacadefegdehijhklij";

            // Act
            var result = solution.PartitionLabels(s);

            // Assert
            Assert.Equal(new int[]{ 9, 7, 8 }, result);
        }
    }
}
