﻿using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DifferenceTests
    {
        [Test]
        public void CalculatorTests()
        {
            var calculator = new Discripter();
            double actual = calculator.Calculate(3, 2);
            Assert.AreEqual(1, actual: actual);
        }
    }
}
