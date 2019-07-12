using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
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
        [TestCase("stx", typeof(StX))]
        [TestCase("xten", typeof(XTen))]
        [TestCase("fx", typeof(FalseX))]
        [TestCase("SinH", typeof(SinH))]
        [TestCase("tanh", typeof(TanH))]
        [TestCase("exp", typeof(Exp))]
        public void CalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentCalculatorsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}