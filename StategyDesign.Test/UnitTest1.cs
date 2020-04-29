using System;
using StrategyDesign;
using Xunit;

namespace StategyDesign.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            CalculateClient minusClient = new CalculateClient(new Minus());
            int expected = 6;
            int actual = minusClient.Calculate(7, 1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            CalculateClient plusClient = new CalculateClient(new Plus());
            int expected = 8;
            int actual = plusClient.Calculate(7, 1);
            Assert.Equal(expected, actual);
        }
    }
}
