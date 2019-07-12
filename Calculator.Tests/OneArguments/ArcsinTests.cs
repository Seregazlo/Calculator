using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class ArcsinTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.57)]
        [TestCase(-1, -1.57)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Arcsin();
            var actualResult = calculator.Calculate(firstValue);
            Assert.Throws<Exception>(() => calculator.Calculate(-5));
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
