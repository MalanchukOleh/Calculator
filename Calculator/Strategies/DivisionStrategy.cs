
namespace Calculator.Strategies
{
    public class DivisionStrategy : ICalculationStrategy
    {
        public double Calculate(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Division by zero is not allowed.");
            return a / b;
        }
    }

}
