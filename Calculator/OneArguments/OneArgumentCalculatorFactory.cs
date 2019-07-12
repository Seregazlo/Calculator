using System;

namespace Calculator.OneArguments
{
    public static class OneArgumentCalculatorsFactory
    {
        /// <summary>
        /// That one arguments functions
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static IOneArgumentCalculators CreateCalculator(string Name)
        {
            switch (Name)
            {
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Exponent":
                    return new Exponentation();
                case "Sqrt":
                    return new Sqrt();
                case "Arcsin":
                    return new Arcsin();
                case "AcrTan":
                    return new ArcTan();
                case "Mod":
                    return new Mod();
                case "CosH":
                    return new CosH();
                case "Acrcos":
                    return new Acrcos();
                case "Tan":
                    return new Tan();
                case "Log10":
                    return new Log10();
                case "stx":
                    return new StX();
                case "xten":
                    return new XTen();
                case "fx":
                    return new FalseX();
                case "SinH":
                    return new SinH();
                case "tanh":
                    return new TanH();
                case "exp":
                    return new Exp();
                default:
                    throw new Exception("Error");
            }
        }

    }
}