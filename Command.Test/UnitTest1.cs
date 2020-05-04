using System;
using CommandDesign;
using Xunit;

namespace Command.Test
{
    public class UnitTest1
    {
        [Fact]
        public void LightTurnOn_ShouldReturn_TheLightIsOn()
        {
            Light lamp = new Light();
            String actual = lamp.TurnOn();
            String expected = "The light is on";
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void LightTurnOff_ShouldReturn_TheLightIsOff()
        {
            Light lamp = new Light();
            String actual = lamp.TurnOff();
            String expected = "The light is off";
            Assert.Equal(actual, expected);
        }


    }
}
