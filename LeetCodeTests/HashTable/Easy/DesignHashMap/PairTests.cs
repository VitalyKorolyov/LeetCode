using LeetCode.HashTable.Easy.DesignHashMap;
using System;
using Xunit;

namespace LeetCodeTests.HashTable.Easy.DesignHashMap
{
    public class PairTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var hashMap = new MyHashMap();
            int res;

            // Act
            hashMap.Put(1, 1);
            hashMap.Put(2, 2);
            hashMap.Put(1, 10);
            hashMap.Put(10002, 3);
            res = hashMap.Get(1);
            Assert.Equal(10, res);
            res = hashMap.Get(10002); 
            Assert.Equal(3, res);
            hashMap.Remove(10002);
        }
    }
}
