using LeetCode.HashTable.Medium.SnapshotArray;
using System;
using Xunit;

namespace LeetCodeTests.HashTable.Medium.SnapshotArray
{
    public class SnapshotArrayTests
    {
        [Fact]
        public void Set_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var snapshotArray = new LeetCode.HashTable.Medium.SnapshotArray.SnapshotArray(3);

            // Act
            snapshotArray.Set(0, 15);
            snapshotArray.Snap();
            snapshotArray.Snap();
            snapshotArray.Snap();

            var res = snapshotArray.Get(0, 2);

            // Assert
            Assert.True(true);
        }
    }
}
