using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(16, 4)]
        public void CalculatorTests(
            double firstValue,
            double expected)
        {
            var calculator = new Sqrt();
            var actualResult = calculator.Calculate(firstValue);
            Assert.Throws<Exception>(() => calculator.Calculate(-1));
            Assert.AreEqual(expected, actualResult);
        }
    }
}