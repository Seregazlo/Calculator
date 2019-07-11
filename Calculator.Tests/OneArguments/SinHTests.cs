using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class SinHTests
    {
        [TestCase(0, 0)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new SinH();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}