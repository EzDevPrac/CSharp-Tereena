using System;
using ProxyDesign;
using Xunit;

namespace ProxyDesign.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ProxyPolygon proxyClass = new ProxyPolygon();
            proxyClass.Details();
            string actual = proxyClass.GetShape();
            string expected = "This is polygon shape from real/ actual class";
            Assert.Equal(expected, actual);


        }
    }
}
