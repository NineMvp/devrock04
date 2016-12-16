using System;
using Xunit;
using ClassLibrary;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void TestCountString() 
        {
            var testWord = "DEVROCK#04";
            
            Assert.True(StringLib.Count(testWord) > 10);
        }
    }
}
