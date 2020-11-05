using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace Calculator.models
{
    public enum CalculationType
    {
        ADDITION,
        SUBTRACTION,
        DIVISTION,
        MULTIPLICATION
    }

    public class Calculator
    {
        public decimal Calculate(decimal number1, decimal number2, CalculationType calculationType)
        {
            switch (calculationType)
            {
                case CalculationType.ADDITION:
                    return MakeAddition(number1, number2);

                case CalculationType.SUBTRACTION:
                    return MakeSubtraction(number1, number2);

                case CalculationType.DIVISTION:
                    return MakeDivision(number1, number2);

                case CalculationType.MULTIPLICATION:
                    return MakeMultiplication(number1, number2);

                default:
                    throw new NotImplementedException($"Calculation {calculationType} is not implemented!");

            }
        }

        private decimal MakeAddition(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        private decimal MakeSubtraction(decimal number1, decimal number2)
        {
            return number1 - number2;
        }

        private decimal MakeMultiplication(decimal number1, decimal number2)
        {
            return number1 * number2;
        }

        private decimal MakeDivision(decimal number1, decimal number2)
        {
            return number1 / number2;
        }
    }
}
