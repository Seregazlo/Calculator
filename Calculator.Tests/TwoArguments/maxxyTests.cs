using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class maxxyTests
    {
        [TestCase(1, 3, 3)]
        public void CalculatorTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new maxxy();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}