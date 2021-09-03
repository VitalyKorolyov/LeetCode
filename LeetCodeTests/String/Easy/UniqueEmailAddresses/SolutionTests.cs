using LeetCode.String.Easy.UniqueEmailAddresses;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.UniqueEmailAddresses
{
    public class SolutionTests
    {
        [Fact]
        public void NumUniqueEmails_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string[] emails =
                {"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"};

            // Act
            var result = solution.NumUniqueEmails(emails);

            // Assert
            Assert.True(true);
        }
    }
}
