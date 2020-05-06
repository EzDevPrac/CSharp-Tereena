using System;
using AbstractFactoryDesign;
using Xunit;

namespace AbstractFactory.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            VehicleFactory honda = new HondaFactory();
            VehicleClient hondaclient = new VehicleClient(honda, "Regular");
            string actual = hondaclient.GetBikeName();
            string expected = "Regular Bike- Name";
            Assert.Equal(expected, actual);
        }
    }
}
