using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class AcrcosTests
    {
        [TestCase(1, 0)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Acrcos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
