using System;
using Xunit;
using Apples;

namespace xUnitTest
{
    public class ApplesTest
    {
        
        [Fact]
        public void Test1()
        {
            Apple apple = new Apple();

            Assert.Equal("Apple", apple.GetApple());
        }
    }
}
