using System;
using Xunit;

namespace Calculatore.Tests
{
    public class UnitTest1
    {
        [Fact(DisplayName ="Test der Addition")]
        public void TestAddition()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(1.5m, 3.5m, Calculator.models.CalculationType.ADDITION);
            Assert.Equal(5.0m, result);
        }

        [Fact(DisplayName = "Test der Subtration")]
        public void TestSubtration()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(5m, 3.5m, Calculator.models.CalculationType.SUBTRACTION);
            Assert.Equal(1.5m, result);
        }

        [Fact(DisplayName = "Test der Division")]
        public void TestDivision()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();

            Assert.Throws<DivideByZeroException>(() =>
            {
                decimal result = calc.Calculate(6.0m, 0.0m, Calculator.models.CalculationType.DIVISTION);
                Assert.IsType<decimal>(result);

            });
        }

        [Fact(DisplayName = "Test der Multiplikation")]
        public void TestMultiplikation()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(3.0m, 3.0m, Calculator.models.CalculationType.MULTIPLICATION);
            Assert.Equal(9.0m, result);
        }
    }
}
