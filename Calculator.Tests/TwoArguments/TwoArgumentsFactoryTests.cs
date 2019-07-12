using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class TwoArgumentsFactoryTests
    {
        [TestCase("Difference", typeof(Discripter))]
        [TestCase("Addition", typeof(Adder))]
        [TestCase("Multiplication", typeof(Mulitipleer))]
        [TestCase("Division", typeof(Divider))]
        [TestCase("Pow", typeof(Pow))]
        [TestCase("RemainDivision", typeof(RemainDivision))]
        [TestCase("ArithmeticMean", typeof(ArithmeticMean))]
        [TestCase("logxy", typeof(LogXY))]
        [TestCase("minxy", typeof(MinXY))]
        [TestCase("maxxy", typeof(MaxXY))]
        [TestCase("xoney", typeof(XoneY))]
        public void CalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentCalculatorsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}