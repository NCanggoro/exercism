using NUnit.Framework;
using SimpleCalc;
using System;

namespace SimpleCalculatorEnginte.Test
{
    [TestFixture]
    public class ConvertInputTest
    {
        private readonly ConvertInput _convertInput = new ConvertInput();

        [TestCase]
        public void ConvertValidStringToDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _convertInput.Convert(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [Test]
        public void FailsToConvertStringToDouble()
        {
            Assert.That(() => _convertInput.Convert("*"), Throws.TypeOf<Exception>());
        }
    }
}
