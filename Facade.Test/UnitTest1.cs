using System;
using FacadeDesign;
using Xunit;

namespace Facade.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GetNonVegPizza_ShouldReturn_GettingNonVegPizza()
        {
            var facadeForClient = new RestaurantFacade();
            String str = facadeForClient.GetNonVegPizza();
            Assert.Equal("Getting Non Veg Pizza.", str);
        }

        [Fact]
        public void GetVegPizza_ShouldReturn_GettingVegPizza()
        {
            var facadeForClient = new RestaurantFacade();
            string str = facadeForClient.GetVegPizza();
            Assert.Equal("Getting Veg Pizza.", str);
        }
    }
}
