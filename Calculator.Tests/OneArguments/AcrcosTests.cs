using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class AcrcosTests
    {
        [TestCase(1, 0)]
        [TestCase(-1, 3.14)]
        [TestCase(0.3, 1.26)]

        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Acrcos();
            Assert.Throws<Exception>(() => calculator.Calculate(6));
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
