using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace WeatherService.Tests
{
    [TestClass]
    public class WeatherServiceTests
    {

        [TestMethod]
        public void CanCallTheWeatherDao()
        {
            // arrange
            StubWeatherDao stub = new StubWeatherDao();
            WeatherService service = new WeatherService(stub);

            // act
            int result = service.CurrentTemp();

            // assert
            Assert.AreEqual(75, result);
        }

        [TestMethod]
        public void CanCallTheWeatherDao_WithMock()
        {
            // Arrange
            Mock<IWeatherDao> mock = new Mock<IWeatherDao>();
            WeatherService service = new WeatherService(mock.Object);
            mock.Setup(x => x.GetCurrentTemperature()).Returns(32);

            // Act
            int result = service.CurrentTemp();

            // Assert
            Assert.AreEqual(32, result);
        }


        [TestMethod]
        public void CanConvertTemperature_ToString()
        {
            // arrange
            Mock<IWeatherDao> mock = new Mock<IWeatherDao>();
            WeatherService service = new WeatherService(mock.Object);
            Temperature temp = new Temperature()
                                   {
                                       temp = 75,
                                       scale = "F"
                                   };
            mock.Setup(x => x.ConvertToString(It.IsAny<Temperature>())).Returns("75 F");

            // act
            string result = service.convert(temp);

            // assert
            Assert.AreEqual("75 F", result);
        }
    }

    public class StubWeatherDao : IWeatherDao
    {
        public int GetCurrentTemperature()
        {
            return 75;
        }

        public string ConvertToString(Temperature obj)
        {
            throw new NotImplementedException();
        }
    }
}
