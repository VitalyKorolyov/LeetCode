using LeetCode.Trie.Medium.DesignFileSystem;
using Xunit;

namespace LeetCodeTests.Trie.Medium.DesignFileSystem
{
    public class FileSystemTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var fileSystem = new FileSystem();

            // Act
            var res = fileSystem.CreatePath("/c/d", 1);
            var getRes = fileSystem.Get("/a/b");

            getRes = fileSystem.Get("/a");

            // Assert
            Assert.True(true);
        }
    }
}
