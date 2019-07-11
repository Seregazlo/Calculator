using System;
using Calculator.OneArguments;

namespace Calculator
{
    public class OneArgumentsFactory
    {
        /// <summary>
        /// That one arguments functions
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static IOneArgumentsCalculator CreateCalculator(string Name)
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
                        return new stx();
                    case "xten":
                        return new xten();
                    case "fx":
                        return new fx();
                    case "SinH":
                        return new SinH();
                    case "tanh":
                        return new tanh();
                    case "exp":
                        return new exp();
                    default:
                        throw new Exception("Error");
                }
            }
        
    }
}