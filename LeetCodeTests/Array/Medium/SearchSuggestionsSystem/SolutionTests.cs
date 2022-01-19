using LeetCode.Array.Medium.SearchSuggestionsSystem;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.SearchSuggestionsSystem
{
    public class SolutionTests
    {
        [Fact]
        public void SuggestedProducts_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string[] products = { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            string searchWord = "mouse";

            // Act
            var result = solution.SuggestedProducts(
                products,
                searchWord);

            // Assert
            Assert.True(false);
        }
    }
}
