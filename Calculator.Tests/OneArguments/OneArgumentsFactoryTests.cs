using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class OneArgumentsFactoryTests
    {
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Exponent", typeof(Exponentation))]
        [TestCase("Sqrt", typeof(Sqrt))]
        [TestCase("Arcsin", typeof(Arcsin))]
        [TestCase("AcrTan", typeof(ArcTan))]
        [TestCase("Mod", typeof(Mod))]
        [TestCase("CosH", typeof(CosH))]
        [TestCase("Acrcos", typeof(Acrcos))]
        [TestCase("Tan", typeof(Tan))]
        [TestCase("Log10", typeof(Log10))]
        [TestCase("stx", typeof(stx))]
        [TestCase("xten", typeof(xten))]
        [TestCase("fx", typeof(fx))]
        [TestCase("SinH", typeof(SinH))]
        [TestCase("tanh", typeof(tanh))]
        [TestCase("exp", typeof(exp))]
        public void CalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}