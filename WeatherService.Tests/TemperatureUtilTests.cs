using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherService.Tests
{
    [TestClass]
    public class TemperatureUtilTests
    {
        private TemperatureUtil util;

        [TestInitialize]
        public void SetUp()
        {
            util = new TemperatureUtil();
        }

        [TestCleanup]
        public void TearDown()
        {
            util = null;
        }

        [TestMethod]
        public void CanDetermineIf80DegreesIsNotFreezing()
        {
            Assert.IsFalse(util.isFreezing(80), "80 degrees should not be freezing");
        }

        [TestMethod]
        public void CanDetermineIf29DegreesIsFreezing()
        {
            Assert.IsTrue(util.isFreezing(29), "29 degrees should be freezing");
        }

        [TestMethod]
        public void CanConvertFahrenheitValueOf32ToCelsius0()
        {
            Assert.AreEqual(0, util.ConvertToCelsius(32), "could not convert 32 F to 0 C");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "cannot convert absolute zero")]
        public void ThrowsExceptionWhenConvertingAbsoluteZero()
        {
            util.ConvertToCelsius(-460);
        }
    }
}
