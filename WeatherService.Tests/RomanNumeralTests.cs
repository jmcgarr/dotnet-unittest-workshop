using System;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherService.Tests
{
    [TestClass]
    public class RomanNumeralTests
    {
        private RomanNumeralCalculator calculator;

        [TestInitialize]
        public void InitializeTest()
        {
            calculator  = new RomanNumeralCalculator();
        }

        [TestCleanup]
        public void DestroyTest()
        {
            calculator = null;
        }

        [TestMethod]
        public void CanConvert_1_to_I()
        {
            string result = calculator.Convert(1);
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void CanConvert_2_to_II()
        {
            string result = calculator.Convert(2);
            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void CanConvert_3_to_III()
        {
            string result = calculator.Convert(3);
            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void CanConvert_4_to_IV()
        {
            string result = calculator.Convert(4);
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void CanConvert_5_to_V()
        {
            Assert.AreEqual("V", calculator.Convert(5));
        }

        [TestMethod]
        public void CanConvert_6_to_VI()
        {
            Assert.AreEqual("VI", calculator.Convert(6));
        }

        [TestMethod]
        public void CanConvert_7_to_VII()
        {
            Assert.AreEqual("VII", calculator.Convert(7));
        }

        [TestMethod]
        public void CanConvert_8_to_VIII()
        {
            Assert.AreEqual("VIII", calculator.Convert(8));
        }

        [TestMethod]
        public void CanConvert_9_to_IX()
        {
            Assert.AreEqual("IX", calculator.Convert(9));
        }

        [TestMethod]
        public void CanConvert_10_to_X()
        {
            Assert.AreEqual("X", calculator.Convert(10));
        }

        [TestMethod]
        public void CanConvert_11_to_XI()
        {
            Assert.AreEqual("XI", calculator.Convert(11));
        }

        [TestMethod]
        public void CanConvert_12_to_XII()
        {
            Assert.AreEqual("XII", calculator.Convert(12));
        }

        [TestMethod]
        public void CanConvert_13_to_XIII()
        {
            Assert.AreEqual("XIII", calculator.Convert(13));
        }

        [TestMethod]
        public void CanConvert_14_to_XIV()
        {
            Assert.AreEqual("XIV", calculator.Convert(14));
        }

        [TestMethod]
        public void CanConvert_15_to_XV()
        {
            Assert.AreEqual("XV", calculator.Convert(15));
        }

        [TestMethod]
        public void CanConvert_16_to_XVI()
        {
            Assert.AreEqual("XVI", calculator.Convert(16));
        }
    }

    public class RomanNumeralCalculator
    {
        public string Convert(int i)
        {
            StringBuilder sb = new StringBuilder();
            if (i%10 > 0)
            {
                int remainder = i%10;
                sb.Append(ConvertOneToTen(remainder));
                i -= remainder;
            }
            while (i > 0)
            {
                sb.Insert(0, ConvertOneToTen(10));
                i -= 10;
            }
            return sb.ToString();
        }

        public string ConvertOneToTen(int i)
        {
            if (i > 0 && i <= 10)
            {
                switch (i)
                {
                    case 1:
                    case 2:
                    case 3:
                        return "".PadLeft(i, 'I');
                    case 4:
                        return "IV";
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        return "V".PadRight(i - 4, 'I');
                    case 9:
                        return "IX";
                    case 10:
                        return "X";
                    default:
                        throw new InvalidOperationException();
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
