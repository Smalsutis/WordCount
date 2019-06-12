using System;
using System.Collections.Generic;
using System.Text;
using WordCount;
using Xunit;

public class WordCounterTest
{
    [Fact]
    public void ShouldCalculateLength()
    {
        var counter = new WordCounter();
        var result = counter.calculate("I have a transportation device which is a red bike which I love to ride.");

        Assert.Contains("I, 2", result);
        Assert.Contains("have, 1", result);
        Assert.Contains("a, 2", result);
        Assert.Contains("transportation, 1", result);
        Assert.Contains("device, 1", result);
        Assert.Contains("which, 2", result);
        Assert.Contains("is, 1", result);
        Assert.Contains("love, 1", result);
        Assert.Contains("to, 1", result);
        Assert.Contains("ride, 1", result);
    }
}