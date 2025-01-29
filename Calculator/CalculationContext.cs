using Calculator.Strategies;

namespace Calculator
{
    public class CalculationContext
    {
        public double ExecuteStrategy(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+": return new AdditionStrategy().Calculate(a, b);
                case "-": return new SubtractionStrategy().Calculate(a, b);
                case "*": return new MultiplicationStrategy().Calculate(a, b);
                case "/": return new DivisionStrategy().Calculate(a, b);
                default:
                    throw new ArgumentException($"Invalid operator: {operation}. Valid operators are +, -, *, /");
            }
        }
    }
}
