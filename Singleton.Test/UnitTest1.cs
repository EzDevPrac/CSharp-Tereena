using System;
using NoThreadSafeSingletonDesign;
using Xunit;

namespace SingletonDesign.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            string str=fromTeacher.PrintDetails("From Teacher");
            Assert.Equal("From Teacher",str);
        }
    }
}
