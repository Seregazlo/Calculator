using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class minxyTests
    {
        [TestCase(1, 3, 1)]
        public void CalculatorTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new minxy();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}