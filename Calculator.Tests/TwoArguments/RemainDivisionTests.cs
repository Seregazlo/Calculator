using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class RemainDivisionTests
    {
        [TestCase(10, 5, 0)]
        public void CalculatorTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new RemainDivision();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}