﻿using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class maxxyTests
    {
        [TestCase(1, 3, 3)]
        [TestCase(4, 2, 4)]
        [TestCase(4, 6, 6)]
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