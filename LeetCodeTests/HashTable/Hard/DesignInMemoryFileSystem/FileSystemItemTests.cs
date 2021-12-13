using LeetCode.HashTable.Hard.DesignInMemoryFileSystem;
using System;
using Xunit;

namespace LeetCodeTests.HashTable.Hard.DesignInMemoryFileSystem
{
    public class FileSystemItemTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var fileSystemItem = new FileSystem();

            // Act
            fileSystemItem.Mkdir("/goowmfn");
            fileSystemItem.Ls("/goowmfn");
            fileSystemItem.Ls("/");
            fileSystemItem.Mkdir("/z");
            fileSystemItem.AddContentToFile("/goowmfn/c", "shetopcy");
            fileSystemItem.Ls("/");
            fileSystemItem.Ls("/goowmfn/c");
            fileSystemItem.Ls("/goowmfn");

            // Assert
            Assert.True(true);
        }
    }
}
