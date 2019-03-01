using NUnit.Framework;
using SimpleCalc;

namespace SimpleCalculatorEngine.Test
{
    [TestFixture]
    public class Tests
    {
        private readonly CalculateNumber _simpleCalc = new CalculateNumber();

        [TestCase]
        public void AddsTwoNumbersAndReturnValidResultForNonSymbolOperation()
        {
            double number1 = 1;
            double number2 = 2.4;
            double result = _simpleCalc.Calculate("tambah", number1, number2);
            Assert.AreEqual(3.4, result);
        }

        [TestCase]
        public void AddsTwoNumbersAndReturnValidResultForSymbolOperation()
        {
            double number1 = 1.3;
            double number2 = 2.4;
            double result = _simpleCalc.Calculate("+", number1, number2);
            Assert.AreEqual(3.7, result);
        }
        [TestCase]
        public void SubstractTwoNumbersAndReturnValidResultForNonSymbolOperation()
        {
            double number1 = 3.5;
            double number2 = 2.4;
            double result = _simpleCalc.Calculate("pengurangan", number1, number2);
            Assert.AreEqual(1.1, result);
        }

        [TestCase]
        public void SubstractTwoNumbersAndReturnValidResultForSymbolOperation()
        {
            double number1 = 1;
            double number2 = 2.5;
            double result = _simpleCalc.Calculate("-", number1, number2);
            Assert.AreEqual(-1.5, result);
        }
        [TestCase]
        public void DivideTwoNumbersAndReturnValidResultForNonSymbolOperation()
        {
            double number1 = 10;
            double number2 = 2;
            double result = _simpleCalc.Calculate("pembagian", number1, number2);
            Assert.AreEqual(5, result);
        }

        [TestCase]
        public void DivideTwoNumbersAndReturnValidResultForSymbolOperation()
        {
            double number1 = 5;
            double number2 = 2;
            double result = _simpleCalc.Calculate("/", number1, number2);
            Assert.AreEqual(2.5, result);
        }
        [TestCase]
        public void MultiplyTwoNumbersAndReturnValidResultForNonSymbolOperation()
        {
            double number1 = 10;
            double number2 = 2;
            double result = _simpleCalc.Calculate("PErKaLiaN", number1, number2);
            Assert.AreEqual(20, result);
        }

        [TestCase]
        public void MultiplyTwoNumbersAndReturnValidResultForSymbolOperation()
        {
            double number1 = 5.5;
            double number2 = 2.5;
            double result = _simpleCalc.Calculate("*", number1, number2);
            Assert.AreEqual(13.75, result);
        }

    }
}