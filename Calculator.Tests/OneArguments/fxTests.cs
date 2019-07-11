using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class fxTests
    {
        [TestCase(2, -2)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new fx();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}