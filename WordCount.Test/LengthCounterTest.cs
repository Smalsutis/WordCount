using System;
using Xunit;

namespace WordCount.Test
{
    public class LengthCountTest
    {
        [Fact]
        public void ShouldCalculateLength()
        {
            var counter = new LengthCounter();
            var result = counter.calculate("I have a transportation device which is a red bike which I love to ride.");

            Assert.Contains("1, 4", result);
            Assert.Contains("4, 4", result);
            Assert.Contains("14, 1", result);
            Assert.Contains("6, 1", result);
            Assert.Contains("5, 2", result);
            Assert.Contains("2, 2", result);
            Assert.Contains("3, 1", result);
        }
    }
}
