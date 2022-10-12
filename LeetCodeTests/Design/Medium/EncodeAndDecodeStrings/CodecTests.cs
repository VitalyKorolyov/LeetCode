using LeetCode.Design.Medium.EncodeAndDecodeStrings;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.Design.Medium.EncodeAndDecodeStrings
{
    public class CodecTests
    {
        [Fact]
        public void encode_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var codec = new Codec();

            // Act
            var result = codec.encode(new List<string> { "Hello", "World"});
            var str = codec.decode(result);

            // Assert
            Assert.True(true);
        }
    }
}
