using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class XoneYTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(9, 2, 3)]
        public void CalculatorTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new XoneY();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.Throws<Exception>(() => calculator.Calculate(2, 0));
            Assert.AreEqual(expected, actualResult);
        }
    }
}