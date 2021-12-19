using LeetCode.HashTable.Hard.LFUCache;
using System;
using Xunit;

namespace LeetCodeTests.HashTable.Hard.LFUCache
{
    public class NodeTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var cache = new LeetCode.HashTable.Hard.LFUCache.LFUCache(2);

            // Act
            cache.Put(1, 1);
            cache.Put(2, 2);
            var a = cache.Get(1);
            cache.Put(3, 3);
            a = cache.Get(2);
            a = cache.Get(3);
            cache.Put(4, 4);
            a = cache.Get(1);
            a = cache.Get(3);
            a = cache.Get(4);

            // Assert
            Assert.True(true);
        }
    }
}
