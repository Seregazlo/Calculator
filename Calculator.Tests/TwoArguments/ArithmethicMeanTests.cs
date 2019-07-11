using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class ArithmeticMeanTests
    {
        [TestCase(1, 3, 2)]
        public void CalculatorTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new ArithmeticMean();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}