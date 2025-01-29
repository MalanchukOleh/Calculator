
namespace Calculator.Strategies
{
    public class AdditionStrategy : ICalculationStrategy
    {
        public double Calculate(double a, double b)
        {
            double result = a + b;
            if (double.IsInfinity(result))
            {
                throw new OverflowException("Multiplication result is too large.");
            }
            return result;
        }
    }
}
