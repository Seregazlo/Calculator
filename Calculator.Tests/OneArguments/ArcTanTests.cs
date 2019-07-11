using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class ArcTanTests
    {
        [TestCase(0, 0)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new ArcTan();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}