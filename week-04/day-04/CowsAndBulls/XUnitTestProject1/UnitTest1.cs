using System;
using Xunit;
using CowsAndBull;

namespace xUnitTest
{
    public class ApplesTest
    {
        
        [Fact]
        public void Test1()
        {
            var guesser = new CowsAndBulls();
            for (int num = 0; num < 100000; num++)
            {
                if (num < 1000 || num>9999)
                {
                    Assert.Equal("bad input", guesser.Guess(num));
                }
                else
                {
                    Assert.NotEqual("bad input", guesser.Guess(num));
                }
            }
        }
        [Fact]
        public void Test2()
        {
            var guesser = new CowsAndBulls();
            Assert.Equal(0, guesser.CountBulls("1234", "1234"));
            Assert.Equal(1, guesser.CountBulls("1234","1231"));
            Assert.Equal(2, guesser.CountBulls("1234", "1241"));
            Assert.Equal(3, guesser.CountBulls("1234", "1341"));
            Assert.Equal(4, guesser.CountBulls("1234", "2341"));
        }

        [Fact]
        public void Test3()
        {
            var guesser = new CowsAndBulls();
            Assert.Equal(4, guesser.CountCows(guesser.Goal));
            Assert.Equal(3, guesser.CountCows(new string(String.Empty + guesser.Goal[0] + guesser.Goal[1] + guesser.Goal[2] + guesser.Goal[0])));
            Assert.Equal(2, guesser.CountCows(new string(String.Empty + guesser.Goal[0] + guesser.Goal[1] + guesser.Goal[1] + guesser.Goal[0])));
            Assert.Equal(1, guesser.CountCows(new string(String.Empty + guesser.Goal[0] + guesser.Goal[2] + guesser.Goal[1] + guesser.Goal[0])));
            Assert.Equal(0, guesser.CountCows(new string(String.Empty + guesser.Goal[3] + guesser.Goal[2] + guesser.Goal[1] + guesser.Goal[0])));
        }
    }
}
