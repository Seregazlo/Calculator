using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class expTests
    {
        [TestCase(0, 1)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new exp();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}