using System;
using System.Collections.Generic;
using AdapterDesign;
using Xunit;

namespace AdapterDesign.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ITarget adapter = new VendorAdapter();
            var actual=adapter.GetProducts();
            var expected= new List<string>();
            expected.AddRange(new[] { "Gaming Consoles", "Television", "Books", "Musical Instruments" });
            Assert.Equal(expected, actual);
        }
    }
}
