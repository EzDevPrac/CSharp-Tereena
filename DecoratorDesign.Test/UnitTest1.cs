using System;
using DecoratorDesign;
using Xunit;

namespace DecoratorDesign.Test
{
    public class UnitTest1
    {
        [Fact]
        public void SuzukiMake_ShouldReturn_Sedan_SuzukiGetPrice_ShouldReurn_Price()
        {
            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);
            string actual = decorator.Make;
            string expected = car.Make;
            Assert.Equal(expected,actual);
            Assert.Equal(car.GetPrice(), decorator.GetPrice());
        }
    }
}
