﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class ModTests
    {
        [TestCase(-1, 1)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Mod();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}