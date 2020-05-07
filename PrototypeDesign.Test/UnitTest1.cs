using System;
using PrototypeDesign;
using Xunit;

namespace PrototypeDesign.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            AuthorForDeepCopy o = new AuthorForDeepCopy();
            //string actual = o.Name;
            o.Name = "Sukesh Marla";
            string expected = "Sukesh Marla";
            Assert.Equal(expected,o.Name);
        }
    }
}
