namespace Calculator.Strategies
{
    public class SubtractionStrategy : ICalculationStrategy
    {
        public double Calculate(double a, double b) => a - b;
    }
}
