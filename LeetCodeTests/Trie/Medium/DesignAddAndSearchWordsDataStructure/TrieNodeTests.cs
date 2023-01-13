using LeetCode.Trie.Medium.DesignAddAndSearchWordsDataStructure;
using Xunit;

namespace LeetCodeTests.Trie.Medium.DesignAddAndSearchWordsDataStructure;
public class TrieNodeTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var wordDict = new WordDictionary();
        wordDict.AddWord("a");
        wordDict.AddWord("a");

        var res = wordDict.Search(".");
        Assert.True(res);

        res = wordDict.Search("a");
        Assert.True(res);

        res = wordDict.Search("aa");
        Assert.False(res);

        res = wordDict.Search("a");
        Assert.True(res);

        res = wordDict.Search(".a");
        Assert.False(res);

        res = wordDict.Search("a.");
        Assert.False(res);
    }
}
