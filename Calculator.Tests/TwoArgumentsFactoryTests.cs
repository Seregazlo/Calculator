﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class TwoArgumentsFactoryTests
    {
        [TestCase("Difference",typeof(Discripter))]
        [TestCase("Addition", typeof(Adder))]
        [TestCase("Multiplication", typeof(Mulitipleer))]
        [TestCase("Division", typeof(Divider))]
        [TestCase("Pow", typeof(Pow))]
        [TestCase("RemainDivision", typeof(RemainDivision))]
        [TestCase("ArithmeticMean", typeof(ArithmeticMean))]
        [TestCase("logxy", typeof(logxy))]
        [TestCase("minxy", typeof(minxy))]
        [TestCase("maxxy", typeof(maxxy))]
        [TestCase("xoney", typeof(xoney))]
        public void CalculatorTest(string name,Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}