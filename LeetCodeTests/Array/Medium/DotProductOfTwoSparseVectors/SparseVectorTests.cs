using LeetCode.Array.Medium.DotProductOfTwoSparseVectors;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.DotProductOfTwoSparseVectors
{
    public class SparseVectorTests
    {
        [Fact]
        public void DotProduct_StateUnderTest_ExpectedBehavior()
        {
            var b = new int[] { 0, 1, 0, 0, 2, 0, 0 };
            // Arrange
            var v1 = new SparseVector(b);
            var v2 = new SparseVector(new int[] { 1, 0, 0, 0, 3, 0, 4 });

            // Act
            var result = v1.DotProduct(v2);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
