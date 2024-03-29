﻿using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class Log10Tests
    {
        [TestCase(1, 0)]
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Log10();
            var actualResult = calculator.Calculate(firstValue);
            Assert.Throws<Exception>(() => calculator.Calculate(-5));
            Assert.AreEqual(expected, actualResult);
        }
    }
}