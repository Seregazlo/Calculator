using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class OneArgumentsFactory
    {
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
                    default:
                        throw new Exception("Error");
                }
            }
        
    }
}