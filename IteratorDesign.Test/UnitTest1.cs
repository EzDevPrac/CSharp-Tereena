using System;
using IteratorDesign;
using Xunit;

namespace IteratorDesign.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Next_ShouldReturn_FirstUser()
        {
            ISocialNetworking fb = new Facebook();
            Iterator fbIterator = fb.CreateIterator();
            PrintUsers(fbIterator);
            
        }

        private void PrintUsers(Iterator fbIterator)
        {
            string actual=fbIterator.Next();
            string expected = "Terna";
            Assert.Equal(expected, actual);
            //string actual1 = fbIterator.Next();
            //Assert.Equal("Lavanya", actual1);
        }
    }
}
